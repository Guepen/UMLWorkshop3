using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack.model.rules
{
    class HardStrategy : IWinRule
    {
        private const int g_maxScore = 21;
        public bool GetWinRule(model.Player a_dealer, model.Player a_player)
        {

            if (a_dealer.CalcScore() == a_player.CalcScore())
            {
                return true;
            }

            if (a_dealer.CalcScore() > a_player.CalcScore() && a_dealer.CalcScore() < 21)
            {
                return true;
            }

            if (a_dealer.CalcScore() > g_maxScore)
            {
                return false;
            }
            else if (a_dealer.CalcScore() == 21)
            {
                return true;
            }

            if (a_player.CalcScore() > g_maxScore)
            {
                return true;
            }
            else if (a_player.CalcScore() == 21)
            {
                return false;
            }

            return false;
          

        }
    }
}
