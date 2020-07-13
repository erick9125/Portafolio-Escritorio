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
    /// Lógica de interacción para menu2.xaml
    /// </summary>
    public partial class menu2 : Window
    {
        public menu2()
        {
            InitializeComponent();

            var menuProducto = new List<SubItem>();
            menuProducto.Add(new SubItem("Nuevo código de barra", new UserControlCodigoBarra()));
            var item4 = new ItemMenu("Productos", menuProducto, PackIconKind.BasketFill);

            var menuDeuda = new List<SubItem>();
            menuDeuda.Add(new SubItem("Ver estado deuda", new UserControlEstadoDeuda()));
            var item3 = new ItemMenu("Deudas", menuDeuda, PackIconKind.Money);

            Menu2.Children.Add(new UserControlMenuItem3(item4, this));
            Menu2.Children.Add(new UserControlMenuItem3(item3, this));

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

        private void btn_minimizar_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow principal = new MainWindow();
            principal.Show();
            this.Close();
        }
    }
}
