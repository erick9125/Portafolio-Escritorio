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
using System.Data.OracleClient;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlNuevoCliente.xaml
    /// </summary>
    public partial class UserControlNuevoCliente : UserControl
    {

        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= 1234; USER ID= ERICK;");
        public UserControlNuevoCliente()
        {
            InitializeComponent();
        }

        private void TextBox_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarPersonas", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgNuevoCliente.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_nuevo_cli_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarCliente", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_rut", OracleType.VarChar).Value = txt_rut_cli.Text;
                comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = txt_nombre_cli.Text;
                comando.Parameters.Add("p_mail", OracleType.VarChar).Value = txt_correo_cli.Text;
                comando.Parameters.Add("p_estado", OracleType.Char).Value = txt_estado_cli.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Insertada Correctamente");
            }
            catch(Exception)
            {
                MessageBox.Show("Error al insertar el nuevo cliente");
            }

            conexion.Close();
        }
    }
}
