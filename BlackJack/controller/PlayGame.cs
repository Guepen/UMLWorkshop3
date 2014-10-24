using BlackJack.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BlackJack.model;

namespace BlackJack.controller
{
    class PlayGame : NewCardListener
    {
        private view.IView m_view;
        private model.Game m_game;
        
        public bool Play(model.Game a_game, view.IView a_view)
        {
            a_game.RegisterNewCardListener(this);
           
            this.m_game = a_game;
            this.m_view = a_view;
            NewCardListener();
           
          

            if (a_game.IsGameOver())
            {
                a_view.DisplayGameOver(a_game.IsDealerWinner());
            }

            switch (a_view.GetInput())
            {
                case Event.StartNewRound:
                    a_game.NewGame();
                    break;

                case Event.Hit:
                    a_game.Hit();
                    break;

                case Event.Stand:
                    a_game.Stand();
                    break;

                case Event.Quit:
                    return false;

            }
            return true;
     
        }

        public void NewCardListener() 
        {
            this.m_view.DisplayWelcomeMessage();
          
            this.m_view.DisplayDealerHand(this.m_game.GetDealerHand(), this.m_game.GetDealerScore());
            this.m_view.DisplayPlayerHand(this.m_game.GetPlayerHand(), this.m_game.GetPlayerScore());
            Thread.Sleep(1000);
        }
    }
}
