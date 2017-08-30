using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question2
    {
        public void Solution2()
        {
            int a;
            int b;
            Console.Write("Enter value of a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter value of b: ");
            b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine("a + b =  {0}",sum);
        }
    }
}
