using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question41
    {
        private string inputString { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void checkInput()
        {
            if (inputString.Contains("w"))
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
