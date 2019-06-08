using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog : Animal
    {
        public bool Faithful { get; set; }
        public override int NumberOfLegs
        {
            get { return NumberOfLegs; }
            set { NumberOfLegs = 4; }
        }

        public override bool Fed()
        {
            throw new NotImplementedException();
        }
        public override bool CanBeAPet()
        {
            var basePet = base.CanBeAPet();
            if (Faithful && basePet)
            { basePet = true; }
            return basePet;
        }
    }
}
