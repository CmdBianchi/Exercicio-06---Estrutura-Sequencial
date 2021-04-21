using System;

namespace Exercício_06____Estrutura_Sequencial
{
    class Program
    {

        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            double a, b, c;
            Msg();
            Console.WriteLine(" ");
            Console.Write("Digite o valor do lado A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do lado C: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Área do Triângulo: " + EquationTriangulo(a, b, c).ToString("F2"));
            Console.WriteLine(" ");
            Console.Write("Área do Retangulo: " + EquationRetangulo(a, b, c).ToString("F2"));
            Console.WriteLine(" ");
            Console.Write("Área do Circulo: " + EquationCirculo(a, b, c).ToString("F2"));
            Console.WriteLine(" ");
            Console.Write("Área do Trapezio: " + EquationTrapezio(a, b, c).ToString("F2"));
            Console.WriteLine(" ");
            Console.Write("Área do Quadrado: " + EquationQuadrado(a, b, c).ToString("F2"));
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Calcule e mostre a área das figuras geométricas.");
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationTriangulo(double a, double b, double c){
            double area;
            area = (a * c) / 2;
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationRetangulo(double a, double b, double c){
            double area;
            area = (a * b);
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationCirculo(double a, double b, double c){
            double area, pi=3.14159;
            area = pi * 0.5 * (c * c);
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationTrapezio(double a, double b, double c){
            double area;
            area = c*((a + b) / 2);
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationQuadrado(double a, double b, double c){
            double area;
            area = (b * b);
            return area;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END


    }
}