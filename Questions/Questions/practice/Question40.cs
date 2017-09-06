using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question40
    {
        private int firstNumber { get; set; }
        private int secondNumber { get; set; }

        private void getInput()
        {
            Console.Write("Enter the first no: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second no: ");
            secondNumber = int.Parse(Console.ReadLine());
        }

        private void checkInput()
        {
            if(secondNumber < 20)
            {
                if(firstNumber > secondNumber)
                {
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber);
                }
            }
            if (secondNumber > 20)
            {
                if (firstNumber < secondNumber)
                {
                    Console.WriteLine(firstNumber);
                }
                else
                {
                    Console.WriteLine(secondNumber);
                }
            }
        }

        public void solution()
        {
            getInput();
            checkInput();
        }
    }
}
