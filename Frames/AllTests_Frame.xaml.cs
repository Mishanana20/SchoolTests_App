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
    /// Логика взаимодействия для AllTests_Frame.xaml
    /// </summary>
    public partial class AllTests_Frame : Page
    {
        public List<TestName> testNames = new List<TestName>();

        public AllTests_Frame()
        {
            InitializeComponent();
            Loaded += TestAddElements_Loaded;
        }


        public void TestAddElements_Loaded(object sender, RoutedEventArgs e)
        {
            //TestName bio = new TestName() { Name = "First Test", Text = "Description for the Ferst Text" };
            //bio.Name = "First Test"; bio.Text = "Description for the Ferst Text";
            //testNames.Add(bio);
            //testNames.Add(new TestName { Name = "usersdata" });
            //testNames.Add(new TestName { Name = "Биология", Text = "Первый тест по биологии" });
            //testNames.Add(new TestName { Name = "География", Text = "Контрольная до 25-11-22" });
            //testNames.Add(new TestName { Name = "Математика", Text = "Тест для повторения основ" });
            //testNames.Add(new TestName { Name = "Биология", Text = "Первый тест по биологии" });
            //testNames.Add(new TestName { Name = "География", Text = "Контрольная до 25-11-22" });
            //testNames.Add(new TestName { Name = "Математика", Text = "Тест для повторения основ" });
            //testNames.Add(new TestName { Name = "usersdata", Text = "тест с базой данных" });
            //testNames.Add(new TestName { Name = "География", Text = "Контрольная до 25-11-22" });
            //testNames.Add(new TestName { Name = "Математика", Text = "Тест для повторения основ" });


            var dir = new DirectoryInfo($"{AppDomain.CurrentDomain.BaseDirectory}/datafolder"); // папка с файлами 

            foreach (FileInfo file in dir.GetFiles())
            {
                if (System.IO.Path.GetExtension(System.IO.Path.GetFileName(file.FullName)) == ".db" ) 
                { 
                    testNames.Add(new TestName { Name = System.IO.Path.GetFileNameWithoutExtension(file.FullName) }); 
                }  
            }

            lbName.ItemsSource = testNames;
            //lbName.ItemsSource = new object[] { bio };
        }




        string currentTestName;
        public void StartTest_Click(object sender, RoutedEventArgs e)
        {
            var person = (TestName)((Button)sender).Tag;

            //Warning warning = new Warning($"{person.name} {person.text}");
            ConfirmationWindow warning = new ConfirmationWindow($"{person.Name}");
            currentTestName = person.Name;
            warning.ButtonClicked += ConfirmarionYes_Click;
            warning.Show();

        }



        public void ConfirmarionYes_Click(object sender, EventArgs e)
        {
            Test test = new Test(currentTestName);
            NavigationService.Navigate(test);
        }
    }
}
