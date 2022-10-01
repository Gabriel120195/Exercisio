using System.Net.Http.Headers;

namespace Exercisio02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float[] notas = { 4, 8, 7 };
            float Media;

            Media =(int) (notas[0] + notas[1] + notas[2]) / 3;

            Console.WriteLine("Média das notas: " + Media);

        }
    }
}