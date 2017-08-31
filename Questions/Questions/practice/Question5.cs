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
        public int setB { get; set; }
        public int setC { get; set; }

        public int swap1()
        {
            setC = setA + setB;
            setA = setC - setA;
            return (this.setA);  
        }
        public int swap2()
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
