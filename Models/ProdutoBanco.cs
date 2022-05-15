using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;

namespace PI_SITE.Models
{
    public class ProdutoBanco
    {
        private const string DadosConexao = "Database=oishi_bd; Data Source=localhost; User Id=root;";

        /*CADASTRO DE PRODUTO*/
        public void AddProduto(Produto produto)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "INSERT INTO Produto (Nome, Peso, Valor, Quantidade) VALUES (@Nome, @Peso, @Valor, @Quantidade)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Nome", produto.Nome);
            Comando.Parameters.AddWithValue("@Peso", produto.Peso);
            Comando.Parameters.AddWithValue("@Valor", produto.Valor);
            Comando.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        /*LISTAGEM DE PRODUTO*/
        public List<Produto> ListarDados()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Produto";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Produto> Lista = new List<Produto>();

            while (Reader.Read())
            {
                Produto ProdutoEncontrado = new Produto();
                ProdutoEncontrado.Id = Reader.GetInt32("Id");
                
                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    ProdutoEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Peso")))                    
                   ProdutoEncontrado.Peso =  Reader.GetInt32("Peso");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Valor")))                    
                   ProdutoEncontrado.Valor = Reader.GetInt32("Valor");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Quantidade")))                    
                    ProdutoEncontrado.Quantidade = Reader.GetInt32("Quantidade");    

                Lista.Add(ProdutoEncontrado);
            }
            Conexao.Close();
            return Lista;            
        }
        
        
        /*EDITAR DADOS DO PRODUTO*/
        public void EditarProduto(Produto produto)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "UPDATE Produto SET Nome=@Nome, Peso=@Peso, Valor=@Valor, Quantidade=@Quantidade WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Nome", produto.Nome);
            Comando.Parameters.AddWithValue("@Peso", produto.Peso);
            Comando.Parameters.AddWithValue("@Valor", produto.Valor);
            Comando.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            Comando.Parameters.AddWithValue("@Id", produto.Id);
            Comando.ExecuteNonQuery();
            Conexao.Close();            
        }

        /*EXCLUSÃO DO PRODUTO*/
        public void RemoverProduto(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "DELETE FROM Produto WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Conexao.Close();  
        }

        /*BUSCAR PRODUTO*/

        public Produto BuscarProduto(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Produto WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();

            Produto ProdutoEncontrado = new Produto();

            if(Reader.Read())
            {
               ProdutoEncontrado.Id = Reader.GetInt32("Id");
                
                 if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    ProdutoEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Peso")))                    
                   ProdutoEncontrado.Peso =  Reader.GetInt32("Peso");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Valor")))                    
                   ProdutoEncontrado.Valor = Reader.GetInt32("Valor");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Quantidade")))                    
                    ProdutoEncontrado.Quantidade = Reader.GetInt32("Quantidade");       
            }
            Conexao.Close();
            return ProdutoEncontrado;            
        }

        

        public void TestarConexao()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando!");
            Conexao.Close();
        }
    }
}