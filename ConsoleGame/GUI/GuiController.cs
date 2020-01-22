using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.GUI
{
    class GuiController
    {
        private GameWindow gameWindow;
        private CreditWindow creditWindow;

        public GuiController()
        {
            gameWindow = new GameWindow();

            creditWindow = new CreditWindow();

        }
       public void ShowMenu()
       {
            gameWindow.Render();
            creditWindow.Render();
       }
        
    }
}
