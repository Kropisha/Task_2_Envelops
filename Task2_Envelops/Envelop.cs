// <copyright file="Envelop.cs" company="My Company">
// Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Yuliia Kropyvna</author>
namespace Task2_Envelops
{
    using System;

    /// <summary>
    /// Representing envelop
    /// </summary>
    public class Envelop : IEnvelop
    {
        /// <summary>
        /// the width of envelop
        /// </summary>
        private double _width;

        /// <summary>
        /// the height of envelop
        /// </summary>
        private double _height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Envelop" /> class.
        /// </summary>
        public Envelop()
        {
            this.Width = 1;
            this.Height = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Envelop" /> class.
        /// </summary>
        /// <param name="width">the width of envelop</param>
        /// <param name="height">the height of envelop</param>
        public Envelop(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("The side should not be less or equal 0.");
            }

            this.Width = width;
            this.Height = height;                   
        }

        /// <summary>
        /// Gets or sets the width of envelop
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of envelop
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        /// <summary>
        /// for overloading 
        /// </summary>
        /// <param name="first">first envelop</param>
        /// <param name="second">second envelop</param>
        /// <returns>is less</returns>
        public static bool operator <(Envelop first, Envelop second)
        {
            return first.Square() < second.Square();
        }

        /// <summary>
        /// for overloading 
        /// </summary>
        /// <param name="first">first envelop</param>
        /// <param name="second">second envelop</param>
        /// <returns>is more</returns>
        public static bool operator >(Envelop first, Envelop second)
        {
            return first.Square() > second.Square();
        }

        /// <summary>
        /// for overloading 
        /// </summary>
        /// <param name="first">first envelop</param>
        /// <param name="second">second envelop</param>
        /// <returns>is equal</returns>
        public static bool operator ==(Envelop first, Envelop second)
        {
            return first.Square() == second.Square();
        }

        /// <summary>
        /// for overloading 
        /// </summary>
        /// <param name="first">first envelop</param>
        /// <param name="second">second envelop</param>
        /// <returns>is not equal</returns>
        public static bool operator !=(Envelop first, Envelop second)
        {
            return first.Square() != second.Square();
        }

        /// <summary>
        /// For getting square
        /// </summary>
        /// <returns>the square</returns>
        public double Square()
        {
            return _width * _height;
        }

        /// <summary>
        /// Gets the min side
        /// </summary>
        /// <returns>min side</returns>
        public double MinSide()
        {
            if (_width >= _height)
            {
                return _height;
            }
            else
            {
                return _width;
            }
        }

        /// <summary>
        /// Gets the max side
        /// </summary>
        /// <returns>Max side</returns>
        public double MaxSide()
        {
            if (_width >= _height)
            {
                return _width;
            }
            else
            {
                return _height;
            }
        }

        /// <summary>
        /// Gets the diagonal
        /// </summary>
        /// <returns>the diagonal</returns>
        public double Diagonal()
        {
            return Math.Sqrt((_width * _width) + (_height * _height));
        }

        /// <summary>
        /// for overloading Equals
        /// </summary>
        /// <param name="obj">comparing object</param>
        /// <returns>is equal</returns>
        public override bool Equals(object obj)
        {
            Envelop env = (Envelop)obj;
            return env._height == this._height && env._width == this._width;
        }

        /// <summary>
        /// for overloading GetHashCode
        /// </summary>
        /// <returns>Hash cod</returns>
        public override int GetHashCode()
        {
            return (int)_height;
        }
    }
}
