// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WomanShape.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the WomanShape type.
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
    /// The woman shape.
    /// </summary>
    [Serializable]
    public class WomanShape : IShape
    {
        /// <summary>
        /// The vector data.
        /// </summary>
        private string sData = "m22.359484,18.709778c3.829893,0 6.938343,-3.54921 6.938343,-7.927452c0,-4.381271 -3.10845,-7.932709 -6.938343,-7.932709c-3.833136,0 -6.942637,3.551437 -6.942637,7.932709c0,4.378242 3.108426,7.927452 6.942637,7.927452zm19.459177,34.190033l-6.226559,-26.386307c-0.058052,-0.239624 -0.139767,-0.467773 -0.238686,-0.679352c-0.707485,-2.472153 -2.738571,-4.262131 -5.137367,-4.262131l-15.759367,0c-2.500944,0 -4.600848,1.943954 -5.219086,4.581665c-0.041938,0.115326 -0.076337,0.236801 -0.107516,0.361908l-6.115814,26.38533c-0.407509,1.729996 0.491368,3.507919 2.007411,3.972961c1.513904,0.46344 3.069744,-0.563522 3.477254,-2.293274l4.802969,-20.726395l2.000971,0l-8.716753,37.500763l8.213561,0l0,25.88945c0,1.99173 1.41067,3.605179 3.155746,3.605179c1.740768,0 3.154667,-1.612625 3.154667,-3.605179l0,-25.88945l2.509541,0l0,25.88945c0,1.99173 1.412827,3.605179 3.157906,3.605179c1.740778,0 3.154684,-1.612625 3.154684,-3.605179l0,-25.88945l8.209223,0l-8.748989,-37.500763l2.053661,0l4.891121,20.726395c0.407509,1.729752 1.963356,2.756714 3.477249,2.293274c1.510654,-0.465042 2.409534,-2.244095 2.004173,-3.974075l0,0z";

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
