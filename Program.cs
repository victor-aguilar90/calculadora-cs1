using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        public class Calculadora
        {
            public double Soma( double num1, double num2) 
            { 
                return num1 + num2; 
            }

            public double Subtracao( double num1, double num2) 
            { 
                return num1 - num2; 
            }

            public double Multiplicacao( double num1, double num2)
            {
                return num1 * num2;
            }

            public double Divide( double num1, double num2) 
            {  
                if (num2 == 0) {
                    Console.WriteLine("Erro!");
                    return double.NaN;
                
                } else
                {
                    return num1 / num2;
                }
     
            }
        }
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Escolha uma operação: \n 1 - adição \n 2 - Subtração \n 3 - Multiplicação \n 4 - Divisão");
            int operacao = int.Parse(Console.ReadLine());

            while (operacao > 4 || operacao == 0) {
                Console.WriteLine("Escolha uma operação válida!");
                operacao = int.Parse(Console.ReadLine());
            }



            Console.WriteLine("Digite um número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            double numero2 = double.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine("O resultado da soma é igual à {0}", calculadora.Soma(numero1, numero2));

                break;

                case 2:
                    Console.WriteLine("O resultado da subtração é igual à {0}", calculadora.Subtracao(numero1, numero2));
                    
                break;

                case 3:
                    Console.WriteLine("O resultado da multiplicação é igual à {0}", calculadora.Multiplicacao(numero1, numero2));
                
                break;

                case 4:
                    Console.WriteLine("O resultado da divisão é igual à {0}", calculadora.Divide(numero1, numero2));

                break;

            }

            

            
            
        }
    }
}
