using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class InchConverter{
      
            //定数
            private const double ratio = 0.3048;
            //メートルからインチ
            public double FromMeter(double meter) {

            return meter / ratio;

            } //インチからメートルを求める
            public double ToMeter(double inch) {
                return inch * ratio;
            }
        }
    }
    
    
      
   
