using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextFileProcessorDI {
    public class LineHaifNumberService : ITextFileService {
        //15.1
        public void Initialize(string fname) {
            Console.WriteLine(fname);
        }

        public void Execute(string line) {
            string result = new string(
                line.Select(c => ('0' <= c && c <= '9') ? (char)(c - '０' + '0') : c).ToArray()
                );
            Console.WriteLine(result);
         
           
        }

      
        public void Terminate() {
         
        
          
        }
    }
}
