using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question44
    {
        private string inputString { get; set; }
        private string newString { get; set; }
        private int length { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void checkInput()
        {
            length = inputString.Length;
            for (i = 0; i < length; i+=2)
            {
                newString = inputString.Substring(i , 1);
                Console.Write(newString);
            }
            Console.WriteLine("");
        }

        public void solution()
        {
            getInput();
            checkInput();
        }
    }
}
