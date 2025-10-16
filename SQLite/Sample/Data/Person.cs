using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Data
{
   public class Person{
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        //名前

        public string Name { get; set; } = string.Empty;
        //電話番号


        public string Phone { get; set; } = string.Empty;


       // public override string ToString() {
         //   return $"{Id}{Name} {Phone} ";


            }

        }

