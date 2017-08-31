using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question16
    {
        private string inputString { get; set; }
        private string firstLetter { get; set; }
        private string lastLetter { get; set; }
        private int length { get; set; }
        private string body { get; set; }
        private string newString { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void changingString()
        {
            firstLetter = inputString.Substring(0, 1);
            length = inputString.Length;
            lastLetter = inputString.Substring(length - 1);
            body = inputString.Substring(1, length - 2);
            newString = lastLetter+body+firstLetter;
            Console.WriteLine("Changed string is: {0}",newString);
        }
        public void solution()
        {
            getInput();
            changingString();
        }
    }
}
