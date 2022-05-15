using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
using PI_SITE.Models;
using Microsoft.AspNetCore.Mvc;

namespace PI_SITE.Controllers
{
    public class UsuarioController : Controller
    {

         /*CADASTRO DE USUÁRIOS*/
        public IActionResult CadastroUsuario()
        {
            if(HttpContext.Session.GetString("Conta") == "Colaborador")
            return RedirectToAction("Login");

            return View();
        }

        [HttpPost]
        public IActionResult CadastroUsuario(Usuario usuario)
        {
            
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            usuarioBanco.AddUsuario(usuario);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return RedirectToAction("ListarUsuario");          
        }

        /*LISTAGEM DE USUÁRIOS*/ 
        public IActionResult ListarUsuario()
        {
            if(HttpContext.Session.GetInt32("Id") == null)
            return RedirectToAction("Login");

            if(HttpContext.Session.GetString("Conta") == "Colaborador")
            return RedirectToAction("Login");

            if(HttpContext.Session.GetString("Conta") == "Usuario")
            return RedirectToAction("Login");

            UsuarioBanco usuarioBanco = new UsuarioBanco();
            List<Usuario> Lista = usuarioBanco.ListarDados();
            return View(Lista);
        }


        /*EDITAR DADOS DO USUÁRIOS*/  
        public IActionResult EditarCadastro(int Id)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            Usuario usuario = usuarioBanco.BuscarUsuario(Id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult EditarCadastro(Usuario usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            usuarioBanco.EditarCadastro(usuario);
            ViewBag.Mensagem = "Usuario atualizado com sucesso!";
            return RedirectToAction("ListarUsuario");
        }

        /*EXCLUSÃO DE USUÁRIOS*/ 
        public IActionResult DeletarUsuario(int Id)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            usuarioBanco.DeletarUsuario(Id);
            return RedirectToAction("ListarUsuario");           
        }

        
        /********************************LOGIN********************************************/   
         public IActionResult Login()
        {
            return View();
        }

       [HttpPost]
        public IActionResult Login(Usuario usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            Usuario usuarioSessao = usuarioBanco.Login(usuario);

            if(usuarioSessao != null) 
            {
                ViewBag.Mensagem="Você está logado";
                HttpContext.Session.SetInt32("Id", usuarioSessao.Id);
                HttpContext.Session.SetString("Nome", usuarioSessao.Nome);
                HttpContext.Session.SetString("Conta", usuarioSessao.Conta);
                return RedirectToAction("index", "Home");

            } else {
                 ViewBag.Mensagem = "Falha no login!";
                  return View();
            }
        }

         /***************************************Logout*********************************************/

        public IActionResult Logout(){

            HttpContext.Session.Clear();

            return RedirectToAction("index", "Home");

        }

    }
}