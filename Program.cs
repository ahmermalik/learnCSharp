﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)  //this is the method name
        //name of parameter is 'args'
        //type of this param is a string array 'string[]'
        
        
        {
            int w = 5; // you cannot declare int and have a double or float value to it. only whole numbers.
            double x = 12.3;  // can represent fractional as well as whole values, can contain up to 15 digits in total, ncluding those before and after the decimal point.
            float y = 5;
            var sum = y+x+w;

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