using System;

namespace HelloWorld
{
    class Program
    {
        static void Main ( string[] args )
        {
            //movie data
            //declare variables
            string title, description;
            int runLength, releaseYear;
            bool haveSeen;

            //Build out a menu that allows users to ...
            //creating display menu function
            while(true)
            { char input = DisplayMenu ();
                //determine which option users selected
                if (input == 'A')
                    AddMovie ();
                else if (input =='Q')
                    break;
            };      
        }

        //new function
        static void AddMovie ()
        {
            //get title
            //get description
            //get release year
            //get run length
            //get have seen

            //function to prompt users to input the above data

        }

        //delcare
        static char DisplayMenu ()
        {
            do
            {
                Console.WriteLine ("A)dd Movie");

                //menu for quit
                Console.WriteLine ("Q)uit");

                //read input from user
                //how program reads input data
                //() returns a string
                string input = Console.ReadLine ();
                //use if-statement
                //case sensitivity, using logic
                if (input == "A" || input =="a")
                {
                    return 'A';

                } else if (input == "Q" || input == "q")
                {
                    return 'Q';
                }//else is optional
                else

                {
                    Console.WriteLine ("Inalid input");
                }


            } while (true);
                
        }

        //below code has been moved from the main function
        private static void DemoLanguage ()
        {
            Console.WriteLine ("Hello World!!!!");
            //only use multi-line comment for the header on top of the program
            //valid
            string name;

            //invalid 
            //string name2 = name;

            //needs to assign a value first, before reading
            //initialize variables first
            name = "Bob";
            string name2 = name;

            //trying calling fuction, passing it a name of varaible
            Console.WriteLine (name2);

            //only use multi-line comment for the header on top of the program
            name = "Bob";
            
            name2 = Console.ReadLine ();
            Console.WriteLine (name2);

            Console.WriteLine ("Hello World!!!!");
            //only use multi-line comment for the header on top of the program

            int hours = 8;
            double payRate = 15.25;


            //combine
            double totalPay = payRate * hours;
            string fullName = "Fred" + "Jones";
        }
    }
}
