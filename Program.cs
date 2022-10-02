using System.Collections.Specialized;

namespace Exercisio04_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Alunos = new Dictionary<int, string>()
            {
                                  {1,"Laura"},
                                  {2, "Sandra"},
                                  {3, "Nildécio"},
                                  {4, "Felipe"},
                                  {5,"Neusa"},
                                  {6,"Julia"},
                                  {7, "Bruno"},
                                  {8, "Mario"},
                                  {9, "Cassio"},
                                  {10,"Paulo"},
                                  {11, "Fabricio"},
                                  {12, "Roger"},
                                  {13, "Yuri"},
                                  {14,"Victor"},
                                  {15, "Bruna"},
                                  {16, "Debora"},
                                  {17, "Ana"},
                                  {18,"Geovana"},
                                  {19,"Theo"},
                                  {20,"Gael" }
            };
            Console.WriteLine("Aluno Número 07: " + Alunos[7]);   
            Console.ReadKey();
        }
    }
}