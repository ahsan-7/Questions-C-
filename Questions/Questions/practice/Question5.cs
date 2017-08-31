using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question5
    {
        private int setA { get; set; }
        private int setB { get; set; }
        private int setC { get; set; }
        private int setD { get; set; }

        private void getInput()
        {
            Console.Write("Enter no 1: ");
            this.setA = int.Parse(Console.ReadLine());
            Console.Write("Enter noi 2: ");
            this.setB = int.Parse(Console.ReadLine());
        }
        private void swappedValueOfA()
        {
            setC = setA + setB;
            setA = setC - setA;
            setD = this.setA;
            Console.WriteLine(setD);
        }
        private void swappedValueOfB()
        {
            setB = setC - setB;
            setD = this.setB;
            Console.WriteLine(setD);
        }

        public void solution()
        {
            getInput();
            swappedValueOfA();
            swappedValueOfB();  
        }
    }
}
