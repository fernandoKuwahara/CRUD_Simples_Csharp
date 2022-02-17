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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //email disponivel pra uso em toda classe atual
        private string email;

        //recebe o email, vindo do menu, para vincular compra ao usuário
        public void PegarEmail(String email)
        {
            this.email = email;
        }

        //instância a janela de menu
        JanelaDeMenu janelaDeMenu = new JanelaDeMenu();

        //fecha o formulário atual, clicando no X da janela
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //envia o email de volta para o menu
            janelaDeMenu.PegarEmail(email);

            //executa um método para atualizar dados da tela do menu
            janelaDeMenu.informaçõesParaJanelaDoMenu();

            //abre o formulário de menu
            janelaDeMenu.Show();

            //fecha o formulário atual
            Dispose();
        }

        //arrays de controle
        int[] controleDeIndice = { 0 };
        decimal[] quantidadeDeItensNaLista = new decimal[64];
        decimal[] precoDosItensNaLista = new decimal[64];
        decimal[] precoFinalTotal = new decimal[64];

        private void btnFinalizarLista_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao conexao = new Conexao();

                //converte o valor do preço para decimal
                decimal precoFinalDaLista = Convert.ToDecimal(lblPrecoFinal.Text);

                //envia os dados para o banco de dados, e retorna uma string
                String compraRealizada = conexao.fazerCompra(email, precoFinalDaLista);
                MessageBox.Show(compraRealizada, "ATENÇÃO - Compra Feita Com Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                //envia o email para o menu
                janelaDeMenu.PegarEmail(email);

                //executa para atualizar os dados no menu
                janelaDeMenu.informaçõesParaJanelaDoMenu();

                //abre o formulário do menu
                janelaDeMenu.Show();

                //fecha o formulário atual
                Dispose();
            }
            catch (Exception erro)
            {
                MessageBox.Show(Convert.ToString(erro));
            }
        }


        //limpa os labels e listBox, contendo informações da compra
        private void btnEsvaziarLista_Click(object sender, EventArgs e)
        {
            //limpa a lista de compras
            lstSacolaDeItens.Items.Clear();

            //limpa os arrays de controle
            for (int x = 0; x < precoFinalTotal.Length - 1; x++)
            {
                precoDosItensNaLista[x] = 0;
                precoFinalTotal[x] = 0;
                quantidadeDeItensNaLista[x] = 0;

                if (precoDosItensNaLista[x] > 0 && precoFinalTotal[x] > 0 && quantidadeDeItensNaLista[x] > 0)
                    break;
            }

            //reseta os labels
            lblPrecoFinal.Text = "00,00";
            lblQuantidadeDeItens.Text = "0";

            //reseta os textBox's
            txtNomeDoItem.Text = "";
            txtPrecoDoItem.Text = "";
            txtQuantidadeDoItem.Value = 1;

            //desativa os textBox's
            txtPrecoDoItem.Enabled = false;
            txtQuantidadeDoItem.Enabled = false;

            //desativa os botões
            btnEsvaziarLista.Enabled = false;
            btnFinalizarLista.Enabled = false;
            

            btnVoltar.Enabled = true;
        }

        private void btnColocarNaLista_Click(object sender, EventArgs e)
        {
            if (txtPrecoDoItem.Text.Equals(""))
            {
                MessageBox.Show("Não Foi Informado o Preço do Produto, Informe-o Por Favor!", "ATENÇÃO - Campo Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnVoltar.Enabled = false;

                //modifica o preço para que possa ser lido
                string precoDosItensNalistaFormatado = txtPrecoDoItem.Text;
                precoDosItensNalistaFormatado.Replace(",", ".");

                //atribui os valores nos textBox's aos arrays de controle
                quantidadeDeItensNaLista[controleDeIndice[0]] = txtQuantidadeDoItem.Value;
                txtQuantidadeDoItem.Value = 1;
                precoDosItensNaLista[controleDeIndice[0]] = Convert.ToDecimal(precoDosItensNalistaFormatado);
                txtPrecoDoItem.Text = "";

                //pega o preço e quantidade de produtos de um item
                decimal preco = precoDosItensNaLista[controleDeIndice[0]];
                decimal quantidade = quantidadeDeItensNaLista[controleDeIndice[0]];

                //atribui preço final para o array de controle
                precoFinalTotal[controleDeIndice[0]] = preco * quantidade;

                btnEsvaziarLista.Enabled = true;
                btnFinalizarLista.Enabled = true;

                decimal precoFinalDosItensNaLista = 0;
                decimal quantidadeDosItensNaLista = 0;

                //junta todos os valores nas variáveis para poder mostrá-las
                for (int x = 0; x <= precoFinalTotal.Length - 1; x++)
                {
                    precoFinalDosItensNaLista += precoFinalTotal[x];
                    quantidadeDosItensNaLista += quantidadeDeItensNaLista[x];
                }

                //formata o preço para formato padrão da moeda BRL
                String precoDosItensFormatado = String.Format("{0:###,##0.00}", precoFinalDosItensNaLista);

                //adiciona o preço formatado no label
                lblPrecoFinal.Text = precoDosItensFormatado;

                //adiciona a quantidade de itens no label
                lblQuantidadeDeItens.Text = Convert.ToString(quantidadeDosItensNaLista);

                //adiciona o item na lista
                lstSacolaDeItens.Items.Add(txtNomeDoItem.Text);

                //limpa o textBox do nome do produto
                txtNomeDoItem.Text = "";

                controleDeIndice[0] += 1;
            }
        }

        private void txtNomeDoItem_TextChanged(object sender, EventArgs e)
        {
            //desbloquia o acesso para atrinuir preço e quantidade para produto
            if (txtNomeDoItem.Text != "")
            {
                txtQuantidadeDoItem.Enabled = true;
                txtPrecoDoItem.Enabled = true;
                btnColocarNaLista.Enabled = true;
            }
            else
            {
                txtQuantidadeDoItem.Enabled = false;
                txtPrecoDoItem.Enabled = false;
                btnColocarNaLista.Enabled = false;
            }
        }

        private void txtPrecoDoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            //confirma se o que for digitado no textBox de peço, seja permitido apenas números e ,
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.Handled)
                MessageBox.Show("Digite Um Preço Válido, Por Favor", "ATENÇÃO - Campo Preenchido De Maneira Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
