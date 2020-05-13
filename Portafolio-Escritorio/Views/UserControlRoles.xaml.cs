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
using System.Data.OracleClient;
using System.Data;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlRoles.xaml
    /// </summary>
    public partial class UserControlRoles : UserControl
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= 1234; USER ID= ERICK;");
        public UserControlRoles()
        {
            InitializeComponent();
        }

        private void dgvRoles_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarPersonas", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvRoles.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void cb_roles_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_ROL, NOMBRE_ROL from ROL order by ID_ROL asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_roles.ItemsSource = dt.AsDataView();
            cb_roles.DisplayMemberPath = "NOMBRE_ROL";
            cb_roles.SelectedValuePath = "ID_ROL";
            conexion.Close();
        }

        private void btn_buscar_cli_rol_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_guardar_rol_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
