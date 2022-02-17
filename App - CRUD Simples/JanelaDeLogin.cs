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
    public partial class JanelaDeLogin : Form
    {

        //objetos instanciados para usar em multiplos lugares na classe JanelaDeLogin
        JanelaMudarSenha JanelaMudarSenha = new JanelaMudarSenha();
        JanelaDeMenu janelaDeMenu = new JanelaDeMenu();
        VerificarEmail VerificarEmail = new VerificarEmail();

        public JanelaDeLogin()
        {
            InitializeComponent();
        }

        private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            //o IF ser para conferir se o textBox do email é vazio ou não
            if (txtEmail.Text.Equals(""))
                MessageBox.Show("Informe Email Para Que Possa Entrar Na Sua Conta, Por Favor!", "ATENÇÃO - Campo Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            //e este IF confere o textBox da senha
            else if (txtSenha.Text.Equals(""))
                MessageBox.Show("Informe Sua Senha Para Que Possa Entrar Na Sua Conta, Por Favor!", "ATENÇÃO - Campo Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            //este IF em específico retorna um bool, quando instância o objeto VerificarEmail, é utilizado um método dele
            //para verificar o que o usuário digitou no textBox de email, é um email autêntico ou não
            else if (VerificarEmail.verificacaoDeEmail(txtEmail.Text))
            {

                //o try catch vai servir para tratar possiveis erros que vierem no banco de dados
                try
                {
                    //retorna um bool, se for true, então o usuário foi registrado com sucesso
                    if (new Conexao().loginUsuario(txtEmail.Text, txtSenha.Text))
                    {
                        MessageBox.Show("Login Realizado Com Sucesso!", "SUCESSO - Bem Vindo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        //envia para o formulário de menu o email digitado pelo usuário
                        janelaDeMenu.PegarEmail(txtEmail.Text);

                        //executa um método para os dados do usuário pré logado, para o formulário de menu
                        janelaDeMenu.informaçõesParaJanelaDoMenu();

                        //abre o formulario de menu
                        janelaDeMenu.Show();

                        //fecha o formulário de login
                        Hide();
                    }

                    //se retornar false, é emitido esta mensagem de alerta
                    else
                        MessageBox.Show("Email Ou Senha Errados!", "ERRO - Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(Convert.ToString(erro), "ATENÇÃO - Erro No Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //caso retorne o bool como false, é emitido uma mensagem de alerta
            else
                MessageBox.Show("O Email Informado é Inválido, Preencha De Forma Autentica Por Favor!", "ATENÇÃO - Campo Preenchido De Maneira Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblAindaNaoPossuiRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //intância a janela de criar registro/conta
            JanelaNaoPossuiRegistro janelaNaoPossuiRegistro = new JanelaNaoPossuiRegistro();

            //mostra o formulário de criação de conta
            janelaNaoPossuiRegistro.Show();

            //fecha o formulário de login
            Hide();
        }

        private void lblEsqueceuSuaSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //mostra o formulário de mudar a senha
            JanelaMudarSenha.Show();

            //fecha o formulário de login
            Hide();
        }

        private void JanelaDeLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //para a execução do programa quando clica no X
            Environment.Exit(0);
        }
    }
}
