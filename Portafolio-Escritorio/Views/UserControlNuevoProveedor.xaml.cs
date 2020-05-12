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
    /// Lógica de interacción para UserControlNuevoProveedor.xaml
    /// </summary>
    public partial class UserControlNuevoProveedor : UserControl
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= 1234; USER ID= ERICK;");
        public UserControlNuevoProveedor()
        {
            InitializeComponent();
        }

        private void uc_proveedor_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarProveedores", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_prov.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_nuevo_prov_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarProveedor", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = txt_nombre_prov.Text;
                comando.Parameters.Add("p_razon_social", OracleType.VarChar).Value = txt_prov_razon.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor Agregado Correctamente");
                this.resetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar el nuevo proveedor");
            }

            conexion.Close();
        }

        private void btn_editar_prov_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarProveedor", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idProv", OracleType.VarChar).Value = txt_id_prov.Text;
                comando.Parameters.Add("nomProv", OracleType.VarChar).Value = txt_nombre_prov.Text;
                comando.Parameters.Add("razonProv", OracleType.VarChar).Value = txt_prov_razon.Text;
                
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor Actualizado Correctamente");
                this.resetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al actualizar el Proveedor");
            }

            conexion.Close();
        }

        private void resetAll()
        {
            txt_id_prov.Text = "";
            txt_nombre_prov.Text = "";
            txt_prov_razon.Text = "";
            
        }

        private void btn_refresh_prov_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarProveedores", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_prov.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_eliminar_prov_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminarProveedor", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idProv", OracleType.VarChar).Value = txt_id_prov.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Proveedor Eliminado Correctamente");
                this.resetAll();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el proveedor");
            }
            conexion.Close();
        }
    }
}
