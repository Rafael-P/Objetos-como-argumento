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
                    case 1: //switch case dentro de um switch case
                        
                        Console.WriteLine("Digite o código do produto que você quer adicionar:");
                        Console.WriteLine("[1] - Mouse Gamer");
                        Console.WriteLine("[2] - MousePad");
                        Console.WriteLine("[3] - Teclado Mecanico");
                        Console.WriteLine("[4] - Cabo USB");
                        int resposta = int.Parse(Console.ReadLine());
                        switch (resposta)
                        {
                            case 1:
                                carrinho.AdicionarProduto(p1);
                                break;

                            case 2:
                                carrinho.AdicionarProduto(p2);
                                break;

                            case 3:
                                carrinho.AdicionarProduto(p3);
                                break;

                            case 4:
                                carrinho.AdicionarProduto(p4);
                                break;

                            default:
                                Console.WriteLine("Resposta inválida");
                                break;
                        }
                        break; //case 1


                    case 2:
                        carrinho.MostrarProdutos();
                        break;


                    case 3:
                        Console.WriteLine("Qual produto deseja remover: 1 - 2 - 3 - 4");
                        int remover = int.Parse(Console.ReadLine());
                        switch (remover)
                        {
                            case 1:
                                carrinho.RemoveProduto(p1);    
                                break;

                            case 2:
                                carrinho.RemoveProduto(p2);
                                break;

                            case 3:
                                carrinho.RemoveProduto(p3);
                                break;

                            case 4:
                                carrinho.RemoveProduto(p4);
                                break;    

                            default:
                                Console.WriteLine("Remoção inválida");
                                break;
                        }
                        break; //case 3

                    case 4:
                        carrinho.TotalCompra();
                        break;


                    case 5:
                        //carrinho.AterarItem(p1.Codigo , p4);
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
