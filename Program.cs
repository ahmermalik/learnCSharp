using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)  //this is the method name
        //name of parameter is 'args'
        //type of this param is a string array 'string[]'
        
        // write a function to take in 5 numbers and divide it to the length of the list to find average
        {


            /**list
            
             */

             /*working with number types  */
            double[] numbers = new double[3] { 1.5, 2.25, 3.75 }; // explicitly declaring how many values will be within our array of doubles and also placing the values within it.

            var numberSecond = new[] { 1.5, 2.25, 3.75 }; // same as above, just looks nicer.

            var result = 0.0;
           

            foreach(double number in numbers){
                result += number;
                Console.WriteLine(result);
            }
             var average = result / numbers.Length;
             Console.WriteLine( "Average is" ,average);

            int w = 5; // you cannot declare int and have a double or float value to it. only whole numbers.
            double x = 12.3;  // can represent fractional as well as whole values, can contain up to 15 digits in total, ncluding those before and after the decimal point.
            float y = 5;
            var sum = y+x+w +numbers[0];
            
            if (args.Length > 0 )
            {
            MyClass c1 = new MyClass();
            Console.WriteLine(sum);
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");
            Console.WriteLine("Hello " + args[0] + "!");
            Console.WriteLine($"Hello, {args[0]} !");
       
            }
            else{
                Console.WriteLine("There's nothing available.");
            }
             }
        // in order to run this project in console write
        // ' dotnet run Ahmer' and it'll pass Ahmer as the parameter.
        // if you write dotnet run --Ahmer, it will look for a project named Ahmer
    }
}