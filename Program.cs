using System;
using System.Collections.Generic;
using Registra_produtos.classes;

namespace Registra_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criamos a lista
            List<Produto> produtos = new List<Produto>();

            // Adicionamos produtos através de instâncias com construtores
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.87f));
            produtos.Add(new Produto(4, "Samsung", 2522.87f));
            produtos.Add(new Produto(5, "Motorola G8", 2522.87f));

            // Ou através de instâncias básicas e suas atribuições
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone XII";
            iphone.Preco = 8952.45f;

            produtos.Add(iphone);
            
            // Podemos mostrar os produtos com foreach
            foreach (Produto p in produtos){
                Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
            }

            // Podemos remover itens através de seu índice de array:
            // Linha removida na posição 3 do array: Produto(4, "Samsung", 2522.87f);
            produtos.RemoveAt(3);
            
            // Também podemos remover um produto da lista usando expressão lambda e o método removeAll:
            // Linha removida: Produto(1, "Apple Watch", 3522.56f)
            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            Console.WriteLine("\nLista alterada: ");
            // Checamos se foi realmente removido
            foreach (Produto p in produtos){
                Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
            }

            List<Cartao> cartoes = new List<Cartao>();

            Console.WriteLine("\nCartões: ");

            cartoes.Add(new Cartao("Alan", 5261400319746371, "Mastercard", DateTime.Now.AddDays(10), 641));
            cartoes.Add(new Cartao("Julia", 4929145634524261, "VISA", DateTime.Now.AddDays(12), 473));
            cartoes.Add(new Cartao("Jorge", 371266379815580, "AMEX", DateTime.Now.AddDays(15), 1902));
            cartoes.Add(new Cartao("Ana", 214926329503047, "Enroute", DateTime.Now.AddDays(12), 650));
            cartoes.Add(new Cartao("Beatriz", 869914287792073, "Voyager", DateTime.Now.AddDays(10), 178));

            foreach (Cartao c in cartoes){
                Console.WriteLine($"Titular: {c.Titular} - Número: {c.Numero} - Bandeira: {c.Bandeira} - Vencimento: {c.Vencimento} - CVV: {c.Cvv}");
            }
        }
    }
}
