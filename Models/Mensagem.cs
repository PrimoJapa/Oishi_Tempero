using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;

namespace PI_SITE.Models
{
    public class Mensagem
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Assunto {get; set;}
        public string Message {get; set;}
        
    }
}