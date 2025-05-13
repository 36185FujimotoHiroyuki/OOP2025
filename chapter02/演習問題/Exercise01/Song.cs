using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {//2.1.1
    public class Song {
        //クラス定義
        String Title;
        String ArtistName;
        int Length;
       
        
        //2.1.2 コンストラクター定義
        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }

        //コンストラクター
        //  public string Title { get ; set; }
        //  public string ArtistName { get; set; }
        // public int Length { get; set; }

        
       // public string Title { get; set; } = string.Empty;
       
      //  public string ArtistName { get; set; } = string.Empty;
    
       // public int Length { get; set; }



    }

    }
