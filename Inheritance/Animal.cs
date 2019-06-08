using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //letes make it abstact class
    public abstract class Animal
    {
        public abstract int NumberOfLegs { get; set; }
        public bool Run { get; set; }
        public bool Pet { get; set; }
        public float Weight { get; set; }

        public virtual bool CanBeAPet()
        {
            var isPet = false;
            if(Weight<40 && Pet)
            {
                isPet = true;
            }
            return isPet;
        }

        public abstract bool Fed();
    }
}
