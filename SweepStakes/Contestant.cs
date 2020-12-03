using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Contestant
    {
        // member variables (has a)
        public string fName;
        public string lName;
        public string email;
        public int registrationNumber;


        // constructor (spawner)
        public Contestant(string fName, string lName, string email, int registrationNumber)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.registrationNumber = registrationNumber;

        }


        // methods (can do)

    }

    
}
