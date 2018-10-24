// <copyright file="UI.cs" company="My Company">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Task2_Envelops
{
    using System;
    using System.Linq;
    using ShowMenuLib;

    /// <summary>
    /// Present visualization for user
    /// </summary>
    internal class UI : GetMenu
    {       
        /// <summary>
        /// Show menu 
        /// </summary>
        /// <param name="type"> The header-line of menu </param>
        /// <returns>user choice</returns>
        public override char ShowMenu(string type)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(type);
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("           1.Help                 ");
            Console.WriteLine("           2.Do it                ");
            Console.WriteLine("           3.Quit                 ");
            Console.WriteLine();
            Console.WriteLine(" What is your choice? [tap number]");

            return Console.ReadKey().KeyChar;
        }

        /// <summary>
        /// For correct initialize each side
        /// </summary>
        /// <param name="side">Envelop`s side</param>
        /// <returns>Is this side correct</returns>
        public bool IsException(ref double side)
        {
            bool isOk = true;
            try
            {
                side = double.Parse(Console.ReadLine());
                if (!BusinessLogic.IsCorrect(side))
                {
                    isOk = false;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Where did you see side in negative range?");
                    Console.Beep();
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                    Console.ResetColor();
                }
            }
            catch (FormatException ex)
            {
                isOk = false;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Write a number." + ex.Message);
                Console.Beep();
                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.ResetColor();
            }

            return isOk;
        }

        /// <summary>
        /// Menu actions
        /// </summary>
        /// <param name="i">position of user choice(from top)</param>
        public override void UserChoice(int i)
        {
            UsersAction action;
            do
            {
                Console.SetCursorPosition(0, 0);
                Enum.TryParse(this.ShowMenu(" Welcome to the envelops analyzer!").ToString(), out action);
                Console.WriteLine();
                Console.ResetColor();

                switch (action)
                {
                    case UsersAction.Help:
                        Help helper = new Help();
                        Console.WriteLine(helper.References(@"..\..\Files\EnvRef.txt"));
                        Console.ReadKey();
                        break;
                    case UsersAction.Program:
                        this.TaskWithEnvelops();
                        break;
                    case UsersAction.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.Clear();
            }
            while (action != UsersAction.Quit);
        }

        /// <summary>
        /// This method for initialize and get results of comparing
        /// </summary>
        private void TaskWithEnvelops()
        {
            UI userValue = new UI();
            bool isContinue = true;
            while (isContinue)
            {
                double firstWidth = 1.0;
                double firstHeight = 1.0;
                double secondWidth = 1.0;
                double secondHeight = 1.0;
                string key;
                char condition = 'n';
                do
                {
                    Console.WriteLine("Enter the width of first envelop: ");
                    if (!this.IsException(ref firstWidth))
                    {
                        break;
                    }

                    Console.WriteLine("Enter the height of first envelop: ");
                    if (!this.IsException(ref firstHeight))
                    {
                        break;
                    }

                    Envelop first_Envelop = new Envelop(firstWidth, firstHeight);
                    Console.WriteLine("Enter the width of second envelop: ");
                    if (!this.IsException(ref secondWidth))
                    {
                        break;
                    }

                    Console.WriteLine("Enter the height of second envelop: ");
                    if (!this.IsException(ref secondHeight))
                    {
                        break;
                    }

                    Envelop second_Envelop = new Envelop(secondWidth, secondHeight);
                    BusinessLogic bl = new BusinessLogic();
                    Console.WriteLine(bl.CompareEnvelops(first_Envelop, second_Envelop));
                    Console.WriteLine("Do you want to continue?['y' or 'yes' if you want]");
                    key = Console.ReadLine();
                    try
                    {
                        condition = key.ToLower().First();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("Be attentive!");
                        Console.Beep();
                        Console.ReadLine();
                    }
                }
                while (condition == 'y');
                isContinue = false;
            }
        }
    }
}
