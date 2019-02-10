using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_class_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an object of type human
            Human human1 = new Human();
            
            //populating objects with varibles
            Console.WriteLine("Enter First Name ");
            human1.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name ");
            human1.LastName = Console.ReadLine();

            Console.WriteLine("Enter age ");
            human1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height ");
            string height = Console.ReadLine();
            human1.Height = Double.Parse(height);

            Console.WriteLine("Enter Hair Colour ");
            human1.HairColour = Console.ReadLine();

            Console.WriteLine("Enter Weight ");
            human1.Weight = double.Parse(Console.ReadLine());

            Console.WriteLine($"Full Name: {}");

            Console.ReadLine();
            Console.WriteLine(fULLName. "+human1.FirstName");
        }
        //Console.Writeline(FullName: "+ human1.FullName);
        Like 
        Console.ReadLine();

    }
}



Human Eve= new Human("Eve", "Le'Chaim")
    Console.WriteLine("Eve.FullName"));
    //Like System Pause
    Console.ReadLine();
