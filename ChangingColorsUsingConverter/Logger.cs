using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChangingColorsUsingConverter
{
    public class Logger : INotifyPropertyChanged
    {
        public ObservableCollection<int> MyQueue { get; set; } = new ObservableCollection<int>();
        
        #region public string Name { get; set; }
        private string _Name = "Stevie";
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }
        #endregion

        void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// On construction we will start to update MyQueue
        /// </summary>
        public Logger() => Start();

        public event PropertyChangedEventHandler PropertyChanged;

        private async void Start()
        {
            var rand = new Random();
            while (true)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));

                // example of updating a collection
                if (MyQueue.Count > 10)
                    MyQueue.RemoveAt(0);
                MyQueue.Add(rand.Next(10));
                OnPropertyChanged(nameof(MyQueue));

                // example of updating a string
                if (Name == "Stevie")
                    Name = "Billy";
                else
                    Name = "Stevie";
            }
        }
    }
}
