using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question11
    {
        private int setAge { get; set; }

        private void getInput()
        {
            Console.Write("Enter your age: ");
            setAge = int.Parse(Console.ReadLine());
        }

        private void message()
        {
            Console.WriteLine("You look older than {0}.",setAge);
        }

        public void solution()
        {
            getInput();
            message();
        }
    }
}
