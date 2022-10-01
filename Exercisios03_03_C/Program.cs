namespace Exercisios03_03_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int resultado_maior = Maior(n1, n2, n3);
            int resultado_menor = Menor(n1, n2, n3);
            Console.WriteLine("Maior = " + resultado_maior);
            Console.WriteLine("Menor = " + resultado_menor);

        }
        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
            static int Menor(int a, int b, int c)
            {

                int m;
                if (a < b && a < c)
                {
                    m = a;
                }
                else if (b < c)
                {
                    m = b;
                }
                else
                {
                    m = c;
                }
                return m;
            }
        }
    }

