using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //member variable (has a)

        // constructor (spawner)

        // methods (can do)
        public static string GetUserFirstName()
        {
            string fName;

            UserInterface.GetUserInputFor("Enter your first name");
            fName = Console.ReadLine();

            return fName;

            //UserInterface.GetUserInputFor("Enter your email address");
            //this.email = Console.ReadLine();
            //registrationNumber = ;
        }

        public static string GetUserLastName()
        {
            string lName;
            UserInterface.GetUserInputFor("Enter your last name");
            lName = Console.ReadLine();
            return lName;
        }

        public static string GetEmail()
        {
            string email;

            UserInterface.GetUserInputFor("Enter your email address");
            email = Console.ReadLine();

            return email;
        }

        public static void PrintContestantInfo(Dictionary<int, Contestant> dict, Contestant contestant)
        {
            for (int i = 0; i < dict.Count; i++)
            {
                dict[i] = contestant;
                Console.WriteLine(contestant);
            }

        }

        public static String GetUserInputFor(string prompt)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string fName = "";
            string lName = "";

            Console.WriteLine(prompt);

            string input = Console.ReadLine();

            if ((prompt == fName) || (prompt == lName))
            {
                return (textInfo.ToTitleCase(input));
            }
            else
            {
                return input;
            }


        }

        //used interface injection here to implement the factory design pattern: let marketing firm choose which manager they want to use
        public static ISweepstakesManager ChooseAManager(string manager)
        {
            GetUserInputFor("Please chose either a stack manager or a queue manager.");
            manager = Console.ReadLine().ToLower();

            switch (manager)
            {
                case "stack":
                    return new SweepstakesStackManager();
                case "queue":
                    return new SweepstakesQueueManager();

                default:
                    Console.WriteLine("Invalid Input");
                    return ChooseAManager(manager);

            }

        }

        public static void NotifyWinner(Contestant email)
        {
            
            Console.WriteLine("\nCongratulations!! You've won the prize!!!!! ");
            Console.WriteLine("\nA separate email will be sent shortly with instructions on how to claim your prize.");

        }
    }



}
