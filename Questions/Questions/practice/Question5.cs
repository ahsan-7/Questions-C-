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

        private int swap1()
        {
            setC = setA + setB;
            setA = setC - setA;
            return (this.setA);  
        }
        private int swap2()
        {
            setB = setC - setB;
            return (this.setB);
        }

        public void solution()
        {
            Console.Write("Enter no 1: ");
            this.setA = int.Parse(Console.ReadLine());
            Console.Write("Enter noi 2: ");
            this.setB = int.Parse(Console.ReadLine());
            Console.WriteLine(swap1());
            Console.WriteLine(swap2());
        }
    }
}
