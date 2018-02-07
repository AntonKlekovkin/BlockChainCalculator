using ConsoleCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            var calc = new Calc();
            var operations = calc.GetOperNames();
            string oper, str;
            string[] param = null;

            Console.WriteLine("Калькулятор");
            
            if (args.Length == 0)
            {
                Console.WriteLine("Список возможных функций:");
                foreach (var item in operations)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Введите название функции:");
                oper = Console.ReadLine();

                Console.WriteLine("Введите аргументы строкой через запятую:");
                str = Console.ReadLine();

                param = str.Split(',');
            }

            else
            {
                oper = args[0];
                param = args[1].Split(',');
            }

            Calculation(oper, param);
            Console.ReadKey();
        }

        static void Calculation(string oper, string[] args)
        {
            Calc calc = new Calc();

            double[] args1 = new double[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                args1[i] = Convert.ToDouble(args[i]);
            }

            var res = calc.Exec(oper, args1);

            if (oper == "sqrt")
            {
                Console.WriteLine($"{oper}({args[0]})={res}");
            }
            else
            {
                Console.WriteLine($"{oper}({String.Join(",", args)})={res}");
            }

        }
    }
}
