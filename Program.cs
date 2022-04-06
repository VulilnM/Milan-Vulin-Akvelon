using System;

namespace Ref_vs_Vall_Passing
{
    class Program
    {
        private static void ChangeValue(int val)
        {
            val = val + 1;
            Console.WriteLine("Value while in the method: " + val);
        }

        static void Main(string[] args)
        {
            // Value Type
            // =====================================================================
            int value = 1;

            Console.Write("Value before the changing method: {0}\n", value);
            
            ChangeValue(value);

            Console.Write("Value after the changing method: {0}\n\n", value);

        }
    }
}
