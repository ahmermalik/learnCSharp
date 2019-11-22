using System;
using System.Collections.Generic;
using GradeBook;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book("Ahmer's Grade Book"); // this is how you initialize grades (2nd approach)
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 50 };
            grades.Add(6.1);

            var result = 0.0;
            var highGrade = double.MinValue; // automatically sets the smallest number
            Console.WriteLine(highGrade + "is the beg min number");


            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                result += number;
                Console.WriteLine(result + " a number");
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N4}");
            // Console.WriteLine(""); 
    }
}
}