using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class ViewModel : BindableBase {

        public ViewModel() {
            ChangeMessageCommand = new DelegateCommand<string>(
                (par) => GreetingMessage = par);
        }
        private string _greetingMessage = "Hello World";
        public string GreetingMessage {
            get => _greetingMessage;
            set { 
                if(  SetProperty(ref _greetingMessage, value)) {
                    CanChangeMessage = false;

                }
        }
}
        private bool _canChangeMessage = true;
        public bool CanChangeMessage {
            get => CanChangeMessage;
            private set => SetProperty(ref _canChangeMessage, value);

        }

        public string NewMessage1 { get; } = "エラー";
        public string NewMessage2 { get; } = "予期せぬエラー";
        public DelegateCommand<string> ChangeMessageCommand { get; }

       
    }
}
