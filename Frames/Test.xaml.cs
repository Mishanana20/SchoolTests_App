using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Login_App.model;
using Login_App.DataBase;

namespace Login_App.Frames
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Page
    {
        List<Question> questions = new List<Question>();
        Question currentQuestion;
        List<Answer> answers = new List<Answer>();
        bool isTrueCheked = false;
        string dataBaseName = "usersdata";
        int currentNumber = 0;
        ViewModel viewModel = new ViewModel();
        int maxNubmer;
        int currentBall = 0;


        public Test(string databaseName)
        {
          
            dataBaseName = databaseName;
            questions = Connection.TestConnectionToDatabase(dataBaseName);
            maxNubmer = questions.Count();
            currentQuestion = questions[currentNumber];
            answers = questions[currentNumber].AnswerList;
            this.DataContext = viewModel;
            InitializeComponent();
            Loaded += TestAddAnswers_Loaded;

        }
        public void TestAddAnswers_Loaded(object sender, RoutedEventArgs e)
        {
            AnswerList.ItemsSource = answers;
        }

        public void NextQuestion_Click(object sender, RoutedEventArgs e)
        {
            //Warning warning = new Warning($"{isTrueCheked}");
            //warning.Show();
            if (currentNumber < maxNubmer -1)
            {
                if(isTrueCheked)
                {
                    currentBall++;
                }
                currentNumber++;
                viewModel.TextBoxValue = currentNumber+1;
                currentQuestion = questions[currentNumber];
                answers = questions[currentNumber].AnswerList;
                //this.DataContext = currentQuestion;
                AnswerList.ItemsSource = answers;
                isTrueCheked = false;
            }
            else 
            {
                Warning warning = new Warning($"Ваши баллы: {currentBall}/{maxNubmer}");
                warning.Show();
            }
        }

        private void isTrueGroup_Checked(object sender, RoutedEventArgs e)
        {
            var answer = (Answer)((RadioButton)sender).Tag;
            RadioButton pressed = (RadioButton)sender;
            isTrueCheked = answer.IsTrue;
        }
    }




}
