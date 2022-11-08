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
        public Test(string databaseName)
        {
            dataBaseName = databaseName;
            questions = Connection.TestConnectionToDatabase(dataBaseName);
            currentQuestion = questions[0];
            answers = questions[0].AnswerList;
            this.DataContext = currentQuestion;
            InitializeComponent();
            Loaded += TestAddAnswers_Loaded;

        }
        public void TestAddAnswers_Loaded(object sender, RoutedEventArgs e)
        {
            AnswerList.ItemsSource= answers;
        }

        public void NextQuestion_Click(object sender, RoutedEventArgs e)
        {
            Warning warning = new Warning($"{isTrueCheked}");
            warning.Show();
            isTrueCheked = false;
        }

        private void isTrueGroup_Checked(object sender, RoutedEventArgs e)
        {
            var answer = (Answer)((RadioButton)sender).Tag;
            RadioButton pressed = (RadioButton)sender;
            isTrueCheked = answer.IsTrue;
        }
    }




}
