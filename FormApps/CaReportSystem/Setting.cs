using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CaReportSystem
{
    public class Setting  {
        //設定した色情報を格納
        public int MainFormBackColor { get; set; }



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

