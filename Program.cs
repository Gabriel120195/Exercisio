namespace Exercisio03_03_J
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int conta = 1;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    conta = conta + 1;
                }
            }

            if (conta == 2)
                Console.WriteLine("O Número {0} é Primo!", numero);
            else
                Console.WriteLine("O Número {0} Não é Primo", numero);
        }
    }
}

