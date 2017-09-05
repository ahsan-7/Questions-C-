using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question22
    {
        private int setNo { get; set; }

        private void getInput()
        {
            Console.Write("Enter the no: ");
            setNo = int.Parse(Console.ReadLine());
        }

        private void function()
        {
            if(setNo > 20 && setNo < 200)
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
            function();
        }
    }
}
