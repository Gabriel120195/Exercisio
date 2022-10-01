namespace Exercisios_Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B: " + b);

        }
    }
}