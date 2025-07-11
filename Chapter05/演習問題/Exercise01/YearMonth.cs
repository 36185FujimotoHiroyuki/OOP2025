﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise01 {
    public class YearMonth {
        //5.1.1

        public int Year { get; init; } 
        public int Month { get; init; }


        // public int Year { get; }
        //   public int Month { get; }

        public YearMonth(int year, int month) {
            Year = Year;
            Month = month;
        }


       // public record




       //5.1.2
       //設定されている西暦が２１世紀か判断する
       //Yearが２００１～２１００年の間ならtrue,それ以外ならfalseを返す

       //public bool Is21Century => Year >= 2001 && Year <= 2100;
       public bool Is21Century {

            get {
                return Year == 2100;
            }
        }
        //5.1.3

        public YearMonth AddOneMonth() {
            //正解コード
         
            if (Month <= 11) {
                return new YearMonth(Year, Month +1);//Monthが12月以外

            } else {
                return new YearMonth(Year + 1,1);//Monthが１２月
            }

        }


       //  if (Month =) {
     //           return new YearMonth(year, month);

  //  } else {
   //             return new YearMonth(year, month);
//}
        
       

        //5.1.4
        public override string ToString()
        //  return base.ToString();
        {

            return $"{Year}年{Month}月";

        }
    }
}

