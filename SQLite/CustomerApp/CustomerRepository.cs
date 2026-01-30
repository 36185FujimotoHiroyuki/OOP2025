using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp {
    internal class CustomerRepository {
        private readonly string _databasePath;

        public CustomerRepository(string databasePath) {
            _databasePath = databasePath;
            InitializeDatabase();
        }

        // データベースを初期化し、テーブルを作成
        private void InitializeDatabase() {
            using (var connection = new SQLiteConnection(_databasePath)) {
                connection.CreateTable<CarPerson>();
            }
        }

        // 全ての顧客を取得
        public List<CarPerson> GetAllPersons() {
            using (var connection = new SQLiteConnection(_databasePath)) {
                return connection.Table<CarPerson>().ToList();
            }
        }

        // 顧客をデータベースに挿入
        public int InsertPerson(CarPerson person) {
            using (var connection = new SQLiteConnection(_databasePath)) {
                return connection.Insert(person);
            }
        }

        // 顧客情報を更新
        public int UpdatePerson(CarPerson person) {
            using (var connection = new SQLiteConnection(_databasePath)) {
                return connection.Update(person);
            }
        }

        // 顧客をデータベースから削除
        public int DeletePerson(CarPerson person) {
            using (var connection = new SQLiteConnection(_databasePath)) {
                return connection.Delete(person);
            }
        }
    }
}
