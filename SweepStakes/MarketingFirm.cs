using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm
    {
        ISweepStakesManager _manager;

        //constructor
        //this constructor injection lets the marketing firm handle wither the queueManager or StackManager
        public MarketingFirm(ISweepStakesManager _manager)
        {
            this._manager = _manager; 

            
        }

        // method
        public void CreateSweepstake()
        {

        }

    }
}
