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
using System.Diagnostics;

namespace Login_App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtLogin.Focus();
        }

        private void TextLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtLogin.Text) && TxtLogin.Text.Length > 0)
            {
                TextLogin.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextLogin.Visibility = Visibility.Visible;
            }
        }

        private void TextPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtPassword.Focus();
        }

        private void TxtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPassword.Text) && TxtPassword.Text.Length > 0)
            {
                TextPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextPassword.Visibility = Visibility.Visible;
            }
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
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (TxtPassword.Text == "7-Б" && TxtLogin.Text == "Носик Михаил")
            //{
            //    MainMenu taskWindow = new MainMenu();
            //    taskWindow.Show();
            //}
            //else 
            //{
            //    MessageBox.Show("Неверное имя пользователя или класс учащегося");
            //}


            this.Hide();
            MainMenu taskWindow = new MainMenu();
            taskWindow.Show();
            
            this.Close();
        }
    }
}
