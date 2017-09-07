using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question45
    {
        private int[] array { get; set; }
        private int count { get; set; }
        private int number { get; set; }
        private int i { get; set; }

        private void getInput()
        {
            Console.Write("Enter the no: ");
            number = int.Parse(Console.ReadLine());
        }

        private void checkArray()
        {
            array = new int[] {1,2,3,4,5,5,5,5,5,5,5,5,5};
            for(i = 0; i < array.Length; i++)
            {
                if(array[i] == number)
                {
                    count++;
                }
            }
            Console.WriteLine("No of {0} present in the said array is {1}",number,count);
        }

        public void solution()
        {
            getInput();
            checkArray();
        }
    }
}
