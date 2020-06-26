using System;
using System.Collections.Generic;

namespace Aula26Interface
{
    public class Carrinho : ICarrinho
    {
        List<Produto> carrinho = new List<Produto>();
        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Alterar(int _cod, Produto _produtoAlterado)
        {
            carrinho.Find(x => x.Codigo == _cod).Nome = _produtoAlterado.Nome;
            carrinho.Find(x => x.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }

        public void Deletar(Produto produto)
        {
           carrinho.Remove(produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"{item.Nome} - {item.Preco}");
            }
        }

        //Atribuir propriedade
        public float ValorTotal{ get; set; }
        public void MostrarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine($"Valor Total da compra R$: {ValorTotal}");
            Console.ResetColor();
        }
    }
}