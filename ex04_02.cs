using System;
using System.ComponentModel;

namespace Exercisio04_02
{
    internal class Program
    {
        static void Main(string[] args )
        {

            List<int> ListaNumeros = new List<int>();
            ListaNumeros.Add(20);
            ListaNumeros.Add(30);
            ListaNumeros.Add(40);
            ListaNumeros.Add(20);
            ListaNumeros.Add(60);
            ListaNumeros.Add(30);
            Console.WriteLine("Conteudo da lista: " + ListaNumeros.Count);
            Console.WriteLine("Dados da lista");
          
            foreach (var n in ListaNumeros)
            {
                Console.Write(n  + "\n");
            }

            HashSet<int> hSet = new HashSet<int>(ListaNumeros);
            Console.WriteLine("Número inteiros " + hSet.Count);
            //Output in Hashset
            Console.WriteLine("Lista sem repetição: ");
            foreach (var n in hSet)
            {
                Console.Write(n + "\t");
            }
            Console.ReadLine();
        }
    }
}
