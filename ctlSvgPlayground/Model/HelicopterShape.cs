// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HelicopterShape.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the HelicopterShape type.
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
    /// The Helicopter shape.
    /// </summary>
    [Serializable]
    public class HelicopterShape : IShape
    {
        /// <summary>
        /// The vector data.
        /// </summary>
        private const string sData = "m180.829967,230.131384c5.613172,2.794643 15.766246,-10.256509 5.537413,-11.02061c-6.92332,-6.480862 15.348432,-1.855609 6.272477,-15.542797c-9.709876,-3.144156 -17.300421,-14.135811 -20.681258,-28.196638c-3.949602,-15.146575 -16.806095,-10.985295 -25.229515,-15.361743c-16.809464,-4.463189 -33.599925,-9.738696 -50.696276,-11.040995c-5.685759,9.528822 -8.367048,29.999405 -18.48485,29.201144c-10.114143,-7.568458 0.427159,-26.568725 -2.603198,-37.4232c-5.940888,-2.977046 -4.807572,-8.753372 0.986274,-9.484505c8.839625,-9.073261 1.485068,-26.61226 -0.43822,-38.564251c-4.678879,-11.351837 5.340463,-21.360787 9.158262,-7.96595c4.864783,13.970096 7.688868,29.308859 11.552832,43.95483c1.205666,9.395282 10.142562,4.068656 14.823202,6.871461c19.737337,3.15801 39.493465,6.332436 59.337061,7.55415c9.940436,-6.378397 20.489545,-11.723049 31.48327,-9.45648c7.688441,3.465133 12.030631,-0.805391 11.689079,-12.6284c4.365045,-17.029484 -10.696333,-9.445211 -17.486851,-11.95172c-27.090576,-1.95948 -54.261202,-2.552799 -81.341899,-0.144628c-6.012293,-2.231299 7.94091,-2.028705 10.058228,-2.541643c28.57463,-2.244995 57.20984,-1.140643 85.79188,-3.049831c8.241793,-4.521167 16.422029,3.529381 24.824981,2.165952c21.194481,1.291381 42.407983,1.740934 63.618816,1.838864c-5.996224,6.62854 -17.181547,0.065427 -25.113126,1.707489c-15.938535,-0.727777 -31.978099,-1.41041 -47.822893,1.816326c-6.171394,8.867503 -2.931555,27.803806 4.790748,32.214549c7.869756,6.292404 15.945137,11.808384 23.10959,19.286428c4.528041,12.825905 17.326225,23.587371 13.55139,39.738225c-4.326053,13.364919 -20.012828,4.961422 -23.984651,8.720007c2.938438,7.744297 13.085757,8.527536 14.910723,11.358843c-10.005431,4.286079 -0.465115,13.438372 5.225607,10.533249c7.022389,2.472702 -7.140296,4.209463 -9.478462,3.396419c-11.376464,0.136091 -22.745999,-0.591822 -34.119613,-0.824461c10.990035,-0.729319 22.011401,-0.714615 32.967697,-2.335171c-2.5556,-15.62684 -16.057943,-7.983182 -23.837968,-10.695336c-3.792673,-2.891791 -16.294182,0.776606 -9.956673,6.482914c3.536164,-2.369397 12.179144,-0.103293 4.307201,2.553547c-14.237894,0.683664 -28.529333,0.989609 -42.721276,-1.166026l0,-0.000011zm34.654311,-6.494104c-4.339766,-9.337485 -19.337133,-7.543392 -22.06644,0.961549c5.316466,6.361845 16.287703,4.14788 21.944669,0.294653l0.121771,-1.256213l0,0l0,0.000011zm31.369853,-5.438082c-6.39658,-6.712355 -18.103292,-7.453136 -23.850058,-1.996462c7.216,5.132183 16.067068,3.043527 23.850058,1.996462zm-31.605696,-3.074784c6.796754,-8.626169 -11.991647,-7.020692 -16.145166,-6.581071c-10.272292,6.949166 4.167279,8.868365 8.481135,7.729332c2.570129,-0.025202 5.150893,-0.312021 7.664039,-1.148261l-0.000008,0z";

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
                return "Helicopter";
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
