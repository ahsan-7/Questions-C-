using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question10
    {
        private float setA { get; set; }
        private float setB { get; set; }
        private float setC { get; set; }
        private float setD { get; set; }

        private void getInput()
        {
            Console.Write("Enter value 1: ");
            setA = float.Parse(Console.ReadLine());
            Console.Write("Enter value 2: ");
            setB = float.Parse(Console.ReadLine());
            Console.Write("Enter value 3: ");
            setC = float.Parse(Console.ReadLine());
        }

        private void function1()
        {
            setD = (setA + setB) * setC;
            Console.WriteLine("Answer of function1 is: {0}",setD);
        }
        private void function2()
        {
            setD = setA * setB  + setB * setC;
            Console.WriteLine("Answer of function2 is: {0}", setD);
        }

        public void solution()
        {
            getInput();
            function1();
            function2();
        }
    }
}
