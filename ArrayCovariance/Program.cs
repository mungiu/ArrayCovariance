using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCovariance
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] objArr = new object[3];
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };


            //implicitly casting an arr derived type to arr base type
            object[] objArr2 = daysOfWeek;
            objArr2[0] = 3;

            foreach (object obj in objArr2)
                Console.WriteLine(obj);
        }
    }
}
