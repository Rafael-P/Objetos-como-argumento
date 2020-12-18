using System;
using System.Collections.Generic;

namespace Objetos_como_argumentos.classes
{
    public class Carrinho
    {
        //criamos uma propriedade para guardar o valor total do carrinho
        public float ValorTotal { get; set; } //"atributo"


        //criamos uma lista que guardara os itens do carrinho 
        List<Produto> carrinho = new List<Produto>();


        //criamos um metodo que adiciona um produto ao carrinho, passando td objeto como argumento
        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }


        //criamos um metodo que remove um produto do carrinho 
        public void RemoveProduto(Produto produto){
            carrinho.Remove(produto);
        }


        //criamos um metodo para listar os produtos do carrinho 
        public void MostrarProdutos(){
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($" {p.Nome} - R$ {p.Preco.ToString("n2")} ");
                    Console.ResetColor();
                }
            }else{
              Console.WriteLine("O carrinho está vazio");  
            }
        }


        //criamos um metodo para calcular o total da compra
        public void TotalCompra(){
            Console.ForegroundColor = ConsoleColor.Red;

            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"Total do carrinho R$ {ValorTotal.ToString("n2")} ");
            }else{
                Console.WriteLine($"Seu carrinho está vazio");
            }
            Console.ResetColor();
        }


        //podemos alterar um produto
        public void AterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }


    }
}