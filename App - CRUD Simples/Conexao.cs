using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace App___CRUD_Simples
{
    class Conexao
    {
        //instância do objeto de conexão com o banco de dados
        MySqlConnection conexao = new MySqlConnection("server=localhost;port = 3306;user Id=root; database = app_crud_simples; password =");

        //método utilizado para cadastrar um novo usuário no banco de dados
        public String cadastrarUsuario(String nome, String email, String senha)
        {
            try
            {
                //abre conexão para o banco
                conexao.Open();

                //string que guarda o comando Sql
                string query = "insert into contaDoUsuario values ('" + nome + "', '" + email + "', SHA1('" + senha + "'), 0, 0)";
                MySqlCommand comando = new(query, conexao);

                //executa a query contendo o comando Sql
                comando.ExecuteNonQuery();

                //fecha conexão com o banco de dados
                conexao.Close();

                return "Usuário Cadastrado Com Sucesso!";
            }
            catch (Exception)
            {
                throw;
            }
        }

        //método utilizado para mudar a senha do usuário no banco de dados
        public String mudarSenha(String email, String senha)
        {
            try
            {
                //abre conexão para o banco
                conexao.Open();

                //string que guarda o comando Sql
                string query = "update contaDoUsuario set senha = SHA1('" + senha + "') where email = '" + email + "'";
                MySqlCommand comando = new(query, conexao);

                //executa a query contendo o comando Sql
                comando.ExecuteNonQuery();

                //fecha conexão com o banco de dados
                conexao.Close();

                return "Senha Alterada Com Sucesso!";
            }
            catch (Exception)
            {
                throw;
            }
        }

        //método utilizado para fazer login no sistem
        public bool loginUsuario(String email, String senha)
        {
            try
            {
                //abre conexão para o banco
                conexao.Open();

                //string que guarda o comando Sql
                string query = "select count(*) from contaDoUsuario where email = '" + email + "' && senha = SHA1('" + senha + "')";
                MySqlCommand comando = new(query, conexao);

                //executa a query contendo o comando Sql
                int confirmarUsuario = Convert.ToInt32(comando.ExecuteScalar());

                if (!String.IsNullOrWhiteSpace(email) && !String.IsNullOrWhiteSpace(senha) && confirmarUsuario == 1)
                {
                    //fecha conexão com o banco de dados
                    conexao.Close();
                    return true;
                }
                else
                {
                    //fecha conexão com o banco de dados
                    conexao.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //método utilizado para conseguir informações do usuário no banco de dados
        public MySqlDataReader informacoesDoUsuario(String email)
        {
            try
            {
                //abre conexão para o banco
                conexao.Open();

                //string que guarda o comando Sql
                string query = "select nome, email, saldo, comprasRealizadas from contaDoUsuario where email = '" + email + "'";
                MySqlCommand comando = new MySqlCommand(query, conexao);

                //executa a query contendo o comando Sql
                MySqlDataReader leitor = comando.ExecuteReader();

                leitor.Read();
                return leitor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //método utilizado para deletar um usuário no banco de dados
        public String deletarUsuario(String email)
        {
            try
            {
                //abre conexão para o banco
                conexao.Open();

                //string que guarda o comando Sql
                string query = "delete from contaDoUsuario where email = '" + email + "'";
                MySqlCommand comando = new(query, conexao);

                //executa a query contendo o comando Sql
                comando.ExecuteNonQuery();

                //fecha conexão com o banco de dados
                conexao.Close();

                return "Conta Deletada Com Sucesso!";
            }
            catch (Exception)
            {
                throw;
            }
        }

        //método utilizado para cadastrar uma compra do usuário no banco de dados
        public String fazerCompra(String email, decimal valorDaLista)
        {
            try
            {
                //abre conexão com o banco
                conexao.Open();

                //string que guarda o comando Sql
                string query = "update contaDoUsuario set comprasRealizadas = comprasRealizadas + 1, saldo = saldo + '" + valorDaLista.ToString().Replace(',', '.') + "' where email = '" + email + "'";
                MySqlCommand comando = new(query, conexao);

                //excuta o comando Sql
                comando.ExecuteNonQuery();

                //fecha a conexão com o banco de dados
                conexao.Close();

                return "Compra Realizada Com Sucesso!";
            }
            catch (Exception)
            {
                throw;
            }
        }

        //método utilizado para quitar divida do usuário no banco de dados
        public String quitarSaldo(String email)
        {
            try
            {
                //string que guarda o comando Sql
                string query = "update contaDoUsuario set saldo = 0 where email = '" + email + "'";
                MySqlCommand comando = new(query, conexao);

                //executa a query contendo o comando Sql
                comando.ExecuteNonQuery();

                //fecha conexão com o banco de dados
                conexao.Close();

                return "Saldo Quitado Com Sucesso!";
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
