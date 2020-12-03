using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {

        private Queue<Sweepstakes> queue;

        public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        //Use an abstract methods from the ISweepstakes interface to create a method to add to the queue
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        //is is also another abstract method from the ISweekstakes interface, used to remove the first item in the queue
        // and throws an exception if the queue is empty.
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes;

            if (queue.Count>0)
            {
                sweepstakes = queue.Dequeue();
                return sweepstakes;
            }

            throw new Exception("Queue is empty.");

        }


    }
}
