using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1B.Model
{
    public interface IShape
    {
        bool Active { get; set; }

        int translateX { get; set; }
        int translateY { get; set; }

        Color color { get; set; }

        Svg.SvgPath Draw();
    }
}
