using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Classes_One_Interface
{
    class Rabit : IHeart
    {
        public string HeartBeatRatePerMinute()
        {
            return "180-350";
        }
    }
}
