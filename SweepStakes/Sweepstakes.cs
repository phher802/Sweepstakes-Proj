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
        private Random random;

        //constructor (spawner)
        public Sweepstakes(string name)
        {
            this.name = name;
            name = Name;

            Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        }



        // methods (can do)
        public void RegisterContestant(Contestant contestant)
        {
        
            UserInterface.GetUserInputFor("Enter your first name");
            contestant.fName = Console.ReadLine();
            UserInterface.GetUserInputFor("Enter your last name");
            contestant.lName = Console.ReadLine();
            UserInterface.GetUserInputFor("Enter your email address");
            contestant.email = Console.ReadLine();

            


            //need to assign registration number
            //need to validate information - display and ask user to verify that information is correct
            // if not, prompt again
            //need to validate that email is entered correctly
        }

        private int GenerateRegistrationNumber()
        {
            List<int> keyList = new List<int>(contestants.Keys);

        }


        public Contestant PickWinner()
        {
            //bool isWinner = false;
            Random rand = new Random();

            //List<int> keyList = new List<int>(contestants.Keys);
            List<Contestant> valueList = new List<Contestant>(contestants.Values);

            Contestant randomKey = valueList[rand.Next(valueList.Count)];
            return randomKey;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
         
            //foreach (KeyValuePair<int, Contestant> kvp in contestants)
            //{
                
            //    Console.WriteLine = ($"Registration Number = {0}, Contestant = {1}", kvp.Key, kvp.Value);
            //}

            for (int i = 0; i < contestants.Count; i++)
            {
                Console.WriteLine(contestant);
            }
        }
    }
}
