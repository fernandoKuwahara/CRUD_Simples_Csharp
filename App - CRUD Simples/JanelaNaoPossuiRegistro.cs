using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App___CRUD_Simples
{
    public partial class JanelaNaoPossuiRegistro : Form
    {
        JanelaDeLogin janelaDeLogin = new JanelaDeLogin();

        public JanelaNaoPossuiRegistro()
        {
            InitializeComponent();
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //mostra o formulário de login na tela
            janelaDeLogin.Show();

            //fecha o formulário atual (no caso, o formulário de criação de conta)
            Dispose();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            //verificar se o texto do textBox de nome, não é vazio 
            if (txtNomeDeUsuario.Text.Equals(""))
                MessageBox.Show("Informe Seu Nome De Usuário Para Que Possa Criar Uma Conta, Por Favor!", "ATENÇÃO - Campo Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            //verificar se os textBox de email ou senha estão vazios
            else if (txtEmailDeUsuario.Text.Equals("") || txtSenhaDoUsuario.Text.Equals(""))
                MessageBox.Show("Campo De Email Ou Senha Não Foi Preenchido, Preencha-o Por Favor!", "ATENÇÃO - Campo Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            //instância um objeto VerificarEmail, e manda o texto do textBox de email, para verificar se o email é autêntico
            else if (new VerificarEmail().verificacaoDeEmail(txtEmailDeUsuario.Text))
            {
                String registro = "";
                try
                {
                    //envia os dados para serem confirmados no banco de dados
                    registro = new Conexao().cadastrarUsuario(txtNomeDeUsuario.Text, txtEmailDeUsuario.Text, txtSenhaDoUsuario.Text);
                    MessageBox.Show(registro, "ATENÇÃO - Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //limpa os campos
                    txtNomeDeUsuario.Text = "";
                    txtEmailDeUsuario.Text = "";
                    txtSenhaDoUsuario.Text = "";

                    //mostra o formulário de login
                    janelaDeLogin.Show();

                    //fecha o atual formulário
                    Dispose();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(Convert.ToString(erro));
                }
            }
            else
                MessageBox.Show("O Email Informado é Inválido, Preencha De Forma Autentica Por Favor!", "ATENÇÃO - Campo Preenchido De Maneira Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void JanelaNaoPossuiRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtNomeDeUsuario_TextChanged(object sender, EventArgs e)
        {
            //esse IF serve para poder desbloquear o botão de envio de dados
            if (txtNomeDeUsuario.Text.Equals(""))
            {
                btnCriarConta.Enabled = false;
            }
            else
                btnCriarConta.Enabled = true;
        }
    }
}
