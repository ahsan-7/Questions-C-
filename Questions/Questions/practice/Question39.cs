using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question39
    {
        private int firstNumber { get; set; }
        private int secondNumber { get; set; }
        private int thirdNumber { get; set; }

        private void getInput()
        {
            Console.Write("Enter first no: ");
            firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second no: ");
            secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third no: ");
            thirdNumber = int.Parse(Console.ReadLine());
        }

        private void checkInput()
        {
            if(firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine("Lowest of three: {0}",firstNumber);
            }
            else
            {
                if (secondNumber < firstNumber && secondNumber < thirdNumber)
                {
                    Console.WriteLine("Lowest of three: {0}", secondNumber);
                }
                else
                {
                    if (thirdNumber < secondNumber && thirdNumber < firstNumber)
                    {
                        Console.WriteLine("Lowest of three: {0}", thirdNumber);
                    }
                }
            }
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("Largest of three: {0}", firstNumber);
            }
            else
            {
                if (secondNumber > firstNumber && secondNumber > thirdNumber)
                {
                    Console.WriteLine("Largest of three: {0}", secondNumber);
                }
                else
                {
                    if (thirdNumber > secondNumber && thirdNumber > firstNumber)
                    {
                        Console.WriteLine("Largest of three: {0}", thirdNumber);
                    }
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
