using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question31
    {
        private int[] setA { get; set; }
        private int[] setB { get; set; }
        private int setC { get; set; }
        private int i { get; set; }
        private int v { get; set; }
        private int length { get; set; }

        private void multiplyArray()
        {
            setA = new int[3];
            for(v = 0; v < 3; v++)
            {
                Console.Write("Enter value of A[{0}]: ",v);
                setA[v] = Convert.ToInt32(Console.ReadLine());
            }
            setB = new int[3];
            for (v = 0; v < 3; v++)
            {
                Console.Write("Enter value of B[{0}]: ", v);
                setB[v] = Convert.ToInt32(Console.ReadLine());
            }
            length = setA.Length;
            for (i = 0; i < length; i++)
            {
                setC = setA[i] * setB[i];
                Console.WriteLine("Multiplication of {0} and {1} is {2}", setA[i], setB[i], setC);
            }
        }

        public void solution()
        {
            multiplyArray();
        }
    }
}
