using System.Xml;

namespace Exercisios_03_03_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Primeira nota: ");
            float nota_1 = float.Parse(Console.ReadLine());
            Console.Write("Segunda nota: ");
            float nota_2 = float.Parse(Console.ReadLine());
            Console.Write("Terceira nota: ");
            float nota_3 = float.Parse(Console.ReadLine());

             float media = (nota_1 + nota_2 + nota_3) / 3;
            Console.WriteLine("Média do aluno = " + media.ToString("f1"));

            if (media >= 5)
            {
                Console.WriteLine("APROVADO !");
            }

           else
            {
                Console.WriteLine("REPROVADO !");
            }
        }
    }
}