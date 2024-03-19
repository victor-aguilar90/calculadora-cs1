using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite qual operação deseja fazer +, -, *, ");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            switch (operador)
            {
                case "+":
                    Console.WriteLine("O resultado é igual a {0}", num1 + num2);

                break;

                case "-":
                    Console.WriteLine("O resultado é igual a {0}", num1 - num2);
                break;

                case "*":
                    Console.WriteLine("O resultado é igual a {0}", num1 * num2);
                break;

                case "/":

                    if (num2 == 0)
                    {
                        Console.WriteLine("Não foi possível fazer a operação!");
                    } else
                    {
                        Console.WriteLine("O resultado é igual a {0}", num1 / num2);
                    }

                    break;

            }

           
        }
    }
}
