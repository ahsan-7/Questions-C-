using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question23
    {
        private string setA { get; set; }
        private string setB { get; set; }

        private void getString()
        {
            Console.Write("Enter the string: ");
            setA = Console.ReadLine();
        }

        private void stringToLowerCase()
        {
            setB = setA.ToLower();
            Console.WriteLine(setB);
        }

        public void solution()
        {
            getString();
            stringToLowerCase();
        }
    }
}
