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
using SweetAlertSharp;
using SweetAlertSharp.Enums;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlNuevoProveedor.xaml
    /// </summary>
    public partial class UserControlNuevoProveedor : UserControl
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
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
                SweetAlert.Show("Operación Realizada", "El nuevo proveedor fue registrado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al registrar el nuevo proveedor", SweetAlertButton.OK, SweetAlertImage.ERROR);
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
                SweetAlert.Show("Operación Realizada", "El proveedor fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al modificar los datos del proveedor", SweetAlertButton.OK, SweetAlertImage.ERROR);
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
            btn_nuevo_prov.IsEnabled = true;
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
                SweetAlert.Show("Operación Realizada", "El proveedor fue eliminado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar el proveedor", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void btn_buscar_prov_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("buscarProveedor", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("buscarProv", OracleType.VarChar).Value = txt_buscar_prov.Text;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dg_prov.ItemsSource = tabla.DefaultView;

            }
            catch
            {
                SweetAlert.Show("Error al buscar", "Hubo un problema al buscar el proveedor", SweetAlertButton.YesNo, SweetAlertImage.INFORMATION);
            }
            conexion.Close();
        }

        private void dg_prov_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_prov.Text = dr.Row.ItemArray[0].ToString();
                txt_nombre_prov.Text = dr.Row.ItemArray[1].ToString();
                txt_prov_razon.Text = dr.Row.ItemArray[2].ToString();

                btn_nuevo_prov.IsEnabled = false;
                btn_eliminar_prov.IsEnabled = true;
                btn_editar_prov.IsEnabled = true;

            }
        }
    }
}
