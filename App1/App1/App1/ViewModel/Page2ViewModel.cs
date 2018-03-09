using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModel
{
    class Page2ViewModel:INotifyPropertyChanged
    {
        string labelText = "Hello";
        public string LabelText
        {
            get { return labelText; }
            set
            {
                labelText = value;
                RaisePropertyChanged();
            }
        }

        private Command changedTextCommand;
        public Command ChangeTextCommand
        {
            get
            {
                return changedTextCommand ?? (changedTextCommand = new Command(
                    () =>
                    {
                        LabelText = "Goodbye";
                    }
                    ));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;        
        //helpper method for raising property changed event
        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
