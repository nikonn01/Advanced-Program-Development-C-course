// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ManShape.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ManShape type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Assignment1B.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Svg;

    /// <summary>
    /// The man shape.
    /// </summary>
    [Serializable]
    public class ManShape : IShape
    {
        /// <summary>
        /// The vector data.
        /// </summary>
        private string sData = "m13.743298,10.860611c0,-4.426208 3.594936,-8.011017 8.032867,-8.011017c4.438091,0 8.032696,3.584808 8.032696,8.011017c0,4.426315 -3.594604,8.011307 -8.032696,8.011307c-4.437931,0 -8.032867,-3.584991 -8.032867,-8.011307zm27.007465,22.678009l0,-4.046021c0,-4.256912 -3.458153,-7.708725 -7.728912,-7.708725l-22.516384,0c-4.268208,0 -7.728977,3.451813 -7.728977,7.708725l0,4.046021c-0.007393,0.091583 -0.012482,0.186142 -0.012482,0.281189l0,23.304947c0,1.811386 1.471153,3.277893 3.286491,3.277893c1.813274,0 3.287678,-1.466507 3.287678,-3.277893l0,-22.959274l2.204121,0l0,26.239334l0.015888,0l0,37.076584c0,2.41008 1.962631,4.36821 4.381641,4.36821c2.420433,0 4.381695,-1.955933 4.381695,-4.36821l0,-37.076584l2.890568,0l0,37.076584c0,2.41008 1.963852,4.36821 4.381592,4.36821c2.420456,0 4.381729,-1.955933 4.381729,-4.36821l0,-37.076584l0.013618,0l0,-26.239334l2.203918,0l0,22.958496c0,1.810654 1.474411,3.278671 3.287552,3.278671c1.815834,0 3.286713,-1.468018 3.286713,-3.278671l0,-23.304794c-0.001305,-0.096756 -0.009048,-0.18898 -0.016449,-0.280563l0,0z";

        /// <summary>
        /// Gets or sets a value indicating whether the shape is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the translate x.
        /// </summary>
        public int translateX { get; set; }

        /// <summary>
        /// Gets or sets the translate y.
        /// </summary>
        public int translateY { get; set; }

        public Color color { get; set; }

        /// <summary>
        /// The draw.
        /// </summary>
        /// <returns>
        /// The <see cref="SvgPath"/>.
        /// </returns>
        public SvgPath Draw()
        {
            Svg.SvgPath pa = new Svg.SvgPath();

            // converting path data string to svg
            Svg.Pathing.SvgPathSegmentList svgSvgPathSegmentList = new Svg.Pathing.SvgPathSegmentList();
            var converter = TypeDescriptor.GetConverter(typeof(Svg.Pathing.SvgPathSegmentList));
            pa.PathData = (Svg.Pathing.SvgPathSegmentList)converter.ConvertFrom(sData);

            // initializing the renderer
            Svg.ISvgRenderer render = null;

            GraphicsPath alu = new GraphicsPath();
            alu = pa.Path(render);
            Matrix m = new Matrix();
            m.Translate(translateX, translateY, MatrixOrder.Append);
            alu.Transform(m);

            // just return the SvgPath
            return pa;
        }
    }
}
