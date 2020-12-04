using System;
                                        
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   public class Sweepstakes
    {
        //member variables (has a)
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;
        private Random random;

        //constructor (spawner)
        public Sweepstakes(string Name)
        {
            this.name = Name;
            //name = Name;

            contestants = new Dictionary<int, Contestant>();
        }



        // methods (can do)
        public void RegisterContestant(Contestant contestant)
        {

            contestant.registrationNumber = contestants.Count;
       
            contestants.Add(contestant.registrationNumber, contestant);

         
            //??need to validate information - display and ask user to verify that information is correct
            //?? if not, prompt again
         
        }

        
        public Contestant PickWinner()
        {
            //bool isWinner = false;
            Random rand = new Random();

            //List<int> keyList = new List<int>(contestants.Keys);
            List<Contestant> valueList = new List<Contestant>(contestants.Values);

            Contestant winner = valueList[rand.Next(valueList.Count)];

            return winner;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            UserInterface.PrintContestantInfo(contestants, contestant);

        }
    }
}
