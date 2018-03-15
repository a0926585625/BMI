using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI;
            Console.Write("身高:");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.Write("體重:");
            double b = Convert.ToInt32(Console.ReadLine());

            double c = b / ((a / 100) * (a / 100));

            Console.WriteLine("BMI:" + c);

            if(c>24)
            {
                Console.WriteLine("過重");
                Console.ReadLine();
            }
            else if (c<24&&c>18)
            {
                Console.WriteLine("適中");
                Console.ReadLine();
            }
            else if (c<18)
            {
                Console.WriteLine("過輕");
                Console.ReadLine();
            }
      }
    }
}
