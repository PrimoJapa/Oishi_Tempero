using PI_SITE.Models;
using Microsoft.AspNetCore.Http;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PI_SITE.Controllers
{
    public class MensagemController : Controller
    {

        private readonly ILogger<MensagemController> _logger;

        public MensagemController(ILogger<MensagemController> logger)
        {
            _logger = logger;
        }

        public IActionResult ListarMensagem()
        {
            MensagemBanco mensagemBanco = new MensagemBanco();
            List<Mensagem> Lista =mensagemBanco.ListarDados();
            return View(Lista);
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
       public IActionResult Contato(Mensagem mensagem)
        {
            
            MensagemBanco mensagemBanco = new MensagemBanco();
            mensagemBanco.AddMensagem(mensagem);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
             return RedirectToAction("Index", "Home");          
        }


        public IActionResult EditarMensagem(int Id)
        {
            MensagemBanco mensagemBanco = new MensagemBanco();
            Mensagem mensagem = mensagemBanco.BuscarMensagem(Id);
            return View(mensagem);
        }

        [HttpPost]
        public IActionResult EditarMensagem(Mensagem mensagem)
        {
            MensagemBanco mensagemBanco = new MensagemBanco();
            mensagemBanco.EditarMensagem(mensagem);
            ViewBag.Mensagem = "Usuario atualizado com sucesso!";
            return RedirectToAction("ListarMensagem");
        }

        public IActionResult DeletarMensagem(int Id)
        {
            MensagemBanco mensagemBanco = new MensagemBanco();
            mensagemBanco.DeletarMensagem(Id);
            return RedirectToAction("ListarMensagem");           
        }

    }
}
