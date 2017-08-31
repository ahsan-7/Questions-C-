using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question20
    {
        private int setNo1 { get; set; }
        private int setNo2 { get; set; }
        private int doubleOfValue { get; set; }
        private int absoluteValue { get; set; }

        private void getInputs()
        {
            Console.Write("Enter no 1: ");
            setNo1 = int.Parse(Console.ReadLine());
            Console.Write("Enter no 2: ");
            setNo2 = int.Parse(Console.ReadLine());
        }

        private void checkInputs()
        {
            absoluteValue = setNo1 - setNo2;
            if(setNo1 > setNo2)
            {
                doubleOfValue = absoluteValue * absoluteValue;
                Console.WriteLine("Double absolute value is: {0}",doubleOfValue);
            }
            else
            {
                Console.WriteLine("value1 is less than value2");
            }
        }

        public void solution()
        {
            getInputs();
            checkInputs();
        }
    }
}
