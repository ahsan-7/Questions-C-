using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question47
    {
        private int[] array { get; set; }
        private int sum { get; set; }
        private int i { get; set; }

        private void checkArray()
        {
            array = new int[] {1,2,2,3,3,4,5,6,5,7,7,7,8,8,1};
            for (i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine(sum);
        }

        public void solution()
        {
            checkArray();
        }
    }
}
