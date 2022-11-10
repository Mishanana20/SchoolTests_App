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
using System.IO;

namespace Login_App
{
    /// <summary>
    /// Логика взаимодействия для DandD_AddFiles.xaml
    /// </summary>
    public partial class DandD_AddFiles : Window
    {
        public DandD_AddFiles()
        {
            InitializeComponent();
        }


        private void text_PreviewDragEnter(object sender, DragEventArgs e)
        {
            bool isCorrect = true;

            if (e.Data.GetDataPresent(DataFormats.FileDrop, true) == true)
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                foreach (string filename in filenames)
                {
                    if (File.Exists(filename) == false)
                    {
                        isCorrect = false;
                        break;
                    }
                    FileInfo info = new FileInfo(filename);
                    if (info.Extension != ".db")
                    {
                        isCorrect = false;
                        break;
                    }
                }
            }
            if (isCorrect == true)
                e.Effects = DragDropEffects.All;
            else
                e.Effects = DragDropEffects.None;
            e.Handled = true;
        }

        private void text_PreviewDrop(object sender, DragEventArgs e)
        {
            string currentPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "Datafolder");

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
           
            string s = System.IO.Path.GetFullPath(files[0]);
            string newPath = System.IO.Path.Combine(currentPath, System.IO.Path.GetFileName(files[0]));
            File.Copy(s, newPath, true);


            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, true);
            foreach (string filename in filenames)
                text.Text += $"{System.IO.Path.GetFileNameWithoutExtension(filename)} \n";
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
