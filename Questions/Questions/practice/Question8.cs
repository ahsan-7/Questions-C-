using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question8
    {
        private int setA { get; set; }
        private int setB { get; set; }
        private int setC { get; set; }

        private void getInput()
        {
            Console.Write("Enter the value: ");
            this.setA = int.Parse(Console.ReadLine());
        }

        private void table()
        {
            for (setB = 0; setB <= 10; setB++)
            {
                setC = setA * setB; 
                Console.WriteLine("{0} * {1} = {2}", setA, setB, setC);
            }
        }

        public void solution()
        {
            getInput();
            table();
        }
    }
}
