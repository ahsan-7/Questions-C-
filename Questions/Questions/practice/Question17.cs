using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question17
    {
        private string inputString { get; set; }
        private string firstLetter { get; set; }
        private string newString { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void addingLetter()
        {
            firstLetter = inputString.Substring(0, 1);
            newString = firstLetter + inputString + firstLetter;
            Console.WriteLine("New string is: {0}",newString);
        }

        public void solution()
        {
            getInput();
            addingLetter();
        }
    }
}
