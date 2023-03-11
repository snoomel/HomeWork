using System;

namespace Lesson1;
public class Program
{ 
    public static void Main(string[] args)
    {
        string MyName;
        Console.WriteLine("Введите свое имя");
        MyName = Console.ReadLine();
        if (MyName != "")
            Console.WriteLine("Hello, " + MyName);
        else
            Console.WriteLine("Hello, друг");
    }
    
}