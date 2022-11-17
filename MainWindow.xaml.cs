using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.IO;

namespace Login_App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            CreateStartDirectory();
            ReadNameFromFile();
        }

        private void CreateStartDirectory()
        {
            string currentPath = Directory.GetCurrentDirectory();
            if (!Directory.Exists(System.IO.Path.Combine(currentPath, "Datafolder")))
                Directory.CreateDirectory(System.IO.Path.Combine(currentPath, "Datafolder"));
            currentPath = System.IO.Path.Combine(currentPath, "Datafolder");
            if (!File.Exists(System.IO.Path.Combine(currentPath, "username.txt")))
            {
                File.Create(System.IO.Path.Combine(currentPath, "username.txt"));
            }
        }

        private void ReadNameFromFile()
        {
            string currentPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Datafolder");
            if (File.Exists(System.IO.Path.Combine(currentPath, "username.txt")))
            {
                TxtLogin.Text = GetString(0, System.IO.Path.Combine(currentPath, "username.txt"));
                TxtPassword.Text = GetString(1, System.IO.Path.Combine(currentPath, "username.txt"));
            }
        }

        public string GetString(int numberString, string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string result = "";
                for (int i = 0; i <= numberString; i++)
                {
                    result = reader.ReadLine();
                }
                reader.Close();
               return result;
            }
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

        private void AddFiles_Click(object sender, RoutedEventArgs e)
        {
            DandD_AddFiles dandD_AddFiles = new DandD_AddFiles();
            dandD_AddFiles.Show();
        }
            //если поля пустые, то мессадж бокс
            private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((!string.IsNullOrEmpty(TxtPassword.Text) && TxtPassword.Text.Length > 0)
                && (!string.IsNullOrEmpty(TxtLogin.Text) && TxtLogin.Text.Length > 0))
            {
                string currentPath = Directory.GetCurrentDirectory();
                if (!Directory.Exists(System.IO.Path.Combine(currentPath, "Datafolder")))
                    Directory.CreateDirectory(System.IO.Path.Combine(currentPath, "Datafolder"));

                currentPath = System.IO.Path.Combine(currentPath, "Datafolder");
               
                using (StreamWriter writer = new StreamWriter(System.IO.Path.Combine(currentPath, "username.txt"), false))
                {
                    writer.WriteLine(TxtLogin.Text);
                    writer.WriteLine(TxtPassword.Text);
                    writer.Close();
                }
                this.Hide();
                MainMenu taskWindow = new MainMenu();
                taskWindow.Show();

                this.Close();
            }
            else
            {
                Warning warning = new Warning("Введите Имя, Фамилию и Класс учащегося");
                warning.Show();
            }
        }
    }
}
