// <copyright file="BusinessLogic.cs" company="My Company">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Task2_Envelops
{
    /// <summary>
    /// This class for logic of my program
    /// </summary>
    public class BusinessLogic
    {
        /// <summary>
        /// Check the side of envelop
        /// </summary>
        /// <param name="side">Envelop`s side</param>
        /// <returns>Is this side correct</returns>
        public static bool IsCorrect(double side)
        {
            return side > 0;
        }

        /// <summary>
        /// This method for trying to put one envelop in other
        /// </summary>
        /// <param name="first_Envelop">First Envelop</param>
        /// <param name="second_Envelop">Second Envelop</param>
        /// <returns>message of comparing</returns>
        public string CompareEnvelops(Envelop first_Envelop, Envelop second_Envelop)
        {
            bool isComparing = false;
            string message = string.Empty;
            if ((second_Envelop.MinSide() < first_Envelop.MinSide() && second_Envelop.MaxSide() < first_Envelop.MaxSide()) ||
                (second_Envelop.MinSide() < (first_Envelop.MinSide() / 2) && second_Envelop.MaxSide() < first_Envelop.Diagonal()))
            {
                if (first_Envelop > second_Envelop)
                {
                    isComparing = true;
                    message = "You can put the second envelope in the first.";
                }
            }

            if ((first_Envelop.MinSide() < second_Envelop.MinSide() && first_Envelop.MaxSide() < second_Envelop.MaxSide()) ||
                (first_Envelop.MinSide() < (second_Envelop.MinSide() / 2) && first_Envelop.MaxSide() < second_Envelop.Diagonal()))
            {
                if (first_Envelop < second_Envelop)
                {
                    isComparing = true;
                    message = "You can put the first envelope in the second.";
                }
            }

            if (first_Envelop == second_Envelop)
            {
                isComparing = true;
                message = "They are equal, so you can`t put one in another.";
            }
            else if (!isComparing)
            {
                message = "Oh,no! They are too different. I can`t do anything with them.";
            }

            return message;
        }
    }
}
