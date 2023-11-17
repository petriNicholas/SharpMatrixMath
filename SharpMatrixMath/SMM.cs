using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpMatrixMath
{
    class SMM
    {
        public void Start()
        {
            Console.Title = "SHARP MATRIX MATH";
            RunMainMenu();
            
        }

        private void RunMainMenu()
        {
            string prompt = @"
         ________  ______  ___
        /  ___|  \/  ||  \/  |
        \ `--.| .  . || .  . |
         `--. \ |\/| || |\/| |
        /\__/ / |  | || |  | |
        \____/\_|  |_/\_|  |_/                          
";
            
            string[] options = { "Matrix", "Settings", "About", "EXIT" };

            Menu mainMenu = new Menu(prompt, options);

            int selectedIndex = mainMenu.Run(1);

            switch(selectedIndex)
            {
                case 0:
                    Matrix();
                    break;
                case 1:
                    Settings();
                    break;
                case 2:
                    About();
                    break;
                case 3:
                    Exit();
                    break;
            }
        }

        private void Exit()
        {
            Console.Clear();
            Console.WriteLine("Bye ...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        private void About()
        {

            Console.WriteLine("Program created by Nicholas Petri");
            Console.ReadKey(true);
            RunMainMenu();
        }

        private void Matrix()
        {
            Console.WriteLine("Placeholder");
            Console.ReadKey(true);
            RunMainMenu();
        }

        private void Settings()
        {
            Console.WriteLine("Program created by Nicholas Petri");
            Console.ReadKey(true);
            RunMainMenu();
        }
    }
}
