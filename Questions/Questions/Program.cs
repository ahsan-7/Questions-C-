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
                    Question2 solu2 = new Question2();
                    solu2.Solution2();
                    break;
                case (3):
                    Question3 solu3 = new Question3();
                    solu3.Solution3();
                    break;
                default:
                    Console.WriteLine("Please Input a Valid No.");
                    break;
            }
        }
    }
}
