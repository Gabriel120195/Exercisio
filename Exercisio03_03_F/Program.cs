using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Exercisio03_03_F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual seu PESO? ");
            int peso = int.Parse(Console.ReadLine());
            Console.Write("Qual sua ALTURA? ");
            float altura = float.Parse(Console.ReadLine());
            float imc = peso / (altura * altura);

            if (imc <= 18.5f)
            {
                Console.WriteLine("Abaixo do peso normal");
            }
            else if (imc <= 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc <= 30)
            { 
                Console.WriteLine("Peso acima do normal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}