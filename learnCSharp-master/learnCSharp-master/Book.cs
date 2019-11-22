using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)   // constructor method pass in types that this object should consume
        {
            grades = new List<double>();
            this.name = name;

        }
        public void AddGrade(double grade)   // add grade is an instance member of the class book.
        {
            grades.Add(grade);
        }
       private  List<double> grades;  // this is how you initialize grades (1st approach) aka access modifier publc or private
       private string name;     //this is an instance field
    }
}