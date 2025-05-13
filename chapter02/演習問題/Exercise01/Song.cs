using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {//2.1.1
    public class Song {
        //クラス定義
  //      String Title;
   //     String ArtistName;
    //    int Length;
        //2.1.2 コンストラクター定義
      public Song(string title, string artistName, int length) {
          Title = title;
           ArtistName = artistName;
           Length = length;
         }

        public string Title { get; private set; } = string.Empty;

        public string ArtistName { get; private set; } = string.Empty;

        public int Length { get; private set; }


        //計算
     //   public string GetFormattedLength() {
     //      int minutes = length / 60;
     //       int seconds = length % 60;
      //     return $"{minutes}:{seconds:D2}";
     //  }
      //  public override string ToString() {
     //      return $"Title: {Title}, Artist: {ArtistName}, Length: {GetFormattedLength()}";
     //  }
    }










}



    
