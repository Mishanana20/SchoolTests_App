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
        private int id;
        private int numberQuestion;
        private string questionText;
        private List<Answer> answerList;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public int NumberQuestion
        {
            get { return numberQuestion; }
            set
            {
                numberQuestion = value;
                OnPropertyChanged("NumberQuestion");
            }
        }
        public string QuestionText
        {
            get { return questionText; }
            set
            {
                questionText = value;
                OnPropertyChanged("QuestionText");
            }
        }
        public List<Answer> AnswerList
        {
            get { return answerList; }
            set
            {
                answerList = value;
                OnPropertyChanged("AnswerList");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Question(int id, int numberQuestion, string questionText)
        {
            this.id = id;
            this.numberQuestion = numberQuestion;
            this.questionText = questionText;
            this.answerList = new List<Answer>();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
