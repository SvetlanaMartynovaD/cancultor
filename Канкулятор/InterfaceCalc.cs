using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Канкулятор
{
    public interface InterfaceCalc
    {
        //а - первый аргумент, b - второй
         

       

        double Multiplication(double a, double b);

        double Division(double a,double b);

        double Sum(double a,double b);

        double Subtraction(double a,double b); //вычитание

        double SqrtX(double a,double b);

        double DegreeY(double a,double b);

        double Sqrt(double a);

        double Square(double a);

        double Factorial(double a);

        double MemoryShow(); //показать содержимое регистра мамяти

        void Memory_Clear(); //стереть содержимое регистра мамяти

        //* / + - к регистру памяти
        void M_Multiplication(double b);

        void M_Division(double b);

        void M_Sum(double b);

        void M_Subtraction(double b); //вычитание
    }
}
