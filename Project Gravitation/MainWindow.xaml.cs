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
using Project_Gravitation.Classes;
using Project_Gravitation.Pages;

namespace Project_Gravitation
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public Option option;
        public Page1 mainPage;
        public MainWindow()
        {
            InitializeComponent();
            option = new Option(this);
            mainPage = new Page1(this);
            frame.NavigationService.Navigate(mainPage); 
            
        }

     
    }
}
