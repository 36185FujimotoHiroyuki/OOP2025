using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorChecker
{
    public class MyColor {

       public Color Color { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return Name ?? string.Format("R: {0.3}  G: {0.3}  B: {0.3}" , Color.R , Color.G , Color.B);





        }


    }
}
