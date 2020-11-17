using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_week_one
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables that hold your first name, last name, and age
            //Declare and initialize an array that holds  a collection of at least four of your favorite book or movie titles
            //Make a list to hold dates.Include on that list the current date and time.
            //Write out to the Console the values calculated by your age variable and the number 7.Use each operator we covered in Operators
            //Example: If you are 29, you would need to add 7 to your age variable and then write out the calculated value to the Console.
            //Write out a collection of conditionals that evaluates a new variable for how many hours of sleep the user gets.
            //You can just initialize this variable for now, it does not have to be actually given by a user.
            //If the hours slept is greater or equal to 10, write to the console "Wow that's a lot of sleep!"
            //If the hours is greater than 8 but less than 10, write to the console "You should be pretty rested"
            //If the hours is greater than 4 but less than 8, output "Bummer"
            //For any other condition output "Oh man, get some sleep!"
            //Write out a switch case that evaluates a variable that holds the value for how the user's day has been.
            //Have a case for: "Great", "Good", "Okay", "Bad", ":(" and output a response to the Console for each.

            string firstName = "Shane";
            Console.WriteLine(firstName);

            string lastName = "Wilkinson";
            Console.WriteLine(lastName);

            int age = 34;
            Console.WriteLine(age);

            string[] booksArray = { "Blessed and unstoppable", "The beast with in", "Thank and grow rich", "The bible" };
            Console.WriteLine(booksArray[0]);
            DateTime currentDateTime = DateTime.Now; 
            List<DateTime> dateAndTime = new List<DateTime>();
            dateAndTime.Add(currentDateTime);
            Console.WriteLine(currentDateTime);

            age = 34;
            int num = 7;

            int sum = age + num;
            int diff = age - num;
            int prod = age * num;
            int quot = age / num;
            int remainder = age % num;
            Console.WriteLine(age + num);
            Console.WriteLine(age - num);
            Console.WriteLine(age * num);
            Console.WriteLine(age / num);
            Console.WriteLine(age % num);
            int hoursOfSleep = 5;
            if (hoursOfSleep >= 10) { Console.WriteLine("wow thats a lot of sleep"); };

            if (hoursOfSleep > 8 && hoursOfSleep < 10)
            { Console.WriteLine("you should be pretty rested"); }

            else if (hoursOfSleep > 4 && hoursOfSleep < 8)
            {
                Console.WriteLine("bummer!");
            }

            else { Console.WriteLine("Oh man, get some sleep!"); }

            string name = "good";
            switch (name)
            {
                case "great":
                    Console.WriteLine("Thats awsome, me too!");
                    break;
                case "good":
                    Console.WriteLine("glad to hear it.");
                    break;
                case "okay":
                    Console.WriteLine("keep your head up.");
                    break;
                case "bad":
                    Console.WriteLine("Thangs will get better soon, I promice.");
                    break;
                        
            }
            

            
            
           
            
            
            
            
            
            
            
            Console.ReadLine();

        }
    }
}
