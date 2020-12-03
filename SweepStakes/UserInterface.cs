using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SweepStakes
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

       public static void PrintContestantInfo(Dictionary<int, Contestant> dict)
        {     
    
            foreach (KeyValuePair<int, Contestant> kvp in dict)
            {
                Console.WriteLine(kvp.Key.ToString(), kvp.Value);
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

            if ((prompt == fName) || (prompt == lName) )
            {
                return (textInfo.ToTitleCase(input));
            }
            else
            {
                return input;
            }

          
            //Console.WriteLine(textInfo.ToTitleCase(input));
            //return (textInfo.ToTitleCase(input));
        }

        
    }

 

}
