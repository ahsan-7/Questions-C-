using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question51
    {
        private int[] array { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            array = new int[3];
            for(i = 0; i < 3; i++)
            {
                Console.Write("Enter Array[{0}]: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void checkArray()
        {
            if(array[0] > array[array.Length - 1])
            {
                Console.WriteLine("Highest value between first and last value of said array is {0}",array[0]);
            }
            else
            {
                Console.WriteLine("Highest value between first and last value of said array is {0}", array[array.Length - 1]);
            }
        }

        public void solution()
        {
            getInput();
            checkArray();
        }
    }
}
