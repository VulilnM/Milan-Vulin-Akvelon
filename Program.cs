using System;

namespace Two_Classes_One_Interface
{
    class Program
    {

        public static void printHeartRates(Rabit rbt, Elephant elphnt) {
            Console.WriteLine("Rabits heart rate is {0} beats per minut on average.", rbt.HeartBeatRatePerMinute());
            Console.WriteLine("Elephants heart rate is {0} beats per minut on average.", elphnt.HeartBeatRatePerMinute());
        }

        static void Main(string[] args)
        {
            Rabit rbt = new Rabit();
            Elephant elphnt = new Elephant();
            printHeartRates(rbt, elphnt);
        }
    }
}
