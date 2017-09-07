using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Questions.practice;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuesNo;
            Console.Write("Enter Question No: ");
            QuesNo = int.Parse(Console.ReadLine());
            switch (QuesNo)
            {
                case (1):
                    Question1 solu = new Question1();
                    solu.solution();
                    break;
                case (2):
                    Question2 solu2 = new Question2();
                    solu2.solution();
                    break;
                case (3):
                    Question3 solu3 = new Question3();
                    solu3.solution();
                    break;
                case (4):
                    Question4 solu4 = new Question4();
                    solu4.solution();
                    break;
                case (5):
                    Question5 solu5 = new Question5();
                    solu5.solution();
                    break;
                case (6):
                    Question6 solu6 = new Question6();
                    solu6.solution();
                    break;
                case (7):
                    Question7 solu7 = new Question7();
                    solu7.solution();
                    break;
                case (8):
                    Question8 solu8 = new Question8();
                    solu8.solution();
                    break;
                case (9):
                    Question9 solu9 = new Question9();
                    solu9.solution();
                    break;
                case (10):
                    Question10 solu10 = new Question10();
                    solu10.solution();
                    break;
                case (11):
                    Question11 solu11 = new Question11();
                    solu11.solution();
                    break;
                case (12):
                    Question12 solu12 = new Question12();
                    solu12.solution();
                    break;
                case (13):
                    Question13 solu13 = new Question13();
                    solu13.solution();
                    break;
                case (15):
                    Question15 solu15 = new Question15();
                    solu15.solution();
                    break;
                case (16):
                    Question16 solu16 = new Question16();
                    solu16.solution();
                    break;
                case (17):
                    Question17 solu17 = new Question17();
                    solu17.solution();
                    break;
                case (18):
                    Question18 solu18 = new Question18();
                    solu18.solution();
                    break;
                case (19):
                    Question19 solu19 = new Question19();
                    solu19.solution();
                    break;
                case (20):
                    Question20 solu20 = new Question20();
                    solu20.solution();
                    break;
                case (21):
                    Question21 solu21 = new Question21();
                    solu21.solution();
                    break;
                case (22):
                    Question22 solu22 = new Question22();
                    solu22.solution();
                    break;
                case (23):
                    Question23 solu23 = new Question23();
                    solu23.solution();
                    break;
                case (24):
                    Question24 solu24 = new Question24();
                    solu24.solution();
                    break;
                case (25):
                    Question25 solu25 = new Question25();
                    solu25.solution();
                    break;
                case (26):
                    Question26 solu26 = new Question26();
                    solu26.solution();
                    break;
                case (27):
                    Question27 solu27 = new Question27();
                    solu27.solution();
                    break;
                case (28):
                    Question28 solu28 = new Question28();
                    solu28.solution();
                    break;
                case (31):
                    Question31 solu31 = new Question31();
                    solu31.solution();
                    break;
                case (32):
                    Question32 solu32 = new Question32();
                    solu32.solution();
                    break;
                case (33):
                    Question33 solu33 = new Question33();
                    solu33.solution();
                    break;
                case (34):
                    Question34 solu34 = new Question34();
                    solu34.solution();
                    break;
                case (35):
                    Question35 solu35 = new Question35();
                    solu35.solution();
                    break;
                case (36):
                    Question36 solu36 = new Question36();
                    solu36.solution();
                    break;
                case (37):
                    Question37 solu37 = new Question37();
                    solu37.solution();
                    break;
                case (38):
                    Question38 solu38 = new Question38();
                    solu38.solution();
                    break;
                case (39):
                    Question39 solu39 = new Question39();
                    solu39.solution();
                    break;
                case (40):
                    Question40 solu40 = new Question40();
                    solu40.solution();
                    break;
                case (41):
                    Question41 solu41 = new Question41();
                    solu41.solution();
                    break;
                case (42):
                    Question42 solu42 = new Question42();
                    solu42.solution();
                    break;
                case (43):
                    Question43 solu43 = new Question43();
                    solu43.solution();
                    break;
                case (44):
                    Question44 solu44 = new Question44();
                    solu44.solution();
                    break;
                case (45):
                    Question45 solu45 = new Question45();
                    solu45.solution();
                    break;
                case (46):
                    Question46 solu46 = new Question46();
                    solu46.solution();
                    break;
                case (47):
                    Question47 solu47 = new Question47();
                    solu47.solution();
                    break;
                case (48):
                    Question48 solu48 = new Question48();
                    solu48.solution();
                    break;
                case (49):
                    Question49 solu49 = new Question49();
                    solu49.solution();
                    break;
                default:
                    Console.WriteLine("Please Input a Valid No.");
                    break;
            }
        }
    }
}
