using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question7
    {
        private float setA { get; set; }
        private float setB { get; set; }

        private float add()
        {
            return (this.setA + this.setB);
        }
        private float subtract()
        {
            return (this.setA - this.setB);
        }
        private float multiply()
        {
            return (this.setA * this.setB);
        }
        private float divide()
        {
            return (this.setA / this.setB);
        }

        public void solution()
        {
            Console.Write("Enter value 1: ");
            this.setA = float.Parse(Console.ReadLine());
            Console.Write("Enter value 2: ");
            this.setB = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}",setA,setB,add());
            Console.WriteLine("{0} - {1} = {2}", setA, setB, subtract());
            Console.WriteLine("{0} * {1} = {2}", setA, setB, multiply());
            Console.WriteLine("{0} / {1} = {2}", setA, setB, divide());
        }
    }
}
