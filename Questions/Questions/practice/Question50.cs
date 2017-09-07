using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question50
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

        private void rotateArray()
        {
            Console.WriteLine("Array after rotating: [{0},{1},{2}]",array[1],array[2],array[0]);
        }

        public void solution()
        {
            getInput();
            rotateArray();
        }
    }
}
