using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Exercisio05_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            while(true)
            {
                try
                {
                    Console.WriteLine("Digite um numero");
                    numero = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("Fim do loop");
            Console.ReadKey();
            }
        }
    }




