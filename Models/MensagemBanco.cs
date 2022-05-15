using System;
using System.Collections.Generic;
using MySqlConnector;

namespace PI_SITE.Models
{
    public class MensagemBanco
    {
        private const string DadosConexao = "Database=oishi_bd; Data Source=localhost; User Id=root;";

        public List<Mensagem> ListarDados()
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Mensagem";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Mensagem> Lista = new List<Mensagem>();

            while (Reader.Read())
            {
                Mensagem MensagemEncontrado = new Mensagem();
                MensagemEncontrado.Id = Reader.GetInt32("Id");
                
                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    MensagemEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Email")))                    
                   MensagemEncontrado.Email =  Reader.GetString("Email");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Assunto")))                    
                   MensagemEncontrado.Assunto = Reader.GetString("Assunto");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Message")))                    
                    MensagemEncontrado.Message = Reader.GetString("Message");    

                Lista.Add(MensagemEncontrado);
            }
            Conexao.Close();
            return Lista;            
        }

        public void AddMensagem(Mensagem mensagem)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "INSERT INTO Mensagem (Nome, Email, Assunto, Message) VALUES (@Nome, @Email, @Assunto, @Message)";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Nome", mensagem.Nome);
            Comando.Parameters.AddWithValue("@Email", mensagem.Email);
            Comando.Parameters.AddWithValue("@Assunto", mensagem.Assunto);
            Comando.Parameters.AddWithValue("@Message", mensagem.Message);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }

        public void EditarMensagem(Mensagem mensagem)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "UPDATE Mensagem SET Nome=@Nome, Email=@Email, Assunto=@Assunto, Message=@Message WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Nome", mensagem.Nome);
            Comando.Parameters.AddWithValue("@Email", mensagem.Email);
            Comando.Parameters.AddWithValue("@Assunto", mensagem.Assunto);
            Comando.Parameters.AddWithValue("@Message", mensagem.Message);
            Comando.Parameters.AddWithValue("@Id", mensagem.Id);
            Comando.ExecuteNonQuery();
            Conexao.Close();            
        }

        public void DeletarMensagem(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "DELETE FROM Mensagem WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            Comando.ExecuteNonQuery();
            Conexao.Close();  
        }

        public Mensagem BuscarMensagem(int Id)
        {
            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            string Query = "SELECT * FROM Mensagem WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);
            Comando.Parameters.AddWithValue("@Id", Id);
            MySqlDataReader Reader = Comando.ExecuteReader();

            Mensagem MensagemEncontrado = new Mensagem();

            if(Reader.Read())
            {
               MensagemEncontrado.Id = Reader.GetInt32("Id");
                
                 if(!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    MensagemEncontrado.Nome = Reader.GetString("Nome");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Email")))                    
                   MensagemEncontrado.Email =  Reader.GetString("Email");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Assunto")))                    
                   MensagemEncontrado.Assunto = Reader.GetString("Assunto");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Message")))                    
                    MensagemEncontrado.Message = Reader.GetString("Message");      
            }
            Conexao.Close();
            return MensagemEncontrado;            
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