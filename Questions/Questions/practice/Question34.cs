using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question34
    {
        private string inputString { get; set; }
        private string[] words { get; set; }
        private string firstWord { get; set; }
        private string specifiedWord { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void checkString()
        {
            words = inputString.Split(new[] { " " }, StringSplitOptions.None);
            firstWord = words[0];
            specifiedWord = "Hello";
            if(firstWord == specifiedWord)
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
            checkString();
        }
    }
}
