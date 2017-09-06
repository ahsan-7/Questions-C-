using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question37
    {
        private string inputString { get; set; }
        private string[] words { get; set; }
        private string secondWord { get; set; }
        private string newString { get; set; }
        private string endPart { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            inputString = Console.ReadLine();
        }

        private void checkString()
        {
            words = inputString.Split(new[] { " " }, StringSplitOptions.None);
            secondWord = words[1];
            endPart = "";
            if(secondWord == "HP")
            {
                for(i = 2; i < words.Length; i++)
                {
                    endPart = endPart + words[i] + " ";
                }
                Console.WriteLine("{0} {1}",words[0],endPart);
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
