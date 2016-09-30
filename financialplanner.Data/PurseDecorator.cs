using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financialplanner.Data
{
    public class PurseDecorator : Purse
    {
        protected Purse DecoratedPurse { get; set; }

        public PurseDecorator(Purse purse)
        {
            DecoratedPurse = purse;
        }


        public override void Do()
        {
            DecoratedPurse.Do();
        }
    }
}
