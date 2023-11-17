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

        private void DisplayOptionsVertically()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++) 
            { 
                string currentOption = Options[i];
                string prefix , postfix="";

                if (SelectedIndex == i) 
                {
                    prefix = "*";
                    postfix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefix} {currentOption} {postfix}");
            }
            Console.ResetColor();
        }

        private void DisplayOpitionsHorizontally()
        {
            Console.WriteLine(Prompt);
            string optionLine = "";
            for (int i = 0;i < Options.Length;i++)
            {
                string prefix = "";

                if (SelectedIndex == i)
                {
                    prefix = "*";
                }
                
                optionLine += prefix + Options[i].ToString() + prefix
                    + " ";
            }
            Console.WriteLine(optionLine);
            Console.ResetColor();
        }

        private void DisplayOptions(int flag)
        {
            if (flag == 1) DisplayOptionsVertically();
            else DisplayOpitionsHorizontally();
        }
        public int Run(int flag)
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions(flag);
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                ConsoleKey upSelect, downSelect;

                if (flag == 1)
                {
                    upSelect = ConsoleKey.UpArrow;
                    downSelect = ConsoleKey.DownArrow;
                }
                else
                {
                    upSelect= ConsoleKey.LeftArrow;
                    downSelect= ConsoleKey.RightArrow;
                }
                

                //Update selectedIndex
                if (keyPressed == upSelect) SelectedIndex--;
                else if (keyPressed == downSelect
                    || keyPressed == ConsoleKey.Tab) SelectedIndex++;

                if (SelectedIndex < 0) SelectedIndex = Options.Length - 1;
                else if (SelectedIndex == Options.Length) SelectedIndex = 0;

            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }
}
