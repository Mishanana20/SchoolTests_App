using System;
using System.Collections.Generic;
using System.IO;
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

namespace Login_App.Frames
{
    /// <summary>
    /// Логика взаимодействия для ListOfQuestions.xaml
    /// </summary>
    public partial class ListOfQuestions : Page
    {
        public List<TestName> testNames = new List<TestName>();

        public ListOfQuestions()
        {
            InitializeComponent();
            Loaded += TestAddElements_Loaded;
        }


        public void TestAddElements_Loaded(object sender, RoutedEventArgs e)
        {
            var dir = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}/datafolder"); // папка с файлами 

            foreach (FileInfo file in dir.GetFiles())
            {
                if (System.IO.Path.GetExtension(System.IO.Path.GetFileName(file.FullName)) == ".db")
                {
                    testNames.Add(new TestName { Name = System.IO.Path.GetFileNameWithoutExtension(file.FullName) });
                }
            }

            lbName.ItemsSource = testNames;
        }


        string currentTestName;
        public void StartTest_Click(object sender, RoutedEventArgs e)
        {
            var person = (TestName)((Button)sender).Tag;
            currentTestName = person.Name;
            ListOfTestQuestions listOfTestQuestions = new ListOfTestQuestions(currentTestName);
            NavigationService.Navigate(listOfTestQuestions);
        }

    }
}
