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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf;
using Portafolio_Escritorio.Models;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para menu3.xaml
    /// </summary>
    public partial class menu3 : Window
    {
        public menu3()
        {
            InitializeComponent();
           

            var menuReportes = new List<SubItem>();
            menuReportes.Add(new SubItem("Deudas", new UserControlReporteDeudas()));
            menuReportes.Add(new SubItem("Proveedores", new UserControlReporteProveedores()));
            menuReportes.Add(new SubItem("Stock", new UserControlReporteStock()));
            menuReportes.Add(new SubItem("Ventas", new UserControlReporteVentas()));
            var item2 = new ItemMenu("Reportes", menuReportes, PackIconKind.FileReport);

            //var item0 = new ItemMenu("Home", new UserControl(), PackIconKind.Home);

            // Menu.Children.Add(new UserControlMenuItem(item0, this));
             Menu3.Children.Add(new UserControlMenuItem2(item2, this));
          
          
           
        }

        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_manuales_Click(object sender, RoutedEventArgs e)
        {
            manuales manuales = new manuales();
            manuales.Show();
        }

        private void btn_ayuda_Click(object sender, RoutedEventArgs e)
        {
            soporte soporte = new soporte();
            soporte.Show();
        }
    }
    }

