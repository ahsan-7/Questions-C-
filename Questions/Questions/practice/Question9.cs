using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question9
    {
        private float setA { get; set; }
        private float setB { get; set; }
        private float setC { get; set; }
        private float setD { get; set; }
        private float setE { get; set; }

        private void getInput()
        {
            Console.Write("Enter no 1: ");
            setA = float.Parse(Console.ReadLine());
            Console.Write("Enter no 2: ");
            setB = float.Parse(Console.ReadLine());
            Console.Write("Enter no 3: ");
            setC = float.Parse(Console.ReadLine());
            Console.Write("Enter no 4: ");
            setD = float.Parse(Console.ReadLine());
        }

        private void average()
        {
            setE = setA + setB + setC + setD / 4;
            Console.WriteLine("Average of {0},{1},{2},{3} is {4}",setA,setB,setC,setD,setE);
        }

        public void solution()
        {
            getInput();
            average();
        }
    }
}
