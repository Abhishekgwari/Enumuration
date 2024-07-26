using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumuration
{
    
        public enum Days 
        {
            Monday=1,Tuesday=11 , Wednesday=22, Thursday=33,Friday=44

        }
     class TestClass
    {
        public static Days MeetingDate
        {
            get; set;
        } = Days.Monday;
        static void Main()
        {
            Console.WriteLine(MeetingDate);

            MeetingDate = Days.Friday;
            Console.WriteLine(MeetingDate);
            Console.ReadLine();
        }
    }
}
