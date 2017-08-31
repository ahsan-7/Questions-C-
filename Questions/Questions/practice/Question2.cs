using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question2
    {
        
        private float setA { get; set; }
        private float setB { get; set; }
        private float setC { get; set; }

        private void getInput()
        {
            Console.Write("Enter value 1: ");
            this.setA = float.Parse(Console.ReadLine());
            Console.Write("Enter value 2: ");
            this.setB = float.Parse(Console.ReadLine());
        }
        private void add()
        {
            setC = this.setA + this.setB;
            Console.WriteLine("Sum is {0} ", setC);
        }

        public void solution()
        {
            getInput();
            add();
        }
    }
}
