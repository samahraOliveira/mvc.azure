namespace Conceitos.AspNetCoreMVC.Models
{
    public class Informacoes
    {
        // método estático não depende de objeto pra ser executado
        // criando método que vai retornar uma coleção de produtos
        //simulaão de um método se conectar com um banco de dados e trazer uma informação
        public static List<Produto> ListaProdutos()
        {
            return new List<Produto>() {
                new Produto() { Codigo = 100, Descricao = "Bicicleta", Preco = 1000},
                new Produto() { Codigo = 200, Descricao = "Cadeira", Preco = 150 },
                new Produto() { Codigo = 300, Descricao = "Monitor", Preco = 700}

            };
        }
    }
}
