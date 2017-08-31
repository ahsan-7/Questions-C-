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
        private int setNo3 { get; set; }
        private int setRows { get; set; }
        private int setColums { get; set; }

        private void getInput()
        {
            Console.Write("Enter the no: ");
            setNo = int.Parse(Console.ReadLine());
            Console.Write("Enter the no of Rows: ");
            setRows = int.Parse(Console.ReadLine());
            Console.Write("Enter the no of colums: ");
            setColums = int.Parse(Console.ReadLine());
        }

        private void rectangle()
        {
            for(setNo2 = 1; setNo2 <= setRows; setNo2++)
            {
                for (setNo3 = 1; setNo3 <= setColums; setNo3++)
                {
                    Console.Write(setNo);
                }
                Console.WriteLine("");
            }
        }

        public void solution()
        {
            getInput();
            rectangle();
        }
    }
}
