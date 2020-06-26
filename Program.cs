using System;

namespace Aula26Interface
{
    class Program
    {
        static void Main(string[] args)
        {
             Carrinho cart = new Carrinho();

            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("|------------------|");
            System.Console.WriteLine("|------------------|");
            System.Console.WriteLine("|-----CARRINHO-----|");
            System.Console.WriteLine("|------------------|");
            System.Console.WriteLine("|------------------|");
            Console.ResetColor();

            Produto p1 = new Produto(1,"Dracúla, Bram Stoker", 80f);
            Produto p2 = new Produto(2, "Admirável Mundo Novo",45.50f);
            Produto p3 = new Produto(3, "1984", 89.99f);
            Produto p4 = new Produto(4, "O Retrato de Doran Gray", 75.50f);
            Produto p5 = new Produto(5, "Fahrenheit 451", 32.10f);
            Produto p6 = new Produto(6, "Sherlock Holmes", 130.50f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);
            cart.Adicionar(p5);
            cart.Adicionar(p6);

            cart.Deletar(p3);

            Produto prodAlterado = new Produto(1, "Cyberpunk 2077", 200f);
            cart.Alterar(2, prodAlterado);

            cart.Ler();
            cart.MostrarTotal();
        }
    }
}
