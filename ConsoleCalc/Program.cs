using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор");

            Calc calc = new Calc();
            string oper;
            double a, b=0, res;

            if (args.Length == 0)
            {
                Console.WriteLine("Введите название функции:");
                oper = Console.ReadLine();
                Console.WriteLine("Введите аргумент 1:");
                a = Convert.ToDouble(Console.ReadLine());
                if (oper != "sqrt")
                {
                    Console.WriteLine("Введите аргумент 2:");
                    b = Convert.ToDouble(Console.ReadLine());
                }
            }
            else
            {
                oper = args[0];
                a = Convert.ToDouble(args[1]);
                b = Convert.ToDouble(args[2]);
            }
            
                    
            if(oper == "sqrt")
            {
                res = calc.sqrt(a);
                Console.WriteLine($"Sqrt({a})= {res}");
            }
            else if (oper == "sum")
            {
                res = calc.sum(a, b);
                Console.WriteLine($"Sum({a}, {b})= {res}");
            }
            else if (oper == "sub")
            {
                res = calc.sub(a, b);
                Console.WriteLine($"Sub({a}, {b})= {res}");
            }
            else if (oper == "mul")
            {
                res = calc.mul(a, b);
                Console.WriteLine($"Mul({a}, {b})= {res}");
            }
            else if (oper == "div")
            {
                res = calc.div(a, b);
                Console.WriteLine($"Div({a}, {b})= {res}");
            }
            else
            {
                Console.WriteLine("null");
            }

            Console.ReadKey();
        }
    }
}
