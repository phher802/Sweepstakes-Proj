using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm
    {
        ISweepstakesManager _manager;
        public Sweepstakes sweepstakes;

        //constructor
        //this constructor injection lets the marketing firm handle either the queueManager or StackManager, 
        //or anything that is a manager class
        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager; 
            
        }

        // method
        public void CreateSweepstake(string name)
        {
            sweepstakes = new Sweepstakes(name);
            
        }

    }
}
