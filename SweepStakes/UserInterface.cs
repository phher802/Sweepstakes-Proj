using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
   static class UserInterface
    {
        public static void GetUserInfo(string fName, string lName, string email)
        {
            OutputText("Please enter your first name");
            fName = Console.ReadLine();
            OutputText("Please enter your last name");
            lName = Console.ReadLine();
            OutputText("Please enter an email address");
            email = Console.ReadLine();

            //need to assign a registration number
        }

        public static void GetRegistrationNumber(int number)
        {

        }
         public static void OutputText(string output)
        {
            Console.WriteLine(output);
        }
    }
}
