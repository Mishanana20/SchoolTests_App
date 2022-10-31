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
            TestName bio = new TestName() { name = "First Test", text = "Description for the Ferst Text"};
            bio.name = "First Test"; bio.text = "Description for the Ferst Text";
            testNames.Add(bio);
            testNames.Add(new TestName { name = "Биология", text = "Первый тест по биологии" });
            testNames.Add(new TestName { name = "География", text = "Контрольная до 25-11-22" });
            testNames.Add(new TestName { name = "Математика", text = "Тест для повторения основ" });
            testNames.Add(new TestName { name = "Биология", text = "Первый тест по биологии" });
            testNames.Add(new TestName { name = "География", text = "Контрольная до 25-11-22" });
            testNames.Add(new TestName { name = "Математика", text = "Тест для повторения основ" });
            testNames.Add(new TestName { name = "Биология", text = "Первый тест по биологии" });
            testNames.Add(new TestName { name = "География", text = "Контрольная до 25-11-22" });
            testNames.Add(new TestName { name = "Математика", text = "Тест для повторения основ" });
            lbName.ItemsSource = testNames;
            //lbName.ItemsSource = new object[] { bio };
        }
    }
}
