using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Questions.practice;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuesNo;
            Console.Write("Enter Question No: ");
            QuesNo = int.Parse(Console.ReadLine());
            switch (QuesNo)
            {
                case (1):
                    Question1 solu = new Question1();
                    solu.Solution1();
                    break;
                case (2):
                    int a;
                    int b;
                    Console.Write("Enter value of a: ");
                    a = int.Parse(Console.ReadLine());
                    Console.Write("Enter value of b: ");
                    b = int.Parse(Console.ReadLine());
                    Question2 solu2 = new Question2();
                    solu2.Solution2(a , b);
                    break;
                default:
                    Console.WriteLine("Please Input a Valid No.");
                    break;
            }
        }
    }
}
