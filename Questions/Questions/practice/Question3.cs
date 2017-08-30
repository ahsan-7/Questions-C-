using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question3
    {
        public void Solution3()
        {
            float a;
            float b;
            Console.Write("Enter value of a: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter value of b: ");
            b = int.Parse(Console.ReadLine());
            AcceptValues(a , b);
        }
        static void AcceptValues(float a , float b)
        {
            float Division = a / b;
            Console.WriteLine("a / b = {0}",Division);
        }
    }
}
