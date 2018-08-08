// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlaneShape.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ManShape type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ctlSvgPlayground.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Svg;

    /// <summary>
    /// The derived PlaneShape class.
    /// </summary>
    [Serializable]
    public class PlaneShape : IShape
    {
        /// <summary>
        /// The vector data.
        /// </summary>
        private const string sData = "m88.446241,0.999996c-1.821875,0 -3.442778,0.772166 -4.810402,2.172809c-1.366467,1.399491 -2.496735,3.404849 -3.43727,5.90932c-1.880808,5.008248 -3.037764,12.043699 -3.670613,20.469304c-0.631605,8.409394 -0.738046,18.201357 -0.475642,28.683457c-22.504626,9.532123 -68.148199,29.2134 -71.814794,33.607814c-4.881649,5.850663 -3.304397,12.55585 -1.33722,17.007028l75.036665,-15.768329c1.586107,20.548829 3.84132,40.901361 5.806559,56.84913c-7.338131,2.217366 -21.036041,6.595641 -23.863459,9.310671c-3.895008,3.740178 -3.894979,15.818995 -3.894979,15.818995l30.711105,-2.578923c0.723314,5.206571 1.17566,8.244573 1.17566,8.244573l0.044879,0.274145l0.242322,0l0.565388,0l0.242316,0l0.044879,-0.274145c0,0 0.451488,-3.038057 1.175655,-8.244573l30.720083,2.578923c0,0 0.000035,-12.078817 -3.894985,-15.818995c-2.828475,-2.71608 -16.536385,-7.104282 -23.872437,-9.320888c1.961179,-15.898827 4.212414,-36.173481 5.797592,-56.656108l74.157183,15.585518c1.967154,-4.451178 3.553425,-11.156365 -1.328236,-17.007028c-3.621237,-4.340026 -48.161886,-23.583562 -70.944261,-33.242324c0.272206,-10.617961 0.17215,-20.543365 -0.466681,-29.048947l0,-0.020306c-0.633171,-8.416312 -1.791359,-15.444911 -3.670596,-20.448998c-0.940267,-2.503777 -2.061334,-4.50934 -3.428292,-5.90932c-1.367636,-1.400643 -2.988522,-2.172809 -4.810385,-2.172809l-0.000035,0.000006z";

        /// <summary>
        /// Gets or sets a value indicating whether the shape is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        public object Owner { get; set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public new string ToString
        {
            get
            {
                return "Plane";
            }
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the translate x.
        /// </summary>
        public int translateX { get; set; }

        /// <summary>
        /// Gets or sets the translate y.
        /// </summary>
        public int translateY { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        public Color color { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether hidden.
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// The set position.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        public void SetPosition(int x, int y)
        {
            translateX = x;
            translateY = y;
        }

        /// <summary>
        /// The draw.
        /// </summary>
        /// <returns>
        /// The <see cref="SvgPath"/>.
        /// </returns>
        public SvgPath Draw()
        {
            Svg.SvgPath pa = new Svg.SvgPath();

            if (!this.Hidden)
            {
                // converting path data string to svg
                Svg.Pathing.SvgPathSegmentList svgSvgPathSegmentList = new Svg.Pathing.SvgPathSegmentList();
                var converter = TypeDescriptor.GetConverter(typeof(Svg.Pathing.SvgPathSegmentList));
                pa.PathData = (Svg.Pathing.SvgPathSegmentList)converter.ConvertFrom(sData);

                // initializing the renderer
                Svg.ISvgRenderer render = null;

                // initialising graphic path for rendering
                GraphicsPath alu = pa.Path(render);
                Matrix m = new Matrix();

                // Shape transformation
                m.Translate(translateX, translateY, MatrixOrder.Append);
                alu.Transform(m);
            }

            // just return the SvgPath
            return pa;
        }
    }
}
