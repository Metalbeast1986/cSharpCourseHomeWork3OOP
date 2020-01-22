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
            Active(Select(gameWindow.buttonList));
       }
        void Active(int index)
        {
            gameWindow.buttonList[index].SetActive();
        }
        int Select(List<Button> buttonList)
        {
           
            //get all list indexes
            for (int i=0; i <= buttonList.Count; i++)
            {

                if (i == index)
                {

                }


                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            //Console.WriteLine("do it");
                            /*
                            if (index > 0 && index <= buttonList.Count)
                            {*/

                            Console.WriteLine("left");
                            index -= index;
                            //}
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {/*
                        if(index > 0 && index < buttonList.Count)
                        {*/
                            Console.WriteLine("right");
                            index += index;
                            // }
                            break;
                        }
                }

                //Console.WriteLine("button display "+i);
            }
            return index;

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
