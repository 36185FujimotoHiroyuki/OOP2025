﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class FeetConverter {
        //定数
        private const double ratio = 0.3048;
        //メートルからフィートを求める
    public double FromMeter(double meter) {

     
        return meter / ratio;

        } //フィートからメートルを求める
        public double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}