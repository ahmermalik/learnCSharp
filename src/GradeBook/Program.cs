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
            book.AddGrade(90);
            book.AddGrade(66.4);
            book.GetStatistics();
            
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {stats.Low}"); 
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N4}");

           
    }
}
}