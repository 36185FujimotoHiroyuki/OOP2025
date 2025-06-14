﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    //商品クラス
    public class Product {

        //商品コード
        public int Code { get;private set; }   //プロパティ

        //商品名
        public string Name { get; private set; }
        //商品価格（税抜き）
        public int Price { get; private set; }


        //消費税率１０％
        private readonly double _taxRate = 0.1;   //フィールド

        //消費税額を求める                    
        public int GetTax() {                      //メゾッド
            return (int)(Price * _taxRate);     

        }
        //コンストラクター
        public  Product ( int Code, string Name, int Prise){
            this.Code = Code;
            this.Name = Name;
            this.Price = Price;


        }


        //税込価格を求める
        public int GetPriceIncludingTax() {
            return Price + GetTax();

        }





    }
}
