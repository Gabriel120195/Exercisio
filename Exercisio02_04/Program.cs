namespace Exercisio02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int vNormal, vExtra, imposto, hNormal, hExtra, desconto;

            Console.Write("Nome do funcionário: ");
            nome = Console.ReadLine();
            

            Console.Write("Horas Trabalhadas: ");
            hNormal = int.Parse(Console.ReadLine());

            Console.Write("Horas EXTRAS Trabalhadas: ");
            hExtra = int.Parse(Console.ReadLine());

             vNormal = (int)(hNormal * 10.00f);
             vExtra =  (int)(hExtra * 15.00f);
            imposto = (vNormal + vExtra) * 10 / 100;
            desconto = (vNormal + vExtra) - imposto;

            Console.WriteLine("Salário bruto: R$ " + (vNormal + vExtra).ToString("f2"));
            Console.WriteLine("Salário líquido: R$ " + desconto.ToString("f2"));

        }
    }
}