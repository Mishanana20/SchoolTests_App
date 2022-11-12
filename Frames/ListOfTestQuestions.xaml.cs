using Login_App.DataBase;
using Login_App.model;
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

namespace Login_App.Frames
{
    /// <summary>
    /// Логика взаимодействия для ListOfTestQuestions.xaml
    /// </summary>
    public partial class ListOfTestQuestions : Page
    {
        List<Question> questions = new List<Question>();
        string dataBaseName = "usersdata";

        public ListOfTestQuestions(string databaseName)
        {
            dataBaseName = databaseName;
            InitializeComponent();
            Loaded += TestAddAnswers_Loaded;
        }
        public void TestAddAnswers_Loaded(object sender, RoutedEventArgs e)
        {
            questions = Connection.TestConnectionToDatabase(dataBaseName);
            AnswerList.ItemsSource = questions;
        }
    }
}
