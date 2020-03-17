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
using StagingNew;

namespace StagingNew
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       

        public MainWindow()
        {
            InitializeComponent();
        }

        private  Dictionary<string, double> GetWallParameters()
        {
            var parameters = new Dictionary<string, double>(2)
            {
                ["wall_height"] = Convert.ToDouble(WallHeightInput.Text),
                ["wall_width"] = Convert.ToDouble(WallWidthInput.Text)
            };

            return parameters;
        }

      
        private void StartInput(object sender, RoutedEventArgs e)
        {
            TextBox text_box = sender as TextBox;
            if(text_box.Text == "Height of the wall" || text_box.Text == "Width of the wall")
            {
                text_box.Clear();
            }
            
        }

        private void ReWriteTooltip(object sender, RoutedEventArgs e)
        {
            TextBox text_box = sender as TextBox;
            if (text_box.Text == "" || text_box.Text == " ")
            {
                if(text_box.Name == "WallHeightInput")
                {
                    text_box.Text = "Height of the wall";
                }
                else if(text_box.Name == "WallWidthInput")
                {
                    text_box.Text = "Width of the wall";
                }
            }
        }

        private void CalculateClick(object sender, RoutedEventArgs e)
        {
            Program program = new Program(GetWallParameters());
            Staging result = program.Calculate();
            
        }
    }
}
