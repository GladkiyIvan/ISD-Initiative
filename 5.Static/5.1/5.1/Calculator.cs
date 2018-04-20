using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    class Calculator
    {
        static public double Add(double a, double b)
        {
            return a + b;
        }
        static public double Derogation(double a, double b)
        {
            return a - b;
        }
        static public double Multiplication(double a, double b)
        {
            return a * b;
        }
        static public double Division(double a, double b)
        {

            if (double.IsInfinity(a / b)) { Console.WriteLine("Infinity"); return double.PositiveInfinity ; }
            else return a/b ;
            
        }
        static public double Power(double a, double power)
        {
            return Math.Pow(a, power) ;
        }
    }
}
