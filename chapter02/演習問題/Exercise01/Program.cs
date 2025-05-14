using System.Collections.Generic;

namespace Exercise01 {
    public class Program {
        static void Main(string[] args) {
            //2.1.3
            var songs = new List<Song>();

            //歌データを入れるリストオブジェクトを生成

            Console.WriteLine("*****曲の登録******");
            while (true) {

                Console.Write("曲名：");

                string title = Console.ReadLine();

                //endが入力されたら登録終了
                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;
                //または↓

                //endが入力されたら登録終了
                // if (title.Equals("end")) return;
                // if (title.Equals("END")) return;

                Console.Write("アーティスト名");
                //入力されたアーティスト名を取得
                string artistName = Console.ReadLine();


                Console.Write("演奏時間（秒）：");
                //入力された演奏時間を取得

                int length = int.Parse(Console.ReadLine());

                //songインスタンスを生成

                Song song = new Song(title, artistName, length);

                //歌データを入れるリストオブジェクトへ登録
                songs.Add(song);


                Console.WriteLine();//改行

            }

            //元の文
            // new Song("Let it be", "The Beatles", 243),
            // new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
            // new Song("Close To You", "Carpenters", 276),
            // new Song("Honesty", "Billy Joel", 231),
            //  new Song("I Will Always Love You", "Whitney Houston", 273),



            // };
            //呼び出す分
             printSongs(songs);
        }
        //2.1.4
        private static void printSongs(List<Song> songs) {
          //  foreach (var Song in Song) {
          //      String[] items = line.Split(',');
#if fales
            foreach (Song song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title}, {song.ArtistName} {minutes}; {seconds;00}");

#else
                //TimeSpan構造体を使った場合
                  foreach (var song in songs) {
                   
                      Console.WriteLine($"{song.Title}, {song.ArtistName} {song.Length}");

                //   }

                //または、以下でも可
                //  foreach(var song in songs) {
                //    Console.WriteLine(@"{0},{1} {2:m\:ss)".
                //        song.Title, song,AritstName,TimeSpan.FromSeconds()//途中

                // }
#endif
                Console.WriteLine();

            }

        }

    }
}

