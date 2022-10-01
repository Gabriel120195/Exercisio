using System.Runtime.Serialization;

namespace Exercisio02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            Console.Write("DIA de nascimento: ");
            dia = int.Parse(Console.ReadLine());
            
            Console.Write("MÊS de nascimento: ");
            mes = int.Parse(Console.ReadLine());

            Console.Write("ANO de nascimento: ");
            ano = int.Parse(Console.ReadLine());

            int anoCal = (2022 - ano) * 365;

            int mesCal = 30 * mes;

            int soma = anoCal + mesCal + dia;

            Console.WriteLine("Dias: " + soma);
        }
    }
}