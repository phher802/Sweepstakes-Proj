using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables (has a)
        private Stack<Sweepstakes> stack;

        // constructor (spawner)
        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        // method (can do)
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
          
            Sweepstakes sweepstakes;

            if (stack.Count > 0)
            {
                sweepstakes = stack.Pop();
                return sweepstakes;
            }

            throw new Exception("Stack is Empty.");
        }

    }
}
