using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant : IUser
    {
        // member variables (has a)
        private string _fName;
        private string _lName;
        private string _email;
        private int _registrationNumber;
        public string fName { get => _fName; set => _fName = value; }
        public string lName { get => _lName; set => _lName = value; }
        public string email { get => _email; set => _email = value; }
        public int registrationNumber { get => _registrationNumber; }

        // constructor (spawner)
        public Contestant()
        {

        }


        // methods (can do)



    }
}
