using System.Security.Cryptography;

namespace Exercisio02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_macas;
            float mais_duzia, menos_duzia;

            Console.Write("Quantidade de maças: ");
            num_macas = int.Parse(Console.ReadLine());

            mais_duzia = num_macas * 1.00f;
            menos_duzia = num_macas * 1.30f;

            if (num_macas <= 11) 
            {
                Console.WriteLine("Preço: R$ " + menos_duzia.ToString("f2"));
            }

            else
            {
                Console.WriteLine("Preço: R$ " + mais_duzia.ToString("f2"));
            }

        }
    }
}