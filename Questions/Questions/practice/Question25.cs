using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question25
    {
        private int setNo { get; set; }

        private void function()
        {
            for(setNo = 1; setNo <= 99; setNo += 2)
            {
                Console.WriteLine(setNo);
            }
        }

        public void solution()
        {
            function();
        }
    }
}
