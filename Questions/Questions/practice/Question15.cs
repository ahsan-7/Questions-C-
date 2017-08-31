using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question15
    {
        private string setString { get; set; }
        private string setStringToRemove { get; set; }
        private string setStringRemove { get; set; }

        private void getInput()
        {
            Console.Write("Enter the string: ");
            setString = Console.ReadLine();
            Console.Write("Enter the char to remove: ");
            setStringToRemove = Console.ReadLine();
        }
        private void remove()
        {
            setStringRemove = setString.Replace(setStringToRemove, ""); 
            Console.WriteLine(setStringRemove);
        }

        public void solution()
        {
            getInput();
            remove();
        }
    }
}
