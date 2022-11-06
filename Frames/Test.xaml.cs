﻿using System;
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
        public Test()
        {
            questions = Connection.TestConnectionToDatabase();
            InitializeComponent();
        }
    }
}
