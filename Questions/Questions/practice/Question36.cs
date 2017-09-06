using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question36
    {
        private int firstNumber { get; set; }
        private int secondNumber { get; set; }

        private void getInput()
        {
            Console.Write("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
        }

        private void checkInput()
        {
            if(firstNumber > -10 && firstNumber < 10 || secondNumber > -10 && secondNumber < 10)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public void solution()
        {
            getInput();
            checkInput();
        }
    }
}
