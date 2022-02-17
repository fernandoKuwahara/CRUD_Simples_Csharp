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
    public partial class JanelaMudarSenha : Form
    {

        public JanelaMudarSenha()
        {
            InitializeComponent();
        }

        //fechar formulário ao clicar no X da janela
        private void JanelaMudarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //intância a janela de login
            JanelaDeLogin JanelaDeLogin = new JanelaDeLogin();

            //abre o formulário de login
            JanelaDeLogin.Show();

            //fecha o formulário atual
            Dispose();
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            //confere se o textBox do email do usuário é vazio
            if (txtEmailDoUsuario.Text.Equals(""))
                MessageBox.Show("Informe Seu Email Para Que Possa Mudar a Senha, Por Favor!", "ATENÇÃO - Campo Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            //faz a confirmação das duas senha, para confirmar que são as mesmas
            else if (txtSenhaNova.Text != txtConfirmarSenhaNova.Text)
                MessageBox.Show("As Senhas São Diferentes, Coloque As Duas Iguais Por Favor!", "ATENÇÃO - Campo Preenchido Errado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            //confere se os textBox de senha nova e confirmar senha nova, são vazios ou não
            else if (txtSenhaNova.Text.Equals("") || txtConfirmarSenhaNova.Text.Equals(""))
                MessageBox.Show("Existem Campos Ainda Não Preenchidos, Por Favor Preencha!", "ATENÇÃO - Campos Não Preenchidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //verifica se o email informado é válido ou não
                if (new VerificarEmail().verificacaoDeEmail(txtEmailDoUsuario.Text))
                {
                    String registro = "";
                    try
                    {
                        //envia os dados para o banco de dados, para poder salvar a senha nova
                        registro = new Conexao().mudarSenha(txtEmailDoUsuario.Text, txtConfirmarSenhaNova.Text);
                        MessageBox.Show(registro, "ATENÇÃO - Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        //limba os textBox
                        txtEmailDoUsuario.Text = "";
                        txtSenhaNova.Text = "";
                        txtConfirmarSenhaNova.Text = "";

                        //intância a janela de login
                        JanelaDeLogin janelaDeLogin = new JanelaDeLogin();

                        //abre a janela de login
                        janelaDeLogin.Show();

                        //fecha a janela atual
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
        }

        private void txtEmailDoUsuario_TextChanged(object sender, EventArgs e)
        {
            //desbloquia o botão de mudar a senha, que envia os dados para está ação
            if (txtEmailDoUsuario.Text.Equals(""))
            {
                btnMudarSenha.Enabled = false;
            }
            else
                btnMudarSenha.Enabled = true;
        }
    }
}
