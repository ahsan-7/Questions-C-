using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question52
    {
        private int[] array1 { get; set; }
        private int[] array2 { get; set; }
        private int[] array3 { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            array1 = new int[3];
            for(i = 0; i < 3; i++)
            {
                Console.Write("Enter Array1[{0}]: ",i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            array2 = new int[3];
            for (i = 0; i < 3; i++)
            {
                Console.Write("Enter Array2[{0}]: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }
            array3 = new int[3];
            for (i = 0; i < 3; i++)
            {
                Console.Write("Enter Array3[{0}]: ", i);
                array3[i] = int.Parse(Console.ReadLine());
            }
        }

        private void newArray()
        {
            Console.WriteLine("New Array: [{0},{1},{2}]",array1[1],array2[1],array3[1]);
        }

        public void solution()
        {
            getInput();
            newArray();
        }
    }
}
