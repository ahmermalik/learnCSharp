using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)  //this is the method name
        {
            MyClass c1 = new MyClass();
            Console.WriteLine($"Hello World! {c1.ReturnMessage()}");
        }
    }
}