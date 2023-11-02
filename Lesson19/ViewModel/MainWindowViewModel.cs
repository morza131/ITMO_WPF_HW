using Lesson19.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lesson19.ViewModel
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;  
        void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private int radius;
        public int Radius
        {
            get => radius;
            set
            {                
                    radius = value;
                OnPropertyChanged();
            }
        }
        private double circumference;
        public double Сircumference
        {
            get => circumference;
            set
            {
                circumference = value;
                OnPropertyChanged();
            }
        }
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Сircumference = MyMath.FindCircumference(Radius);
        }
        private bool CanAddCommandExecuted(object p)
        {
           if (Radius != 0)
                return true;
           else
            return false;
        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecuted);
        }
    }
}
