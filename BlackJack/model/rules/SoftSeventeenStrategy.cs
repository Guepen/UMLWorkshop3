using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class SoftSeventeenStrategy: IHitStrategy
    {
        private const int g_hitLimit = 17;
        public bool DoHit(model.Player a_dealer)
        {
            if (a_dealer.CalcScore() == 17)
            {
                foreach (Card c in a_dealer.GetHand())
                {
                    if (c.GetValue() == Card.Value.Ace && a_dealer.CalcScore() == 17)
                    {
                        return true;
                    }
                }
            }

            if (a_dealer.CalcScore() >= g_hitLimit) 
            {
                return false;
            }

            if (a_dealer.CalcScore() < g_hitLimit || a_dealer.CalcScore() < 21)
            {
                return true;
            }

       
            return false;
        }
    }
}
