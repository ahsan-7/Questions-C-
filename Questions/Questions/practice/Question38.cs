using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question38
    {
        private string inputString { get; set; }
        private string characters { get; set; }
        private string specifiedValue { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void checkInput()
        {
            characters = inputString.Substring(0,2);
            specifiedValue = "PH";
            if(characters == specifiedValue)
            {
                Console.WriteLine(characters);
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
