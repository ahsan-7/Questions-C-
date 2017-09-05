using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question28
    {
        private string[] words { get; set; }
        private int l { get; set; }
        private int i { get; set; }
        private string newLine { get; set; }
        private string line { get; set; }

        private void getInput()
        {
            Console.Write("Enter the String: ");
            line = Console.ReadLine();
        }

        private void function()
        {
            words = line.Split(new[] { " " }, StringSplitOptions.None);
            l = words.Length - 1;
            for (i = l; i >= 0; i--)
            {
                newLine = newLine + words[i] + " ";
            }
            Console.WriteLine("The string in Reverse  Order Is : {0}", newLine);
        }

        public void solution()
        {
            getInput();
            function();
        }
    }
}
