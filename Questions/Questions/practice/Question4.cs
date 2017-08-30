using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.practice
{
    class Question4
    {
        public void Solution4()
        {
            float a = -1;
            float b = 4;
            float c = 6;
            float Ops1 = a + b * c;
            Console.WriteLine(Ops1);
            float d = 35;
            float e = 5;
            float f = 7;
            float Ops2 = (d + e) % f;
            Console.WriteLine(Ops2);
            float g = 14;
            float h = -4;
            float i = 6;
            float j = 11;
            float Ops3 = g + h * i / j;
            Console.WriteLine(Ops3);
            float k = 2;
            float l = 15;
            float m = 6;
            float n = 1;
            float o = 7;
            float p = 2;
            float Ops4 = k + l / m * n - o % p;
            Console.WriteLine(Ops4);
        }
    }
}
