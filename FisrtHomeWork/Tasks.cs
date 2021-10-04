using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisrtHomeWork
{
    class Tasks
    {
        public static string Exercise1(double a, double b)
        {
            string message = "";
            double c = 5 * a + b * b;

            double d = b - a;

            if (d == 0)
            {
                message = "Разница между B и A равна 0, невозможно вычислить значение выражения";
            }
            else
            {
                double f = c / d;

                message = $"Значение выражения ( 5 * A + B * B ) / ( B - A ) при A = {a} и B = {b} равно {f}";
            }

            return message;
        }

        public static string Exercise2(string a, string b
            )
        {
            String c = "";

            c = a;
            a = b;
            b = c;

            string message = "";

            message = $"Значение A = {a} и значение B = {b}";

            return message;

        }

        public static string Exercise3(double a, double b)
        {
            string message = "";
            int del;
            double ost;

            if ((b == 0)||(a<b)) 
            {
                message = $"Невозможно вывести результат деления A на B";
            }
            else
            {
                del = Convert.ToInt32 (a / b);
                ost = b % a;
                
                message = $"Результат деления A на B = {del} и остаток от деления={ost}";
            }
            return message;

        }

        public static string Exercise4(float a, float b, float c)
        {
            string message = "";
            float x = 0;

            x = (c - b) / a;
            message = $"Решение (значение X) линейного уравнения стандартного вида, где A * X + B = C равно {x}";
            return message;
        }

        public static string Exercise5(float x1, float y1, float x2, float y2)
        {
            float a;
            float b;
            string urav;

            if (x2 - x1 == 0)
            {
                urav = "Невозможно построить уравнение";
            }
            else if (y2-y1==0)
            {
                urav = $" Y = {y1}";
            }
            else
            {
                a = (y2 - y1) / (x2 - x1);

                b = y1 - a * x1;

                if (b > 0)
                {
                    urav = $" Y = {a}X + {b}";
                }
                else if (b < 0)
                {
                    urav = $" Y = {a}X - {Math.Abs(b)}";
                }
                else
                {
                    urav = $" Y = {a}X";
                }
            }

            return urav;

        }

    }
}
