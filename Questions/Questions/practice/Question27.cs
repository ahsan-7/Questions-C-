using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question27
    {
        private int number { get; set; }
        private int sum { get; set; }
        private int divider { get; set; }

        private void getInput()
        {
            Console.Write("Enter the value: ");
            number = int.Parse(Console.ReadLine());
        }

        private void sumOfDigits()
        {
            while (number != 0)
            {
                divider = number % 10;
                number = number / 10;
                sum = sum + divider;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();
        }

        public void solution()
        {
            getInput();
            sumOfDigits();
        }
    }
}
