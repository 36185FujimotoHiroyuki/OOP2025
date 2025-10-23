using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp{

    internal class CarPerson{
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        // 名前
        public string Name { get; set; } = string.Empty;

        // 電話番号
        public string Phone { get; set; } = string.Empty;

        // 住所
        public string Address { get; set; } = string.Empty;

        // 画像データ
        public byte[] Picture { get; set; }

    }
}
