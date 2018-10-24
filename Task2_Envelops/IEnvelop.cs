// <copyright file="IEnvelop.cs" company="My Company">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Task2_Envelops
{
    /// <summary>
    /// Set the  obvious interface for every envelop
    /// </summary>
    internal interface IEnvelop
    {
        /// <summary>
        /// Gets or sets the width of envelop
        /// </summary>
        double Width { get; set; }

        /// <summary>
        /// Gets or sets the height of envelop
        /// </summary>
        double Height { get; set; }

        /// <summary>
        /// Gets the diagonal
        /// </summary>
        /// <returns>the diagonal</returns>
        double Diagonal();

        /// <summary>
        /// Gets the max side
        /// </summary>
        /// <returns>Max side</returns>
        double MaxSide();

        /// <summary>
        /// Gets the min side
        /// </summary>
        /// <returns>min side</returns>
        double MinSide();

        /// <summary>
        /// For getting square
        /// </summary>
        /// <returns>the square</returns>
        double Square();
    }
}