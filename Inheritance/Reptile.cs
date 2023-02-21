using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {

        }

        public string Color { get; set; }
        public string LandOrWater { get; set; }
        public bool CanRegenTail { get; set; }
        public string LocatedIn { get; set; }
    }
}
