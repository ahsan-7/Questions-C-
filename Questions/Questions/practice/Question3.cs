using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question3
    {
        private float setA { get; set; }
        private float setB { get; set; }

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
            Console.WriteLine("value 1 / value 2 = {0}",divide());
        }
    }
}
