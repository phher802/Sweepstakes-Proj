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
