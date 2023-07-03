using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Канкулятор
{
    public class Calc : InterfaceCalc
    {
        
        private double memory = 0;
        


        public double Multiplication(double c,double b)
        {
            c *= b;
            return c ;
            
        }

        public double Division(double c,double b)
        {
            c /= b;
            return c ;
        }

        public double Sum(double c, double b)
        {
            c += b;
            return c ;
        }

        public double Subtraction(double c, double b) //вычитание
        {
            c -= b;
            return c ;
        }

        public double SqrtX(double c, double b)
        {
            c = Math.Pow(c, 1 / b);
            return c;
        }

        public double DegreeY(double c, double b)
        {
            c = Math.Pow(c, b);
            return c;
        }

        public double Sqrt(double c)
        {
            
            return Math.Sqrt(c);
        }

        public double Square(double c)
        {   
            return Math.Pow(c, 2.0);
        }

        public double Factorial(double c)
        {
            double f = 1;

            for (int i = 1; i <= c; i++)
                f *= (double)i;
            
            return  f;
        }

        //показать содержимое регистра мамяти
        public double MemoryShow()
        {
            return memory;
        }

        //стереть содержимое регистра мамяти
        public void Memory_Clear()
        {
            memory = 0.0;
        }

        //* / + - к регистру памяти
        public void M_Multiplication(double b)
        {
            memory *= b;
        }

        public void M_Division(double b)
        {
            memory /= b;
        }

        public void M_Sum(double b)
        {
            memory += b;
        }

        public void M_Subtraction(double b)
        {
            memory -= b;
        }

    }
}
