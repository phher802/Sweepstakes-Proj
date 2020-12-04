using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        //member variables

        Sweepstakes _sweepstakes;
        Sweepstakes _name;
        Contestant _contestant;
        MarketingFirm _marketingFirm;
        Sweepstakes _manager;
        string manager;
        string name;


        //constructor
        public Simulation()
        {
            //_manager = new Sweepstakes(name);
          
        }
        


        //methods
        public void CreateMarketingFirmWithManager()
        {
            //1. choose a manager
            //2. create a new marketing firm
            //3. have marketing firm create a sweepstake
          
            _marketingFirm = new MarketingFirm(UserInterface.ChooseAManager(manager));
            _marketingFirm.CreateSweepstake("Maldive Trip");
            _marketingFirm.Update(_name); 



        }
    }
}
