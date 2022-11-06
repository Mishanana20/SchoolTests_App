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
using System.Windows.Shapes;

namespace Login_App
{
    /// <summary>
    /// Логика взаимодействия для ConfirmationWindow.xaml
    /// </summary>
    public partial class ConfirmationWindow : Window
    {
        public string ConfitmitionText { get; set; } = " ntntnntt";

        public ConfirmationWindow(string myText)
        {
            ConfitmitionText = String.Concat("Вы действительно хотите начать тест \"", myText, "\"?");
            InitializeComponent();
            ConfitmitionTextBlock.Text = ConfitmitionText;
        }


        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ButtonNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
