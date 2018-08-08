// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cloud.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the Cloud type.
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
    /// The cloud.
    /// </summary>
    [Serializable]
    public class Cloud : IShape
    {
        /// <summary>
        /// The vector data.
        /// </summary>
        private const string sData = "m272.610311,36.819701c-34.912759,0 -64.879836,21.308656 -79.5482,52.070717c-5.858467,-3.849339 -12.320345,-6.180109 -19.216694,-6.180109c-20.854784,0 -38.208935,19.744961 -43.572735,46.548084c-9.155328,-4.258963 -19.800439,-6.83757 -31.17127,-6.83757c-34.112518,0 -61.783912,21.96629 -61.783912,49.046423c0,24.444418 22.694215,44.539982 52.175571,48.257455c-1.321321,2.638491 -2.346235,5.251334 -2.346235,8.021001c0,25.927774 60.356122,47.07401 134.740335,47.07401c74.3842,0 134.740408,-21.14625 134.740335,-47.07401c0,-1.744513 -0.920009,-3.301347 -1.452419,-4.996693c3.258042,0.953574 6.483964,1.972384 10.055255,1.972384c19.898903,0.000072 36.087166,-15.912897 36.087166,-35.502774c0,-19.589891 -16.188263,-35.50276 -36.087166,-35.50276c-2.438563,0 -4.512103,0.991335 -6.815229,1.446415c2.013857,-7.833019 3.351739,-15.825581 3.351739,-24.325973c0,-51.855504 -39.882935,-94.01657 -89.156517,-94.01657l-0.000024,-0.000029z";

        /// <summary>
        /// Initializes a new instance of the <see cref="Cloud"/> class.
        /// </summary>
        /// <param name="capacity">
        /// The capacity.
        /// </param>
        /// <remarks>
        /// Default value for average car is 4
        /// </remarks>
        public Cloud(int capacity = 4)
        {
            this.hidden = false;
            this.peopleList = new ArrayList(4);
        }

        /// <summary>
        /// The people list - array of Shapes owned by this instance.
        /// </summary>
        private readonly ArrayList peopleList;

        /// <summary>
        /// Gets or sets a value indicating whether active.
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
                return "Cloud";
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
        public bool Hidden
        {
            get
            {
                return this.hidden;
            }

            set
            {
                if (value)
                {
                    foreach (IShape shape in this.peopleList)
                    {
                        shape.Owner = null;
                    }

                    this.peopleList.Clear();
                }

                this.hidden = value;
            }
        }

        /// <summary>
        /// The hidden.
        /// </summary>
        private bool hidden;

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
            int difX = translateX - x;
            int difY = translateY - y;
            translateX = x;
            translateY = y;

            foreach (IShape dep in this.peopleList)
            {
                dep.translateX -= difX;
                dep.translateY -= difY;
            }
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

        /// <summary>
        /// To become an Owner of the Shape.
        /// </summary>
        /// <param name="shape">
        /// The shape.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool GetIn(IShape shape)
        {
          
            int count = (shape.Owner == this) ? this.peopleList.Count - 1 : this.peopleList.Count;

            if (this.peopleList.Capacity > count)
            {
                if (shape.Owner != null && shape.Owner is Cloud) ((Cloud)shape.Owner).GetOff(shape);
                shape.Owner = this;
                this.peopleList.Add(shape);
                return false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// The get rid of the Shape.
        /// </summary>
        /// <param name="shape">
        /// The shape.
        /// </param>
        public void GetOff(IShape shape)
        {
            if (shape != null)
            {
                this.peopleList.Remove(shape);
                shape.Owner = null;
            }
        }
    }
}
