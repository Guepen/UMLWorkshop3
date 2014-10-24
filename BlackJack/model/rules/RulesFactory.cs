using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class RulesFactory
    {
        public IHitStrategy GetHitRule()
        {
            return new SoftSeventeenStrategy();
            //return new BasicHitStrategy();
        }

        public IWinRule GetWinnerRule()
        {
            return new HardStrategy();
        }

        public IHitStrategy GetSoftSeventeenRule()
        {
            return new SoftSeventeenStrategy();
        }
        public INewGameStrategy GetNewGameRule()
        {
            return new AmericanNewGameStrategy();
        }
    }
}
