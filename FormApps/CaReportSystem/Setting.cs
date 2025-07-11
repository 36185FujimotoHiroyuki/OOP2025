using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CaReportSystem
{
    public class Setting  {

        private static Setting instance;//自分自身のインスタンスを格納


        //設定した色情報を格納
        public int MainFormBackColor { get; set; }
        //コンストラクタ（privateにすることによりnewできなくなる）
        private Setting() { }

        public static Setting getInstance() {
            if (instance == null) {
                instance = new Setting();
            }
            return instance;
        }







        //違う
      //  [XmlElement("MainFormBackColor")]
      //  public string MainFormBackColorHtml {
      //      get => ColorTranslator.ToHtml(MainFormBackColor);
      //      set => MainFormBackColor = ColorTranslator.FromHtml(value);
      //  }

        // public parameterless constructor が必要
     //   public ColorSettings() { }
    }





}

