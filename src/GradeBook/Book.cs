using System.Collections.Generic;
using System;


namespace GradeBook
{
    public class Book
    {
        public Book(string name)   // constructor method pass in types that this object should consume
        {
            grades = new List<double>();
            Name = name;

            // if your name class was private it would be this.name = name, because c# cannot determine the difference between name and name, so you must reference it with 'this'

        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics(){   // return an object type Statistics
            var result = new Statistics();

            result.Average = 0.0;
            result.High = double.MinValue; // automatically sets the smallest number
            result.Low = double.MaxValue;

            foreach(var grade in grades)
            {
                result.High = Math.Max(grade,result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
                Console.WriteLine(result + " a number");
            }
            result.Average /= grades.Count; // how to obtain the average
            
            return result;
        }
       private  List<double> grades;  // this is how you initialize grades (1st approach) aka access modifier
       public string Name;
    }
}
