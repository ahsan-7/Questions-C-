using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question21
    {
        private int setNo1 { get; set; }
        private int setNo2 { get; set; }
        private int setNo3 { get; set; }

        private void getInputs()
        {
            Console.Write("Enter no 1: ");
            setNo1 = int.Parse(Console.ReadLine());
            Console.Write("Enter no 2: ");
            setNo2 = int.Parse(Console.ReadLine());
        }

        private void function()
        {
            setNo3 = setNo1 + setNo2;
            if(setNo1 == 20 || setNo2 == 20 || setNo3 == 20)
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
            getInputs();
            function();
        }
    }
}
