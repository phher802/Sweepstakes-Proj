using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Sweepstakes
    {
        //member variables (has a)
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;

        //constructor (spawner)
        public Sweepstakes(string name)
        {
            this.name = Name;
        }



        // methods (can do)
        public void RegisterConstestant(Contestant contestant)
        {
            UserInterface.GetUserInputFor("Enter your first name");
            contestant.fName = Console.ReadLine();
            UserInterface.GetUserInputFor("Enter your last name");
            contestant.lName = Console.ReadLine();
            UserInterface.GetUserInputFor("Enter your email address");
            contestant.email = Console.ReadLine();



        }

        private int GenerateRegistrationNumber(int registrationNumber)
        {

        }

        public Contestant PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
