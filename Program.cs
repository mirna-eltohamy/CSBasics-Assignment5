using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    enum DayOfWeek
    {
        Saturday=1, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    enum Grade { A, B, C, D, F }
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

            #region Q2 : Student Grades Matrix
            //int[,] grades = new int[3,4];
            //int s1 = 0, s2 = 0, s3 = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter student {i+1} grades:");

            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"Enter subject {j+1} grade:");
            //        grades[i,j] =int.Parse(Console.ReadLine());
            //        switch (i)
            //        {
            //            case 0:
            //                s1 += grades[i, j];
            //                break;
            //            case 1:
            //                s2 += grades[i, j];
            //                break;
            //            case 2:
            //                s3 += grades[i, j];
            //                break;
            //        }
            //    }
            //    Console.WriteLine();

            //}

            //Console.WriteLine($"Average of student 1 grades= {(float)s1 / 4}");
            //Console.WriteLine($"Average of student 2 grades= {(float)s2 / 4}");
            //Console.WriteLine($"Average of student 3 grades= {(float)s3 / 4}");
            //Console.WriteLine($"Average of class grades= {(float)(s1 + s2 + s3) / 12}");

            #endregion

            //Part 3 - Methods

            #region Method: Q1
            //double Add(double a, double b) => a + b;
            //double Subtract(double a, double b) => a - b;
            //double Multiply(double a, double b) => a * b;
            //double Divide(double a, double b)
            //{
            //    if (b == 0)
            //    {
            //        Console.WriteLine("Error: Division by zero is not allowed.");
            //        return 0;
            //    }
            //    return a / b;
            //}

            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operation (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());

            //double result = 0;

            //switch (op)
            //{
            //    case '+': 
            //        result = Add(num1, num2); 
            //        break;
            //    case '-': 
            //        result = Subtract(num1, num2); 
            //        break;
            //    case '*': 
            //        result = Multiply(num1, num2); 
            //        break;
            //    case '/': 
            //        result = Divide(num1, num2); 
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation");
            //        return;
            //}
            //Console.WriteLine($"Result = {result}");
            #endregion

            #region Methods: Q2
            //void CalculateCircle(double r, out double a, out double c)
            //{
            //    a = Math.PI * r * r;
            //    c = 2 * Math.PI * r;
            //}

            //Console.Write("Enter circle radius: ");
            //double radius = double.Parse(Console.ReadLine());

            //CalculateCircle(radius, out double area, out double circumference);

            //Console.WriteLine($"Area = {area}");
            //Console.WriteLine($"Circumference = {circumference}");
            #endregion

            //mini Student Grade Manager 
            #region Mini Student Grade Manager 

            //const int numStudents = 5;
            //int[] scores = new int[numStudents];

            //Grade GetGrade(int score)
            //{
            //    if (score >= 90) return Grade.A;
            //    else if (score >= 80) return Grade.B;
            //    else if (score >= 70) return Grade.C;
            //    else if (score >= 60) return Grade.D;
            //    else return Grade.F;
            //}

            //double CalculateAverage(int[] arr)
            //{
            //    int sum = 0;
            //    foreach (int score in arr)
            //        sum += score;
            //    return (double)sum / arr.Length;
            //}

            //void GetMinMax(int[] arr, out int min, out int max)
            //{
            //    min = arr[0];
            //    max = arr[0];

            //    foreach (int score in arr)
            //    {
            //        if (score < min) min = score;
            //        if (score > max) max = score;
            //    }
            //}

            
            //for (int i = 0; i < numStudents; i++)
            //{
            //    Console.Write($"Enter score for student {i + 1}: ");
            //    scores[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\n----Report----");
            
            //for (int i = 0; i < numStudents; i++)
            //{
            //    Grade grade = GetGrade(scores[i]);
            //    Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {grade}");
            //}

            //double average = CalculateAverage(scores);

            //GetMinMax(scores, out int minScore, out int maxScore);

            //Console.WriteLine($"\nClass average = {(double)average}");
            //Console.WriteLine($"Class minimum score = {minScore}");
            //Console.WriteLine($"Class maximum score = {maxScore}");
            
            #endregion

            Console.ReadKey();

        }
    }
}
