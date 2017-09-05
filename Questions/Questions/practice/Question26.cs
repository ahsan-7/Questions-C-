using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question26
    {
        private int n { get; set; }
        private int i { get; set; }
        private long sum { get; set; }
        private int ctr { get; set; }
        private int j { get; set; }

        private void function()
        {
            sum = 0;
            ctr = 0;
            n = 1;
            i = 1;
            j = 1;
            while (n <= 500)
            {
                j = 1;
                ctr = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        j++;
                    }
                    else
                    {
                        j++;
                    }
                }
                if (ctr == 2)
                {
                    sum +=i;
                    n++;
                }
                i++;
            }
            Console.Write(sum);
        }

        public void solution()
        {
            function();
        }
    }
}
