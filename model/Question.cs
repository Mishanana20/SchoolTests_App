using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Login_App.model
{
    public class Question : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int NumberQuestion { get; set; }
        public string QuestionText { get; set; }
        public List<Answer> AnswerList { get; set; } = new List<Answer>();

        public event PropertyChangedEventHandler PropertyChanged;

        public Question(int id, int numberQuestion, string questionText)
        {
            this.Id = id;
            this.NumberQuestion = numberQuestion;
            this.QuestionText = questionText;
            this.AnswerList = new List<Answer>();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
