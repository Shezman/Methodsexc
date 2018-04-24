using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodsexc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Integer do you want to do the math operation on?");
            int userInt = Convert.ToInt32(Console.ReadLine());

           
            userInt = methodClass.AddOperator(userInt);
            userInt = methodClass.DivideOperator(userInt);
            userInt = methodClass.SubtractOperator(userInt);

            Console.WriteLine(userInt);
            Console.ReadLine();
        }
    }
}
