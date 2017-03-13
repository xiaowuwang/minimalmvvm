using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace commandBindings
{
    public class ViewModel : INotifyPropertyChanged
    {
        public RoutedCommand MessageCommand = new RoutedCommand();

        public ViewModel()
        {
            allowFunction = true;
            CommandBinding cmdBinding = new CommandBinding(MessageCommand);
        }

        private void MessageExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Message Executed!");
        }

        private bool _allowFunction;
        public bool allowFunction
        {
            get { return _allowFunction; }
            set
            {
                _allowFunction = value;
                FirePropertyChanged("allowFunction");
            }
        }

        #region FirePropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void FirePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }

}