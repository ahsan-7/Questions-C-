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

        public int swapB()
        {
            return (this.setC = setB);   
        }
        public int swapA()
        {
            return (this.setC = setA);
        }

        public void solution()
        {
            Console.Write("Enter no 1: ");
            this.setA = int.Parse(Console.ReadLine());
            Console.Write("Enter noi 2: ");
            this.setB = int.Parse(Console.ReadLine());
            Console.WriteLine(swapB());
            Console.WriteLine(swapA());
        }
    }
}
