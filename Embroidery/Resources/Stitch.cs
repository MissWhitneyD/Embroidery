using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Ink;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Embroidery.Resources
{
    public class Stitch
    {
        public string Name { get; set; }
        public Line MyLine { get; set; }
        public Stitch(string name, DoubleCollection lineStyle)
        {
            MyLine = new Line();
            Name = name;
            MyLine.StrokeDashArray = lineStyle;
        }



    }

}
