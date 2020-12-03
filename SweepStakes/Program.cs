using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("Maldive Trip");


            Contestant contestant = new Contestant();
            sweepstakes.RegisterContestant(contestant);


            
        }

        public void Run()
        {
            AddNumberToTen(int);
        }

        public void AddNumberToTen(int numb)
        {
            Console.WriteLine(numb + 10);
        }
    }
}
