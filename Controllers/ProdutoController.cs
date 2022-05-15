using System.Collections.Generic;
using PI_SITE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using MySqlConnector;


namespace PI_SITE.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult ListarProduto()
        {
            ProdutoBanco produtoBanco = new ProdutoBanco();
            List<Produto> Lista = produtoBanco.ListarDados();
            return View(Lista);
        }

        public IActionResult CadastroProduto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastroProduto(Produto produto)
        {
            
            ProdutoBanco produtoBanco = new ProdutoBanco();
            produtoBanco.AddProduto(produto);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            return RedirectToAction("ListarProduto");          
        }


        public IActionResult EditarProduto(int Id)
        {
            ProdutoBanco produtoBanco = new ProdutoBanco();
            Produto produto = produtoBanco.BuscarProduto(Id);
            return View(produto);
        }

        [HttpPost]
        public IActionResult EditarProduto(Produto produto)
        {
            ProdutoBanco produtoBanco = new ProdutoBanco();
            produtoBanco.EditarProduto(produto);
            ViewBag.Mensagem = "Produto atualizado com sucesso!";
            return RedirectToAction("ListarProduto");
        }

        public IActionResult RemoverProduto(int Id)
        {
            ProdutoBanco produtoBanco = new ProdutoBanco();
            produtoBanco.RemoverProduto(Id);
            return RedirectToAction("ListarProduto");           
        }

    }
}