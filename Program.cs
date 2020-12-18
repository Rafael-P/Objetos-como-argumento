using System;
using Objetos_como_argumentos.classes;

namespace Objetos_como_argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho carrinho = new Carrinho();

            Produto p1 = new Produto(1, "Mouse Gamer", 200f);
            Produto p2 = new Produto(2, "MousePad", 40f);
            Produto p3 = new Produto(3, "Teclado Mecanico", 400f);
            Produto p4 = new Produto(4, "Cabo USB", 10f);
            
            int opcao;

            do
            {
                Console.WriteLine("Seja bem vindo ao nosso sistema!");
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("[1] - Cadastrar um Produto");
                Console.WriteLine("[2] - Mostrar os Produto");
                Console.WriteLine("[3] - Remover um Produto");
                Console.WriteLine("[4] - Ver Total da Compra");
                Console.WriteLine("[5] - Alterar um produto");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        //do
                        //{
                            
                        //} while (true);
                        
                        
                        //carrinho.AdicionarProduto();
                        break;


                    case 2:
                        carrinho.MostrarProdutos();
                        break;


                    case 3:
                        //carrinho.RemoveProduto();
                        break;

                    case 4:
                        carrinho.TotalCompra();
                        break;


                    case 5:
                        //carrinho.AterarItem();
                        break;

                    case 0:
                        //sair
                        Console.WriteLine("Agradecemos pela sua preferencia!");
                        break;


                    default:
                        Console.WriteLine("Opção inválida");
                        break;}
                
            } while (opcao != 0);

    

        }//main
    }
}
