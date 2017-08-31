﻿using System;
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
                    solu.solution();
                    break;
                case (2):
                    Question2 solu2 = new Question2();
                    solu2.solution();
                    break;
                case (3):
                    Question3 solu3 = new Question3();
                    solu3.solution();
                    break;
                case (4):
                    Question4 solu4 = new Question4();
                    solu4.solution();
                    break;
                case (5):
                    Question5 solu5 = new Question5();
                    solu5.solution();
                    break;
                case (6):
                    Question6 solu6 = new Question6();
                    solu6.solution();
                    break;
                default:
                    Console.WriteLine("Please Input a Valid No.");
                    break;
            }
        }
    }
}
