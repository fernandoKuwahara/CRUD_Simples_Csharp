using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App___CRUD_Simples
{
    public partial class JanelaDeMenu : Form
    {

        Conexao conexao = new Conexao();

        public JanelaDeMenu()
        {
            InitializeComponent();
        }

        //email disponivel para envio e uso nesta ou mais classes
        private String email;

        //recebe o email vindo da tela de login
        public void PegarEmail(String email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //instância a janela de login
            JanelaDeLogin janelaDeLogin = new JanelaDeLogin();

            //abre a janela de login
            janelaDeLogin.Show();

            //fecha a tela atual
            Hide();
        }

        //executa quando chamado, e atualiza os dados do usuário
        public void informaçõesParaJanelaDoMenu()
        {
            MySqlDataReader dadosDoUsuario = conexao.informacoesDoUsuario(email);

            //atribui o nome do usuário para o label
            lblNomeDoUsuario.Text = dadosDoUsuario.GetString("nome");

            //formata o saldo e atribui para o label de saldo, mas que infelizmente o resultado não está sendo igual o desejado
            lblSaldoDoUsuario.Text = String.Format("{0:N2}", Convert.ToDouble(dadosDoUsuario.GetString("saldo")));

            //atribui quantas compras o usuário, já fez no sistema de listas
            lblComprasJaFeitasDoUsuario.Text = dadosDoUsuario.GetString("comprasRealizadas");

            dadosDoUsuario.Close();
        }

        private void btnDeletarConta_Click(object sender, EventArgs e)
        {
            decimal valorDoSaldo = Convert.ToDecimal(lblSaldoDoUsuario.Text);

            //confirma se o valor do saldo é zero para que possa exlcuir conta
            if (valorDoSaldo == 0)
            {
                //instância tela de deletar conta
                JanelaDeletarConta janelaDeletarConta = new JanelaDeletarConta();

                //envia o email do usuário 
                janelaDeletarConta.PegarEmail(email);

                //abre o formulário de deletar conta
                janelaDeletarConta.Show();

                //fecha o formulário atual
                Hide();
            }
            else
                MessageBox.Show("Saldo Fora Dos Limites, Quite O Seu Saldo Antes, Para Deletar Sua Conta!", "ATENÇÃO - Ação Não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //fecha o formulário atual, clicando do X da janela
        private void JanelaDeMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMudarSenha_Click(object sender, EventArgs e)
        {
            //instância a janela de mudar senha
            JanelaMudarSenha JanelaMudarSenha = new JanelaMudarSenha();

            //abre a tela de mudar senha
            JanelaMudarSenha.Show();

            //fecha a tela atual
            Hide();
        }

        private void btnCriarLista_Click(object sender, EventArgs e)
        {
            //instância o formulário de criar listas
            Form1 form1 = new Form1();

            //envia o email para relacionar a compra, com o usuário
            form1.PegarEmail(email);

            //abre o formulário de criar listas
            form1.Show();

            //fecha o formulário atual
            Hide();
        }

        private void btnQuitarSaldo_Click(object sender, EventArgs e)
        {
            decimal saldo = Convert.ToDecimal(lblSaldoDoUsuario.Text);

            //confirma se o saldo é maior que zero
            if (saldo > 0)
            {
                try
                {
                    //envia o email para confirmação no banco de dados, para quitar saldo
                    String sucesso = conexao.quitarSaldo(email);

                    //mensagem de retorno vindo do banco de dados
                    MessageBox.Show(sucesso);

                    //executa o método e atualiza os dados do menu
                    informaçõesParaJanelaDoMenu();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(Convert.ToString(erro));
                }
            }

            //caso não seja maior que zero o saldo, envia esta mensagem de alerta, não premitindo que o usuário faça a ação
            else
                MessageBox.Show("Você Não Possui Saldo Para Ser Pago, Parabéns", "ATENÇÃO - Não É Possivel Fazer Está Ação No Momento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
