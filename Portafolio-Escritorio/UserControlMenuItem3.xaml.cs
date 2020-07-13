﻿using Portafolio_Escritorio.Models;
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
using Portafolio_Escritorio.Views;

namespace Portafolio_Escritorio
{
    /// <summary>
    /// Lógica de interacción para UserControlMenuItem3.xaml
    /// </summary>
    public partial class UserControlMenuItem3 : UserControl
    {
        Views.menu2 _context;

        public UserControlMenuItem3(ItemMenu itemMenu, Views.menu2 context)
        {
            InitializeComponent();

            context = context;

            ExpanderMenu.Visibility = itemMenu.SubItems == null ? Visibility.Collapsed : Visibility.Visible;
            ListViewItemMenu.Visibility = itemMenu.SubItems == null ? Visibility.Visible : Visibility.Collapsed;

            this.DataContext = itemMenu;
        }

        private void ListViewMenu2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _context.SwitchScreen(((SubItem)((ListView)sender).SelectedItem).Screen);
        }
    }
}
