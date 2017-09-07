using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question53
    {
        private int[] array { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            array = new int[4];
            for(i = 0; i < 4; i++)
            {
                Console.Write("Enter Array[{0}]: ",i);
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void checkArray()
        {
            for(i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 1)
                {
                    Console.WriteLine("True");
                    break;
                }
            }
        }

        public void solution()
        {
            getInput();
            checkArray();
        }
    }
}
