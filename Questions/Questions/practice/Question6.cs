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
        private float setD { get; set; }

        private void getInput()
        {
            Console.Write("Enter value 1: ");
            this.setA = float.Parse(Console.ReadLine());
            Console.Write("Enter value 2: ");
            this.setB = float.Parse(Console.ReadLine());
            Console.Write("Enter value 3: ");
            this.setC = float.Parse(Console.ReadLine());
        }
        private void multiply()
        {
            setD = this.setA * this.setB * this.setC;
            Console.WriteLine("Multiplication of the input is {0}", setD);
        }

        public void solution()
        {
            getInput();
            multiply(); 
        }
    }
}
