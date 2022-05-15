using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PI_SITE.Models;
using MySqlConnector;
using Microsoft.AspNetCore.Http;

namespace PI_SITE.Controllers
{
    public class HomeController : Controller
    {   
    
        //Método para visualizar os Produto cadastrados na lista.     
        public IActionResult Index()
        {
            ProdutoBanco produtoBanco = new ProdutoBanco();
            List<Produto> Lista = produtoBanco.ListarDados();
            return View(Lista);
        }

        public IActionResult OndeEncontrar()
        {
            return View();
        }

        public IActionResult Receitas()
        {
            return View();
        }

    }
}
