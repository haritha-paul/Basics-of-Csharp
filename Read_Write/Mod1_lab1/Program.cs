using System;

namespace Mod1_lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            //initializing with a default value
            string firstname = "";
            string lastname = "";
            int age = 0;
            string street = "";
            string country = "";
            DateTime birthdate;

            //assigning some values

            firstname = "susan";
            lastname = "elizabeth";
            age = 21;
            street = "east india street";
            country = "russia";
            birthdate = new DateTime(1997, 1, 23);

            //output to console

            Console.Write(firstname);
            Console.Write(lastname);

            //using placeholder style

            Console.Write("{0} years old", age);
            Console.Write($"Born on {birthdate}");

            //using string interpolation

            Console.Write(street + "," + country);



         

        }
    }
}
