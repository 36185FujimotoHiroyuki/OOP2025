﻿using System.Collections.Immutable;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var obj = new MySample();
            //変更不可のオブジェクトなので、Add,Removeは新たなインスタンス
            var newList = obj.MyList.Add(6).Remove(0);
            obj.MyList.ForEach(n => Console.Write($"{n}"));
            Console.WriteLine();
            newList.ForEach(n => Console.Write($"{n}"));
            Console.WriteLine();
        }
    }

    class MySample {
        public ImmutableList<int> MyList { get; private set; }

        public MySample() {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            MyList = list.ToImmutableList();
        }
   // class MySample {
   //  private int aaaaa;
   //  public int Aaaaa { get => aaaaa; set => aaaaaa = value; } //コード5.9の説明から



    public class Person {
            public string GivenName { get; private set; }

            public string FamilyName { get; private set; }

            public Person(string familyName, string givenName) {
                FamilyName = familyName;
                GivenName = givenName;
            }

            //  メゾット内でプロパティの値を変更できる
            public void ChangeFamilyName(string name) => FamilyName = name;

        }
    }
}



