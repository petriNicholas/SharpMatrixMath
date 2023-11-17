using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SharpMatrixMath
{
    class Menu
    {
        private int SelectedIndex;
        private readonly string[] Options;
        private readonly string Prompt;
        
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        private void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++) 
            { 
                string currentOption = Options[i];
                string prefix , postfix;

                if (SelectedIndex == i) 
                {
                    prefix = ">>";
                    postfix = "<<";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "<<";
                    postfix = ">>";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefix} {currentOption} {postfix}");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                //Update selectedIndex
                if (keyPressed == ConsoleKey.UpArrow) SelectedIndex--;
                else if (keyPressed == ConsoleKey.DownArrow
                    || keyPressed == ConsoleKey.Tab) SelectedIndex++;

                if (SelectedIndex < 0) SelectedIndex = Options.Length - 1;
                else if (SelectedIndex == Options.Length) SelectedIndex = 0;

            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
