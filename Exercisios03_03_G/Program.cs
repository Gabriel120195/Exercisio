namespace Exercisios03_03_G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recebe como Variáveis
            int formula, contador, numero;


            Console.Write("Digite o Número para Obter a Taboada : ");
            numero = int.Parse(Console.ReadLine());

            //pára
            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);

            }

            Console.ReadKey();
        }

    }
}