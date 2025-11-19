using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    public class LineOutputService : ITextFileService {
        //15.3
        private int _count;
        public void Initialize(string fiame) {

            _count = 0;
        }

        public void Execute(string line) {
            if(_count < 20) {
             Console.WriteLine(line);

            }
            _count++;

        }

        public void Terminate() {

        }
    }
}
