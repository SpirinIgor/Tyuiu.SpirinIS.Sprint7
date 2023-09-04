using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SpirinIS.Sprint7.Task0.V0.Lib;

namespace Tyuiu.SpirinIS.Sprint7.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите значение переменной А");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной B");
            int b;
            b = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();

            var result = ds.Culc(a, b);
            Console.WriteLine("Сумма = " + result);
            Console.ReadKey();


        }
    }
}
