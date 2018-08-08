// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IShape.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the IShape type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ctlSvgPlayground.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Svg;

    /// <summary>
    /// The Shape interface.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Gets or sets a value indicating whether active the Shape.
        /// </summary>
        bool Active { get; set; }

        /// <summary>
        /// Gets or sets the owner of this Shape.
        /// </summary>
        object Owner { get; set; }

        /// <summary>
        /// Gets the name - analog ToString().
        /// </summary>
        string ToString { get; }

        /// <summary>
        /// Gets or sets the info message.
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Gets or sets the X coordinate of the Shape.
        /// </summary>
        int translateX { get; set; }

        /// <summary>
        /// Gets or sets the Y coordinate of the Shape.
        /// </summary>
        int translateY { get; set; }

        /// <summary>
        /// Gets or sets the Color of the Shape.
        /// </summary>
        Color color { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether hidden.
        /// </summary>
        bool Hidden { get; set; }

        /// <summary>
        /// The set position.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        void SetPosition(int x, int y);

        /// <summary>
        /// The rendereng function.
        /// </summary>
        /// <returns>
        /// The <see cref="SvgPath"/>.
        /// </returns>
        Svg.SvgPath Draw();

    }
}
