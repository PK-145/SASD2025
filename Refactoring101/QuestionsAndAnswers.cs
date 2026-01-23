using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101
{
    // Do Refactoring the following code:
    public class QuestionsAndAnswers
    {
        // 1. Mysterious Name
        public double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        // 2. Duplicate Code
        public class DuplicateCode
        {
            public void PrintName(string title, string name)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("   " + title + "." + name);
                Console.WriteLine("***********************");
                Console.WriteLine();
            }
            public void Print()
            {
                PrintName("Mr", "Harry Potter");
                PrintName("Ms", "Mary Poppin");
                PrintName("Mr", "Johny Black");
            }
        }

        // 3. Shotgun Surgery
        public class Constant
        {
            public const int StudentCount = 48;
        }
        public class Shotgun1
        {
            
            public void DisplayStudents()
            {
                Console.WriteLine("Student Count = " + Constant.StudentCount);
            }
        }
        public class Shotgun2
        {
            public void PrintTotal()
            {
                Console.WriteLine("Total Students : " + Constant.StudentCount);
            }
        }

        // 4. Data Clump
        //public void PrintDate(Date date)
        //{
        //    Console.WriteLine($"{date.Day:00}/{date.Month:00}/{date.Year:0000}");
        //}
        public void PrintDate(Date date)
        {
            Console.WriteLine(date.Format());
        }
        public class Date
        {
            public required int Day { get; set; }
            public required int Month { get; set; }
            public required int Year { get; set; }
            public string Format()
            {
                return $"{Day:00}/{Month:00}/{Year:0000}";
            }
        }

        // 5. Feature Envy
        //     จากข้อที่แล้ว น่าจะได้สร้างคลาส Date ขึ้นมา
        //     ในคลาส Date นั้นให้สร้าง method: public string Format()
        //      ปรับให้ PrintDate(...) ของเดิม ไปเรียก date.Format() ดังกล่าว
        //public void PrintDateImprove(Date date)
        //{
        //    Console.WriteLine(date.Format());
        //}
    }
}
