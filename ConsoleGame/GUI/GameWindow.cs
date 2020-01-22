using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGame.GUI
{
    sealed class GameWindow : Window
    {
        private Button _startButton;
        private Button _creditsButton;
        private Button _quitButton;
        private TextBlock _titleTextBlock;


        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Call of Duty", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            _startButton = new Button(20, 13, 18, 5, "Start");
            _startButton.SetActive();

            _creditsButton = new Button(50, 13, 18, 5, "Credits");

            _quitButton = new Button(80, 13, 18, 5, "Quit");
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

            _startButton.Render();
            _creditsButton.Render();
            _quitButton.Render();

            Console.SetCursorPosition(0, 0);
        }
    }
    
}
