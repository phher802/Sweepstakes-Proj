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
        public static string GetUserName()
        {
            string fName = "";
            string lName = "";
            string fullName = "";

            UserInterface.GetUserInputFor("Enter your first name");
            fName = Console.ReadLine();
            UserInterface.GetUserInputFor("Enter your last name");
            lName = Console.ReadLine();
            fullName = fName + lName;

            return fullName;
            
            //UserInterface.GetUserInputFor("Enter your email address");
            //this.email = Console.ReadLine();
            //registrationNumber = ;
        }

        public static string GetEmail()
        {
            string email = "";

            UserInterface.GetUserInputFor("Enter your email address");
            email = Console.ReadLine();

            return email;

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

    public static void GetUniqueRegistrationNum()
    {
        
        List<int> UniqueKeys = new List<int>(Keys);
        List<int> previousKey = new List<int>(Keys);

        //foreach (KeyValuePair<int, Contestant> key in contestants)
        //{

        //    if (previousKey.Contains(key.Key))
        //    {
        //        continue;
        //    }
        //    else
        //    {
        //        UniqueKeys.Add(key.Key);
        //        previousKey.Add(key.Key);
        //    }
        //}

        int key = 1000;
        for (int i = 0; i < dict.Count; i++)
        {
            if (dict.Keys == null)
            {
                UniqueKeys.Add(key);
                previousKey.Add(key);
            }
            else if (previousKey.Contains(key))
            {
                continue;
            }
            else
            {
                UniqueKeys.Add(key + 1);
                previousKey.Add(key + 1);
            }
        }


        return key;
    }

}
