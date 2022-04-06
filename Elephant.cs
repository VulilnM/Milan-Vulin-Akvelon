using System;
using System.Collections.Generic;
using System.Text;

namespace Two_Classes_One_Interface
{
    class Elephant : IHeart
    {
        public string HeartBeatRatePerMinut()
        {
            return "25-35";
        }
    }
}
