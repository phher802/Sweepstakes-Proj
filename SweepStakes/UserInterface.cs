using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SweepStakes
{
    static class UserInterface
    {
        //member variable (has a)

        // constructor (spawner)

        // methods (can do)
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
