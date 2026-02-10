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

            //Part 2 - Arrays

            #region Q1:Array Statistics
            //Console.Write("Enter array size: ");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            //int sum = 0;
            //float avg ;
            //int max = 0;
            //int min = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write
            //        ($"Enter element number {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());

            //    sum += arr[i];
            //    if (i == 0) { 
            //        min = arr[i];
            //        max = arr[i];
            //    }

            //    if (arr[i] < min)
            //        min = arr[i];
            //    if (arr[i] > max)
            //        max = arr[i];

            //}

            //avg = (float)sum / size;
            //Console.WriteLine($"Sum= {sum}");
            //Console.WriteLine($"Average= {avg} ");
            //Console.WriteLine($"Minimum= {min} ");
            //Console.WriteLine($"Maximum= {max} ");

            //Console.Write("Reverse Array=");
            //for (int i = size-1; i>=0; i--)
            //{
            //    if(i!=0)
            //        Console.Write($"{arr[i]}, ");
            //    else
            //        Console.Write($"{arr[i]} ");

            //}
            #endregion



            Console.ReadKey();

        }
    }
}
