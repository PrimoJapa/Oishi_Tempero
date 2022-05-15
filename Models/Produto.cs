using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;

namespace PI_SITE.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public int Peso {get; set;}
        public double Valor {get; set;}
        public int Quantidade {get; set;}
    }
} 
