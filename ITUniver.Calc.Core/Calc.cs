using ITUniver.Calc.Core.Interfaces;
using ITUniver.Calc.Core.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleCalc
{
    public class Calc
    {
        private IList<IOperation> operations { get; set; }

        public Calc()
        {
            operations = new List<IOperation>();

            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes();

            foreach (var item in types)
            {
                var interfaces = item.GetInterfaces();

                var isOperation = interfaces.Any(it => it == typeof(IOperation));

                if(isOperation)
                { 
                    // создаем экземпляр объекта                   
                    var obj = Activator.CreateInstance(item);

                    var operation = obj as IOperation;
                    if(operation != null)
                    {
                        operations.Add(operation);
                    }
                    
                }
            }


        }

        /// <summary>
        /// Получить список имен операций
        /// </summary>
        /// <returns></returns>
        public string[] GetOperNames()
        {
            return operations.Select(o => o.Name).ToArray();
        }

        public double Exec(string oper, double[] args)
        {     

            // найти операцию в списке
            var operation = operations.FirstOrDefault(o => o.Name == oper);
                                    
            // если не найдена - возвращаем ошибку
            if (operation == null)
            {
                return double.NaN;
            }

            // если нашли
            // передаем ей аргументы и вычисляем результат
            var result = operation.Exec(args);
            
            // возвращаем результат 
            return result;
        }
        public double sub(double x, double y)
        {
            return x - y;
        }
        public double sum(double x, double y)
        {
            var oper = new SumOperation();
            var result = oper.Exec(new[] { x, y });
            return x + y;
        }
        public double mul(double x, double y)
        {
            return x * y;
        }
        public double div(double x, double y)
        {
            return x / y;
        }
        public double sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
