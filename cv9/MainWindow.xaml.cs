﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using cv09;

namespace cv9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator = new Calculator();
        public MainWindow()
        {
            
            InitializeComponent();
            display.Text = calculator.Display; 
            memory.Text = calculator.Memory;
        }

        private void Button_Click(object sender, RoutedEventArgs e) 
        { 
            calculator.Button((sender as Button).Content.ToString()); 
            display.Text = calculator.Display; memory.Text = calculator.Memory; 
        }
    }
}