using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question43
    {
        private string inputString { get; set; }
        private string threeChar { get; set; }
        private int length { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }
        private void checkInput()
        {
            length = inputString.Length;
            if (length >= 5)
            {
                threeChar = inputString.Substring(0, 5);
                if(threeChar == "wwwww")
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
            else
            {
                Console.WriteLine("string length is too short");
            }
        }

        public void solution()
        {
            getInput();
            checkInput();
        }
    }
}
