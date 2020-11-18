using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Week_2_Challenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void Main()
        {
            Greeter hello = new Greeter();
            hello.Hello("Tanner");
            hello.Bye("Tanner");
            hello.GreetingBasedOnTime("Tanner");
        }
    }

    public class Greeter
    {
        public string Hello(string name)
        {
            Console.WriteLine("Hello " + name);
            return "Hello" + name;
        }

        public string Bye(string name)
        {
            Console.WriteLine("See ya later " + name);
            return "See ya later " + name;
        }

        public string GreetingBasedOnTime(string name)
        {
            DateTime now = DateTime.Now;
            TimeSpan nowTimeSpan = now.TimeOfDay;

            TimeSpan endOfMorning = new DateTime(2020, 11, 17, 11, 59, 0).TimeOfDay;
            TimeSpan endOfAfternoon = new DateTime(2020, 11, 17, 15, 59, 0).TimeOfDay;
            TimeSpan endOfEvening = new DateTime(2020, 11, 17, 19, 59, 0).TimeOfDay;
            TimeSpan endOfNight = new DateTime(2020, 11, 17, 3, 59, 0).TimeOfDay;


            if (nowTimeSpan <= endOfNight || nowTimeSpan > endOfEvening)
            {
                Console.WriteLine("Good Night, " + name + "!");
                return "Good Night, " + name + "!";
            }
            else if (nowTimeSpan <= endOfMorning)
            {
                Console.WriteLine("Good Morning, " + name + "!");
                return "Good Morning, " + name + "!";
            }
            else if (nowTimeSpan <= endOfAfternoon)
            {
                Console.WriteLine("Good Afternoon, " + name + "!");
                return "Good Afternoon, " + name + "!";
            }
            else
            {
                Console.WriteLine("Good Evening, " + name + "!");
                return "Good Evening, " + name + "!";
            }
        }
    }
}