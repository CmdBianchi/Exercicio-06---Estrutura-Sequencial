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
            Console.WriteLine("Área do Triângulo: " + EquationTriangulo(a, b, c));
            ;
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Calcule e mostre a área das figuras geométricas.");
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationTriangulo(double a, double b, double c){
            double area;
            area = (a * b) / 2;
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationRetangulo(double a, double b, double c){
            double area;
            area = (a * b) / 2;
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationCirculo(double a, double b, double c){
            double area;
            area = (a * b) / 2;
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationTrapezio(double a, double b, double c){
            double area;
            area = (a * b) / 2;
            return area;
        }
        /*------------------------------------------------------------------------------------------*/
        static double EquationQuadrado(double a, double b, double c){
            double area;
            area = (a * b) / 2;
            return area;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END


    }
}