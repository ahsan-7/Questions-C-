using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question12
    {
        private int setNo { get; set; }
        private int setData { get; set; }

        private void getInput()
        {
            Console.WriteLine("Enter the no: ");
            setNo = int.Parse(Console.ReadLine());
        }

        private void function()
        {
            Console.WriteLine("{0} {1} {2} {3}",setNo,setNo,setNo,setNo);
            Console.WriteLine("{0}{1}{2}{3}",setNo,setNo,setNo,setNo);
        }

        public void solution()
        {
            getInput();
            function();
            function();
        }
    }
}
