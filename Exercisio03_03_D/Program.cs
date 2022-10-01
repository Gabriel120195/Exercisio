namespace Exercisio03_03_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digitar primeiro número: ");
            int Na = int.Parse(Console.ReadLine());
            Console.Write("Digitar segundo número: ");
            int Nb = int.Parse(Console.ReadLine());
            Console.Write("Digitar terceiro número: ");
            int Nc = int.Parse(Console.ReadLine());


            if (Na > Nb)
            {
                if (Nb > Nc) Console.WriteLine($"Ordem crescente:  {Nc},{Nb},{Na}");
                else if (Na > Nc) Console.WriteLine($"Ordem crescente:  {Nb},{Nc},{Na}");
                else Console.WriteLine($"Ordem crescente:  {Nb},{Na},{Nc}");
            }
            else if (Nb > Nc)
            {
                if (Na > Nc) Console.WriteLine($"Ordem crescente:  {Nc},{Na},{Nb}");
                else Console.WriteLine($"Ordem crescente:  {Na},{Nc},{Nb}");
            }
            else Console.WriteLine($"Ordem crescente:  {Na},{Nb},{Nc}");
        }
    }
}