using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number Num1= ");
            int Num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number Num2= ");
            int Num2=Convert.ToInt32(Console.ReadLine());
            Num1=Num1*Num2;
            Num2 = Num1 / Num2;
            Num1 = Num1 / Num2;
            Console.WriteLine("Swapped Num1=" + Num1);
            Console.WriteLine("Swapped Num2="+Num2);

        }
    }
}
