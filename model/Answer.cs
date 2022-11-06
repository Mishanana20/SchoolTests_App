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
        public string AnswerText { get; set; }
        public bool IsTrue { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Answer(string answerText, bool isTrue)
        {
            this.AnswerText = answerText;
            this.IsTrue = isTrue;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
