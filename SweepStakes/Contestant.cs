using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        // member variables (has a)
        public string fName;
        public string lName;
        public string email;
        public int registrationNumber;


        // constructor (spawner)
        public Contestant()
        {
            fName = UserInterface.GetUserFirstName();
            lName = UserInterface.GetUserLastName();
            email = UserInterface.GetEmail();
            //registrationNumber = UserInterface.GetUniqueRegistrationNum(contestants);   
            //need to validate that email is entered correctly??
        }


    }

    
}
