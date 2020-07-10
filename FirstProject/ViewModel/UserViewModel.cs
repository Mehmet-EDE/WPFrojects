using FirstProject.Enums;
using FirstProject.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstProject.ViewModel
{
    public class UserViewModel : INotifyPropertyChanged
    {

        public UserViewModel()
        {
            LabelContent = "WPF Projesi";
        }

        public void Work(ButtonName buttonName)
        {
            switch (buttonName)
            {
                case ButtonName.WRITE_COMMAND:
                    {
                        LabelContent = Message;
                        break;
                    }
                case ButtonName.READ_COMMAND:
                    {
                        LabelContent = "MVVM";
                        break;
                    }

            }
        }


        private ICommand buttonCommand;


        public ICommand ButtonCommand
        {
            get
            {
                if (buttonCommand == null)
                    buttonCommand = new RelayCommand<ButtonName>(Work);
                return buttonCommand;
            }
        }

        private string labelContent;

        public string LabelContent
        {
            get { return labelContent; }
            set
            {
                labelContent = value;
                OnpropertyChanged(nameof(LabelContent));
            }
        }


        private string message;

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnpropertyChanged(nameof(Message));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
