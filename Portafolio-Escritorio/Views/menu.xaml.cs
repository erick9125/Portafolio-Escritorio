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
using MaterialDesignThemes.Wpf;
using Portafolio_Escritorio.Models;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();

            var menuUsuarios = new List<SubItem>();
            menuUsuarios.Add(new SubItem("Nuevo Cliente"));
            menuUsuarios.Add(new SubItem("Ver Clientes"));
            menuUsuarios.Add(new SubItem("Roles de usuario"));
            var item6 = new ItemMenu("Usuarios", menuUsuarios, PackIconKind.Register);

            var menuProveedores = new List<SubItem>();
            menuProveedores.Add(new SubItem("Nuevo Proveedor"));
            menuProveedores.Add(new SubItem("Ver Proveedores"));
            var item1 = new ItemMenu("Proveedores", menuProveedores, PackIconKind.AccountHardHat);

            var menuReportes = new List<SubItem>();
            menuReportes.Add(new SubItem("Deudas"));
            menuReportes.Add(new SubItem("Proveedores"));
            menuReportes.Add(new SubItem("Productos"));
            menuReportes.Add(new SubItem("Stock"));
            menuReportes.Add(new SubItem("Ventas"));
            var item2 = new ItemMenu("Reportes", menuReportes, PackIconKind.FileReport);


            var menuEstadisticas = new List<SubItem>();
            menuEstadisticas.Add(new SubItem("Estadistica Ventas"));
            menuEstadisticas.Add(new SubItem("Estadistica Pedidos"));
            var item4 = new ItemMenu("Estadisticas", menuEstadisticas, PackIconKind.ChartLine);

            var item0 = new ItemMenu("Home", new UserControl(), PackIconKind.ViewDashboard);

            Menu.Children.Add(new UserControlMenuItem(item0));
            Menu.Children.Add(new UserControlMenuItem(item6));
            Menu.Children.Add(new UserControlMenuItem(item1));
            Menu.Children.Add(new UserControlMenuItem(item2));
            Menu.Children.Add(new UserControlMenuItem(item4));
        }
    }
}
