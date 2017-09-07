using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question49
    {
        private int[] array1 { get; set; }
        private int[] array2 { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            array1 = new int[5];
            for(i = 0; i < 5; i++)
            {
                Console.Write("Enter Array1[{0}]: ",i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            array2 = new int[5];
            for (i = 0; i < 5; i++)
            {
                Console.Write("Enter Array2[{0}]: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }
        }

        private void checkArray()
        {
            if(array1[0] == array2[0] || array1[array1.Length - 1] == array2[array2.Length - 1])
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
