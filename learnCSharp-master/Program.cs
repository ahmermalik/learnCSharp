﻿using System;
using System.Collections.Generic;
using GradeBook;
namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var book = new Book();
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11 };
            grades.Add(6.1);

            var result = 0.0;

            foreach(var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N4}");
    }
}

}