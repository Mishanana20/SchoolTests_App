using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Login_App.model
{
    public class Answer : INotifyPropertyChanged 
    {
        private string answerText;
        private bool isTrue;

        public string AnswerText 
        {
            get { return answerText; }
            set
            {
                answerText = value;
                OnPropertyChanged("AnswerText");
            }
        }
        public bool IsTrue 
        {
            get { return isTrue; }
            set
            {
                isTrue = value;
                OnPropertyChanged("IsTrue");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Answer(string answerText, bool isTrue)
        {
            this.answerText = answerText;
            this.isTrue = isTrue;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
