using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.GUI
{
    class GuiController
    {
       
        public GuiController()
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.Render();

            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();
        }
        
    }
}
