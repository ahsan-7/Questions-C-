using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question33
    {
        private int number { get; set; }

        private void getInput()
        {
            Console.Write("Enter the no: ");
            number = int.Parse(Console.ReadLine());
        }

        private void checkNum()
        {
            if(number % 3 == 0 || number % 7 == 0)
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
            checkNum();
        }
    }
}
