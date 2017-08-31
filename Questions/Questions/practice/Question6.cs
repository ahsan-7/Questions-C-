using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question6
    {
        private float setA { get; set; }
        private float setB { get; set; }
        private float setC { get; set; }

        public float multiply()
        {
            return (this.setA * this.setB * this.setC);
        }

        public void solution()
        {
            Console.Write("Enter value 1: ");
            this.setA = float.Parse(Console.ReadLine());
            Console.Write("Enter value 2: ");
            this.setB = float.Parse(Console.ReadLine());
            Console.Write("Enter value 3: ");
            this.setC = float.Parse(Console.ReadLine());
            Console.WriteLine("Answer is: {0}",multiply());
        }
    }
}
