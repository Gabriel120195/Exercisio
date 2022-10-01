namespace Exercisio04_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> ListaOrdem = new Queue<string>();
            
            Console.WriteLine("Digite o nome: ");
            string nomes = Console.ReadLine();

            ListaOrdem.Enqueue(nomes ++);

            Console.WriteLine("Ordem: " + ListaOrdem);
                
        }
    }    
}