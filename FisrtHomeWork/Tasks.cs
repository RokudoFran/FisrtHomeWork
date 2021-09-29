using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisrtHomeWork
{
    class Tasks
    {
        public static string Exercise1(Double A, Double B)
        {
            string Message = "";
            Double C = 5 * A + B * B;

            Double D = B - A;

            if (D == 0)
            {
                Message = "Разница между B и A равна 0, невозможно вычислить значение выражения";
            }
            else
            {
                Double F = C / D;

                Message = $"Значение выражения ( 5 * A + B * B ) / ( B - A ) при A = {A} и B = {B} равно {F}";
            }

            return Message;
        }

        public static string Exercise2(string A, string B)
        {
            String C = "";

            C = A;
            A = B;
            B = C;

            string Message = "";

            Message = $"Значение A = {A} и значение B = {B}";

            return Message;

        }

        public static string Exercise3(Double A, Double B)
        {
            string Message = "";
            int del;
            double ost;

            if ((B == 0)||(A<B)) 
            {
                Message = $"Невозможно вывести результат деления A на B";
            }
            else
            {
                del = Convert.ToInt32 (A / B);
                ost = B % A;
                
                Message = $"Результат деления A на B = {del} и остаток от деления={ost}";
            }
            return Message;

        }

        public static string Exercise4(float A, float B, float C)
        {
            string Message = "";
            float x = 0;

            x = (C - B) / A;
            Message = $"Решение (значение X) линейного уравнения стандартного вида, где A * X + B = C равно {x}";
            return Message;
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
