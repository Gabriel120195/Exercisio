using System.ComponentModel;
using System.Reflection.Emit;

namespace Exercisio03_03_G_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;
            Console.WriteLine("Digite o número que deseja saber a tabuada.");

            numero = int.Parse(Console.ReadLine());



            if (numero < 0 || numero > 10) // o comando if verifica se o número digitado está entre 0 e 10 o pipe que são as || siginifica ou

            {
                
                Console.WriteLine("Número inválido por favor digite um número de 0 a 10"); //caso a condição seja verdadeira ele exibirá está mensagem

            }

            else//o comando else só será executado caso a verificação feita no if seja falsa

            {

                while (contador < 11) // o comando while manda o programa repetir o código entre as chaves até que a condição aqui mostrada seja falsa

                {

                    Console.WriteLine(numero + " x " +contador + " = " +numero * contador);//veja que aqui concatenamos variaveis com texto puro

                    contador = contador + 1;//incremento do contador

                }

            }
        }
    }
}