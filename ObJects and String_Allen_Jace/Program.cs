using ObJects_and_String_Allen_Jace;
using System;

namespace Objects_Allen_Jace
{
    class Program
    {
        static void Main(string[] args)
        {
            //My computer apple and all-in-one is true
            Computer myComputer = new Computer("Apple", "All-in-One", true);
            IBootUP myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));
            //My other computer apple and all-in-one is true
            Computer myOtherComputer = new Computer("Apple", "All-in-One", true);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString = myComputer.ToString();
            string myOtherString = myString;

            myString = "Hi!";

            Console.WriteLine(myOtherString);

            // My computer equals my other computer
            Console.WriteLine(myString.Equals(myComputer));
            Console.WriteLine(myString.Equals(myOtherComputer));

            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());
            //My other computer power on and off
            myOtherComputer.PowerOnOff();
            
            Console.WriteLine(myString == myOtherComputer.ToString());
            Console.WriteLine(myString);
            Console.WriteLine(myOtherComputer.ToString());

            Console.WriteLine(myString.Contains('i'));

            Console.WriteLine(myString.ToUpper());


        }
    }
}
