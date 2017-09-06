using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question42
    {
        private string inputString { get; set; }
        private string fourChar { get; set; }
        private string lastChar { get; set; }
        private string newString { get; set; }
        private int length { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void checkInput()
        {
            length = inputString.Length;
            if (length < 4)
            {
                newString = inputString.ToUpper();
                Console.WriteLine(newString);
            }
            else
            {
                fourChar = inputString.Substring(0, 4).ToLower();
                lastChar = inputString.Substring(4);
                newString = fourChar + lastChar;
                Console.WriteLine(newString);
            }
        }

        public void solution()
        {
            getInput();
            checkInput();
        }
    }
}
