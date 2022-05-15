using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;

namespace PI_SITE.Models
{
    public class Usuario
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public double Contato {get; set;}
        public string Email {get; set;}

/*---------------------Login---------------------------*/
        public string Login {get; set;}
        public string Senha {get; set;}
        public string Conta {get; set;}
        
    }

}