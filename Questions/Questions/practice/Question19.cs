using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question19
    {
        private int setNo1 { get; set; }
        private int setNo2 { get; set; }
        private int sum { get; set; }

        private void getInputs()
        {
            Console.Write("Enter no 1: ");
            setNo1 = int.Parse(Console.ReadLine());
            Console.Write("Enter no 2: ");
            setNo2 = int.Parse(Console.ReadLine());
        }

        private void checkInputs()
        {
            if(setNo1 == setNo2)
            {
                sum = setNo1 + setNo2;
                Console.WriteLine("Sum is: {0}",sum);
            }
            else
            {
                Console.WriteLine("no1 is not equal to no2");
            }
        }

        public void solution()
        {
            getInputs();
            checkInputs();
        }
    }
}
