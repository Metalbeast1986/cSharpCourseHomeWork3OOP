using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.GUI
{
    class GuiController
    {
        private GameWindow gameWindow;
        private CreditWindow creditWindow;

        int index = 0;
        ConsoleKey key;

        public GuiController()
        {
            gameWindow = new GameWindow();
            creditWindow = new CreditWindow();

        }
       public void ShowMenu()
       {
            //Ar ShowMenu funkcijoi zemiau einantys elementai reikalingi?
           gameWindow.Render();
            //creditWindow.Render();

            //call out Select function to display all possible buttons
            Select(gameWindow.buttonList);
           // Active(Select(gameWindow.buttonList));
       }
        void Active(int index)
        {
            gameWindow.buttonList[index].SetActive();

        }
        void Select(List<Button> buttonList)
        {
            while (key != ConsoleKey.Enter)
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                    {
                        index --;
                        if (index <= 0)
                        {
                            index = buttonList.Count -1;

                        }
                        
                        //Console.WriteLine("left" + index);
                        //    Active(index);
                            break;
                    }
                    case ConsoleKey.RightArrow:
                    {
                        index ++;
                        if(index >= buttonList.Count)
                        {
                            index = 0;
                        }
                        
                       // Console.WriteLine("right" + index);
                         //   Active(index);
                            break;
                    }
                }

                Console.WriteLine("index "+index);
                Active(index);
                gameWindow.Render();
            }


          

           // return index;

            /*
            //on key press change index. by calling function
            if (ConsoleKey.LeftArrow) // if left arrow
            {
                if (index > 0 && index < buttonList.Count)
                {
                    index += index;
                }

                MessageBox.Show("Enter Key Pressed ");
            }
            if (e.KeyCode == Keys.Enter) // if right arrow
            {
                if (index > 0 && index <= buttonList.Count)
                {

                    index -= index;
                }

                MessageBox.Show("Enter Key Pressed ");
            }
            */
            //gameWindow.buttonList[index]
        }

        
    }
}
