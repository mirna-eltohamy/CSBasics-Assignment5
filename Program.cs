using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    enum DayOfWeek
    {
        Saturday=1, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Part 1 - Enums - enum defined in ns

            #region Q1
            //while (true)
            //{
            //    Console.Write("Enter day number (1–7): ");
            //    DayOfWeek day;
            //    day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            //    //Enum.Parse returns an object so cast to DayOfWeek

            //    switch (day)
            //    {
            //        case DayOfWeek.Saturday:
            //        case DayOfWeek.Friday:
            //            Console.WriteLine("It's a weekend ");
            //            break;
            //        case DayOfWeek.Sunday:
            //        case DayOfWeek.Monday:
            //        case DayOfWeek.Tuesday:
            //        case DayOfWeek.Wednesday:
            //        case DayOfWeek.Thursday:
            //            Console.WriteLine("It's a workday ");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Day! Try again.");
            //            break;
            //    }
            //}
            #endregion




            Console.ReadKey();

        }
    }
}
