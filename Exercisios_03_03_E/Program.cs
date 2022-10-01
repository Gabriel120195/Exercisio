namespace Exercisios_03_03_E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digitar sua nota: ");
            float Notas = float.Parse(Console.ReadLine());
            switch (Notas)
            {
                case (<= 1.9f):
                    Console.WriteLine("Sua nota: E");
                    break;
                case (<= 4.9f):
                    Console.WriteLine("Sua nota: D");
                    break;
                case (<= 6.9f):
                    Console.WriteLine("Sua nota: C");
                    break;
                case (<= 8.9f):
                    Console.WriteLine("Sua nota: B");
                    break;
                default:
                    Console.WriteLine("Sua nota: A");
                    break;
            }
        }
    }
}