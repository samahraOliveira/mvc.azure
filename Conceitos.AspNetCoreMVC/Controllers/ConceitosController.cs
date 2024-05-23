using Conceitos.AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conceitos.AspNetCoreMVC.Controllers
{
    public class ConceitosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Exemplos de Actions:
        //1: Action retornando uma string
        [Route("/MostrarTexto")]
        public string  MostrarTexto()
        {
            return "Texto obtido no Controller Conceitos";
        }

        //2: Action retornando PDF
        public FileResult MostrarPDF()
        {
            return File("~/pdf/Certificações Microsoft.pdf", "application/pdf");

        }

        //3. Action retornando uma View
        public IActionResult MostrarConteudo()
        {
            return View();
           // return RedirectToAction("");
        }

        //4.Action enviando os dados de um produto para a View
        public IActionResult MostrarProduto()
        {
            Produto produto = new Produto()
            {
                Codigo = 10, Descricao = "Caixa de Som", Preco = 200
            };

            return View(produto);
        }

        public IActionResult  MostrarLista()
        {
            var lista = Informacoes.ListaProdutos();
            return View(lista);
        }

    }
}
