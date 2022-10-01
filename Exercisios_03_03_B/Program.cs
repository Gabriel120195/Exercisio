using System.Xml.Linq;

namespace Exercisios_03_03_B
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
            Console.Write("Quarta nota: ");
            float nota_4 = float.Parse(Console.ReadLine());


            float media = (nota_1 + nota_2 + nota_3 + nota_4) / 4;


            if (media >= 7)
            {
                Console.WriteLine("APROVADO !");
                Console.WriteLine("A média do aluno = " + media.ToString("f1"));

            }
            Console.WriteLine("Nota exame: ");
            float re = float.Parse(Console.ReadLine());
            float exame = (media + re) / 2;

             if (exame >= 5)
            {
                Console.WriteLine("Aprovado no Exame! ");
                Console.WriteLine("A média do aluno = " + media.ToString("f1"));

            }
            else
            {
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("A média do aluno = " + media.ToString("f1"));

            }
        }
    }
}