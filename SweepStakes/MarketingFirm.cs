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

        //constructor
        //this constructor injection lets the marketing firm handle either the queueManager or StackManager, 
        //or anything that is a manager
        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager; 
            
        }

        // method
        public void CreateSweepstake(string name)
        {
            Sweepstakes sweepstakes = new Sweepstakes(name);

        }

    }
}
