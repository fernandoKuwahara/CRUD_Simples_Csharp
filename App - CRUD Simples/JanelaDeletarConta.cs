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
    public partial class JanelaDeletarConta : Form
    {
        public JanelaDeletarConta()
        {
            InitializeComponent();
        }

        //email disponivel para uso em toda a classe
        private String email;

        //pega o email vindo do formulário de menu
        public void PegarEmail(String email)
        {
            this.email = email;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            //instância a janela de menu
            JanelaDeMenu janelaDeMenu = new JanelaDeMenu();

            //envia o email do usuário para o formulário de menu
            janelaDeMenu.PegarEmail(email);

            //chama e executa um método do formulário de menu para atualizar dados do menu
            janelaDeMenu.informaçõesParaJanelaDoMenu();

            //abre o formulário de menu
            janelaDeMenu.Show();

            //fecha tela atual
            Dispose();
        }

        //para a execução do programa ao clicar no X da janela do formulário
        private void JanelaDeletarConta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

       //botão desbloqueia o textBox para digitar um número de confirmação
       //e gera um número aleatório de 100 a 999
        private void btnSim_Click(object sender, EventArgs e)
        {
            //desblqueia o acesso para confirmar número de confirmação
            btnConfirmarNumero.Enabled = true;
            txtNumeroDeConfirmacao.Enabled = true;

            //bloqueia que o usuário possa voltar para tela de menu
            btnNao.Enabled = false;
            btnSim.Enabled = false;

            //sorteia o número de confirmação de 100 a 999
            int numeroDeConfirmacao = new Random().Next(100, 999);
            lblNumeroDeConfirmacao.Text = Convert.ToString(numeroDeConfirmacao);
        }

        private void btnDeletarConta_Click(object sender, EventArgs e)
        {
            try
            {
                //envia o email para confirmar qual usuário será deletado
                String emailExcluido = new Conexao().deletarUsuario(this.email);
                MessageBox.Show(emailExcluido, "ATENÇÃO - Conta Deletada", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //intância a janela de login depois de excluir usuário
                JanelaDeLogin janelaDeLogin = new JanelaDeLogin();

                //abre formulário de login
                janelaDeLogin.Show();

                //fecha o formulário atual
                Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnConfirmarNumero_Click(object sender, EventArgs e)
        {
            //confirma se o textBox do número de confirmação não é vazio
            if (txtNumeroDeConfirmacao.Text.Equals(""))
                MessageBox.Show("Informe Um Número, Por Favor!", "ATENÇÃO - Campo Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //confirma o número sorteado pelo número que o usuário digitou
                if (lblNumeroDeConfirmacao.Text.Equals(txtNumeroDeConfirmacao.Text))
                {
                    btnConfirmarNumero.Enabled = false;
                    txtNumeroDeConfirmacao.Enabled = false;
                    btnDeletarConta.Enabled = true;
                }
                else
                {
                    //caso digitado o número errado, retorna uma mensagem de alerta
                    MessageBox.Show("O Número Informado é Diferente do Número De Confirmação, Digite o Número Correto Por Favor!", "ATENÇÃO - Campo Preenchido De Maneira Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumeroDeConfirmacao.Text = "";
                }
            }
        }

        private void txtNumeroDeConfirmacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //confere se no textBox do número de confirmação, seja digitado apenas números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.Handled)
                MessageBox.Show("Digite Apenas Números, Por Favor!", "ATENÇÃO - Campo Preenchido De Maneira Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
