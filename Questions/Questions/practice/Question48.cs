using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question48
    {
        private int[] array { get; set; }
        private int i { get; set; }
        private int v { get; set; }

        private void getInput()
        {
            array = new int[5];
            for(i = 0; i < 5; i++)
            {
                Console.Write("Ente Array[{0}]: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void checkArray()
        {
            if(array[0] == array[array.Length - 1])
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public void solution()
        {
            getInput();
            checkArray();
        }
    }
}
