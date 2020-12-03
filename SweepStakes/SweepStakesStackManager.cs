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
        //Use an abstract methods from the ISweepstakes interface to create a method to add to the stack
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        //is is also another abstract method from the ISweekstakes interface, used to place the last item in the stack
        // and throws an exception if the stack is empty.
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
