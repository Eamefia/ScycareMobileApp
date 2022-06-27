using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ScycareApp.ViewModel
{
    public class RequestLabTestViewModel : INotifyPropertyChanged
    {
        public ICommand SelectItemCommand { get => new Command<string>((param) => PositionSelected = int.Parse(param)); }
        public int _positionSelected = 0;

        public int PositionSelected
        {
            set
            {
                if (_positionSelected != value)
                {
                    _positionSelected = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PositionSelected)));
                }
            }
            get => _positionSelected;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
