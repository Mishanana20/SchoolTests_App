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
using WPFAppNote.model;
using SqlConn;
using WPFAppNote.DBSQL;
using System.Reflection;

namespace WPFAppNote
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DBUtils.GetDBConnection();
            SQLConnection Notes = new SQLConnection();
            Notes.OpenConnection();
            if (Notes.ItemList.Any())
            { 
                Console.WriteLine(Notes.ItemList.Count); 
            }
            Notes.GetAllItems();
            foreach (var item in Notes.ItemList)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.NoteText);
                Console.WriteLine(item.NoteTitle);
                Console.WriteLine(item.ColorText);
                Console.WriteLine(item.NoteCreateDateTime);
                Console.WriteLine(item.MenuTitle);
            }


            Notes.CloseConnection();
            InitializeComponent();
        }
    }
}
