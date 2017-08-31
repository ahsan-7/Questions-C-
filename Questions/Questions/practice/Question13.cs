using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question13
    {
        private int setNo { get; set; }
        private int setNo2 { get; set; }

        private void getInput()
        {
            Console.Write("Enter the no: ");
            setNo = int.Parse(Console.ReadLine());
        }

        private void rectangle()
        {
            for(setNo2 = 1; setNo2 <= 5; setNo2++)
            {

                Console.WriteLine("{0}{1}{2}",setNo,setNo,setNo);
            }
        }

        public void solution()
        {
            getInput();
            rectangle();
        }
    }
}
