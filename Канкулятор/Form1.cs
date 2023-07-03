using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Канкулятор
{
    public partial class Form1 : Form
    {
        Calc C;

        int k; //количество нажатий кнопки MRC
        string znak = "";
        double a = 0;


        public Form1()
        {
            InitializeComponent();

            C = new Calc();

            labelNumber.Text = "0";
        }

        //кнопка Очистка (CE)
        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";

            a=0;
            k = 0;
        }

        //кнопка изменения знака у числа
        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (labelNumber.Text[0] == '-')
                labelNumber.Text = labelNumber.Text.Remove(0, 1);
            else
                labelNumber.Text = "-" + labelNumber.Text;
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if ((labelNumber.Text.IndexOf(",") == -1) && (labelNumber.Text.IndexOf("∞") == -1))
                labelNumber.Text += ",";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            labelNumber.Text += (sender as Button).Text;

            CorrectNumber();
        }

        
        //удаляем лишний ноль впереди числа, если таковой имеется
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (labelNumber.Text.IndexOf("∞") != -1)
                labelNumber.Text = labelNumber.Text.Substring(0, labelNumber.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (labelNumber.Text[0] == '0' && (labelNumber.Text.IndexOf(",") != 1))
                labelNumber.Text = labelNumber.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (labelNumber.Text[0] == '-')
                if (labelNumber.Text[1] == '0' && (labelNumber.Text.IndexOf(",") != 2))
                    labelNumber.Text = labelNumber.Text.Remove(1, 1);
        }



        //кнопка Равно
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            switch (znak)
            {
                case "*": labelNumber.Text = C.Multiplication(a,Convert.ToDouble(labelNumber.Text)).ToString();
                    break;
                case "/": labelNumber.Text = C.Division(a,Convert.ToDouble(labelNumber.Text)).ToString();
                    break;
                case "+":
                    labelNumber.Text = C.Sum(a,Convert.ToDouble(labelNumber.Text)).ToString();
                    break;
                case "-":
                    labelNumber.Text = C.Subtraction(a,Convert.ToDouble(labelNumber.Text)).ToString();
                    break;
                case "SqrtX":
                    labelNumber.Text = C.SqrtX(a,Convert.ToDouble(labelNumber.Text)).ToString();
                    break;
                case "DegreeY":
                    labelNumber.Text = C.DegreeY(a,Convert.ToDouble(labelNumber.Text)).ToString();
                    break;
            }
            znak = "";
            a=0;
            k = 0;
           
        }





        //кнопка Умножение
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (znak != "")
            {
                switch (znak)
                {
                    case "*":
                        labelNumber.Text = C.Multiplication(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "/":
                        labelNumber.Text = C.Division(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "+":
                        labelNumber.Text = C.Sum(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "-":
                        labelNumber.Text = C.Subtraction(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "SqrtX":
                        labelNumber.Text = C.SqrtX(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "DegreeY":
                        labelNumber.Text = C.DegreeY(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                }
            }
            a =Convert.ToDouble(labelNumber.Text);
            znak = "*";
            labelNumber.Text = "0";
            
        }

        //кнопка Деление
        private void buttonDiv_Click(object sender, EventArgs e)
        {

            if (znak != "")
            {
                switch (znak)
                {
                    case "*":
                        labelNumber.Text = C.Multiplication(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "/":
                        labelNumber.Text = C.Division(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "+":
                        labelNumber.Text = C.Sum(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "-":
                        labelNumber.Text = C.Subtraction(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "SqrtX":
                        labelNumber.Text = C.SqrtX(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "DegreeY":
                        labelNumber.Text = C.DegreeY(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                }
            }
            a = Convert.ToDouble(labelNumber.Text);

            znak = "/";

            labelNumber.Text = "0";
            
        }

        //кнопка Сложение
        private void buttonPlus_Click(object sender, EventArgs e)
        {

            if (znak != "")
            {
                switch (znak)
                {
                    case "*":
                        labelNumber.Text = C.Multiplication(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "/":
                        labelNumber.Text = C.Division(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "+":
                        labelNumber.Text = C.Sum(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "-":
                        labelNumber.Text = C.Subtraction(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "SqrtX":
                        labelNumber.Text = C.SqrtX(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "DegreeY":
                        labelNumber.Text = C.DegreeY(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                }
            }
            a = Convert.ToDouble(labelNumber.Text);
            znak = "+";

            labelNumber.Text = "0";
            
        }

        //кнопка Вычитание
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (znak != "")
            {
                switch (znak)
                {
                    case "*":
                        labelNumber.Text = C.Multiplication(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "/":
                        labelNumber.Text = C.Division(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "+":
                        labelNumber.Text = C.Sum(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "-":
                        labelNumber.Text = C.Subtraction(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "SqrtX":
                        labelNumber.Text = C.SqrtX(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "DegreeY":
                        labelNumber.Text = C.DegreeY(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                }
            }
            a = Convert.ToDouble(labelNumber.Text);

            znak = "-";

            labelNumber.Text = "0";
            
        }

        //кнопка Корень произвольной степени
        private void buttonSqrtX_Click(object sender, EventArgs e)
        {
            if (znak != "")
            {
                switch (znak)
                {
                    case "*":
                        labelNumber.Text = C.Multiplication(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "/":
                        labelNumber.Text = C.Division(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "+":
                        labelNumber.Text = C.Sum(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "-":
                        labelNumber.Text = C.Subtraction(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "SqrtX":
                        labelNumber.Text = C.SqrtX(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "DegreeY":
                        labelNumber.Text = C.DegreeY(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                }
            }

            a = Convert.ToDouble(labelNumber.Text);

            znak = "SqrtX";

            labelNumber.Text = "0";
            
        }

        //кнопка Возведение в произвольную степень
        private void buttonDegreeY_Click(object sender, EventArgs e)
        {
            if (znak != "")
            {
                switch (znak)
                {
                    case "*":
                        labelNumber.Text = C.Multiplication(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "/":
                        labelNumber.Text = C.Division(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "+":
                        labelNumber.Text = C.Sum(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "-":
                        labelNumber.Text = C.Subtraction(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "SqrtX":
                        labelNumber.Text = C.SqrtX(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                    case "DegreeY":
                        labelNumber.Text = C.DegreeY(a, Convert.ToDouble(labelNumber.Text)).ToString();
                        break;
                }
            }
            a = Convert.ToDouble(labelNumber.Text);

            znak = "DegreeY";


            labelNumber.Text = "0";
            
        }

        //кнопка Корень квадратный
        private void buttonSqrt_Click(object sender, EventArgs e)
        {


            a = Convert.ToDouble(labelNumber.Text);

            labelNumber.Text = C.Sqrt(a).ToString();

            a = 0;
                
            
        }

        //кнопка Квадрат числа
        private void buttonSquare_Click(object sender, EventArgs e)
        {


            a = Convert.ToDouble(labelNumber.Text);

            labelNumber.Text = C.Square(a).ToString();

            a = 0;
             
            
        }

        //кнопка Факториал
        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            
            
                if ((Convert.ToDouble(labelNumber.Text) == (int)(Convert.ToDouble(labelNumber.Text))) &&
                    ((Convert.ToDouble(labelNumber.Text) >= 0.0)))
                {
                    a=Convert.ToDouble(labelNumber.Text);

                    labelNumber.Text = C.Factorial(a).ToString();

                    a = 0;
                   
                }
                else
                    MessageBox.Show("Число должно быть >= 0 и целым!");
            
        }

        //кнопка М+
        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            C.M_Sum(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка М-
        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            C.M_Subtraction(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка М*
        private void buttonMMult_Click(object sender, EventArgs e)
        {
            C.M_Multiplication(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка М/
        private void buttonMDiv_Click(object sender, EventArgs e)
        {
            C.M_Division(Convert.ToDouble(labelNumber.Text));
        }

        //кнопка МRC
        private void buttonMRC_Click(object sender, EventArgs e)
        {
            
          
            k++;

            if (k == 1)
                labelNumber.Text = C.MemoryShow().ToString();

            if (k == 2)
            {
                C.Memory_Clear();
                labelNumber.Text = "0";

                k = 0;
            }
            
        }








        

        
    }
}
