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
            menuUsuarios.Add(new SubItem("Nuevo Cliente", new UserControlNuevoCliente()));
            menuUsuarios.Add(new SubItem("Roles de usuario", new UserControlRoles()));
            menuUsuarios.Add(new SubItem("Asignar contraseña", new UserControlAsignarPass()));
            var item6 = new ItemMenu("Usuarios", menuUsuarios, PackIconKind.Register);

            var menuProveedores = new List<SubItem>();
            menuProveedores.Add(new SubItem("Registrar Proveedor", new UserControlNuevoProveedor()));
            menuProveedores.Add(new SubItem("Registrar nuevo producto", new UserControlNuevoProducto()));
            menuProveedores.Add(new SubItem("Asignar Precio Producto", new UserControlAsignarPrecio()));
            menuProveedores.Add(new SubItem("Recepcionar pedido", new UserControlRecepcionarPedido()));
            menuProveedores.Add(new SubItem("Nuevo código de barra", new UserControlCodigoBarra()));
            var item1 = new ItemMenu("Proveedores", menuProveedores, PackIconKind.AccountHardHat);

            var menuReportes = new List<SubItem>();
            menuReportes.Add(new SubItem("Deudas", new UserControlReporteDeudas()));
            menuReportes.Add(new SubItem("Proveedores", new UserControlReporteProveedores()));
            menuReportes.Add(new SubItem("Stock", new UserControlReporteStock()));
            menuReportes.Add(new SubItem("Ventas", new UserControlReporteVentas()));
            var item2 = new ItemMenu("Reportes", menuReportes, PackIconKind.FileReport);


            var menuEstadisticas = new List<SubItem>();
            menuEstadisticas.Add(new SubItem("Estadistica Ventas", new UserControlEstadisticaVenta()));
            menuEstadisticas.Add(new SubItem("Estadistica Pedidos", new UserControlEstadisticaPedido()));
            menuEstadisticas.Add(new SubItem("Estadistica Pagos", new UserControlEstadisticaPago()));
            var item4 = new ItemMenu("Estadisticas", menuEstadisticas, PackIconKind.ChartLine);

            var menuDeuda = new List<SubItem>();
            menuDeuda.Add(new SubItem("Ver estado deuda", new UserControlEstadoDeuda()));
            var item3 = new ItemMenu("Deudas", menuDeuda, PackIconKind.Money);

            

            //var item0 = new ItemMenu("Home", new UserControl(), PackIconKind.Home);

            // Menu.Children.Add(new UserControlMenuItem(item0, this));
            Menu.Children.Add(new UserControlMenuItem(item6, this));
            Menu.Children.Add(new UserControlMenuItem(item1, this));
            Menu.Children.Add(new UserControlMenuItem(item2, this));
            Menu.Children.Add(new UserControlMenuItem(item4, this));
            Menu.Children.Add(new UserControlMenuItem(item3, this));
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
    }
}
