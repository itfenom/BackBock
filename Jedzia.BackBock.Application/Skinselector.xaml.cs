﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jedzia.BackBock.Application
{
    /// <summary>
    /// Interaction logic for Skinselector.xaml
    /// </summary>
    public partial class Skinselector : UserControl
    {
        public Skinselector()
        {
            InitializeComponent();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {

            selectSkin.ItemsSource = ThemeManager.GetSkins();
        }

        private void selectSkin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ThemeManager.ChangeTheme(e.AddedItems[0] as string);
        }

    }
}
