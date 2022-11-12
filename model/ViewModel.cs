using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Login_App.model
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private int maxNumberQuestion;
        private Question question;
        private int currentNumberQuestion;

        public int MaxNumberQuestion
        {
            get { return maxNumberQuestion; }
            set { maxNumberQuestion = value; OnPropertyChanged(); }
        }

        public int CurrentNumberQuestion
        {
            get { return currentNumberQuestion; }
            set { currentNumberQuestion = value; OnPropertyChanged(); }
        }

        public Question Question
        {
            get { return question; }
            set { question = value; OnPropertyChanged(); }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
