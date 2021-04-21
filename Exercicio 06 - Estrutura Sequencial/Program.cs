using System;

namespace Exercício_06____Estrutura_Sequencial
{
    class Program
    {

        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            double a, b, c;
            Msg();
            Console.WriteLine(" ");
            Console.Write("Digite o valor do lado A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado C: ");
            c = double.Parse(Console.ReadLine());
            Equation(10, 5, 4);
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg()
        {
            Console.WriteLine("Calcule e mostre a área das figuras geométricas.");
        }
        /*------------------------------------------------------------------------------------------*/
        static double Equation(double a, double b, double c)
        {
            double area;
            area = a;
            return area;

        }
    }
    }