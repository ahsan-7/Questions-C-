using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question24
    {
        private string line { get; set; }
        private string[] words { get; set; }
        private string word { get; set; }
        private int ctr { get; set; }

        private void getInput()
        {
            Console.Write("Enter the String: ");
            line = Console.ReadLine();
        }

        private void function()
        {
            words = line.Split(new[] { " " }, StringSplitOptions.None);
            word = "";
            ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            Console.WriteLine(word);
        }

        public void solution()
        {
            getInput();
            function();
        }
    }
}
