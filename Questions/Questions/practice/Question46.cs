using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question46
    {
        private int[] array { get; set; }
        private int number { get; set; }
        
        private void getInput()
        {
            Console.Write("Enter the no: ");
            number = int.Parse(Console.ReadLine());
        }

        private void checkArray()
        {
            array = new int[] { 1, 4, 5, 3, 6, 7, 89, 4, 3, 54, 3, 23, 44, 5, 3, 23, 43, 3 };
            if (array[0] == number || array[array.Length -1] == number)
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
