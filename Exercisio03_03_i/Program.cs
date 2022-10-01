namespace Exercisio03_03_i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Conta, calculo, num;
            num = 0;
            calculo = 1;
            Console.Write("Digitar primeiro número: ");
            num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Número inválido");
            }
            else if ((num == 0 || num == 1))
            {
                Console.WriteLine("Fatorial igual", num);
            }
            else
            {
                for (Conta = num; Conta >= 1; Conta--)
                {
                    calculo *= Conta;
                }
                Console.WriteLine("fatorial: " + calculo);

            }
        }
    }
}