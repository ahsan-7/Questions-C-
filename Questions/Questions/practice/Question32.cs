using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question32
    {
        private string InputString { get; set; }
        private string[] words { get; set; }
        private string lastWord { get; set; }
        private int stringLength { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            Console.Write("Enter the String: ");
            InputString = Console.ReadLine();
        }

        private void function()
        {
            words = InputString.Split(new[] { " " }, StringSplitOptions.None);
            stringLength = words.Length;
            lastWord = words[stringLength - 1];
            if (stringLength < 4)
            {
                Console.WriteLine(InputString);
            }
            else
            {
                for(i = 1; i <= 4; i++)
                {
                    Console.Write(lastWord);
                }
                Console.WriteLine("");  
            }
        }

        public void solution()
        {
            getInput();
            function();
        }
    }
}
