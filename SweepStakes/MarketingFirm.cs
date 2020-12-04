using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager _manager;
        public Sweepstakes sweepstakes;
        //string name;
        Contestant contestant;


        //constructor
        //this constructor injection will let the marketing firm handle either the queueManager or StackManager, 
        //or anything that is a manager class
        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager; 
            
        }

        // method
        public void CreateSweepstake(string name)
        {
            //1. create name
            //2. add contestants
            //3. print contestant info
            //4. pick a winner
          
            sweepstakes = new Sweepstakes(name);
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.PrintContestantInfo(contestant);
            sweepstakes.PickWinner();
            
        }
        //7. contact winner
        //8. send mailkit API to winner
        //9. announce the winner too all contestants
    }
}
