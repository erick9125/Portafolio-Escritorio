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
using System.Timers;
using System.Threading;
using SweetAlertSharp;
using SweetAlertSharp.Enums;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlNuevoCliente.xaml
    /// </summary>
    public partial class UserControlNuevoCliente : UserControl
    {
        [Obsolete]
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
                SweetAlert.Show("Operación Realizada", "El cliente fue registrado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch(Exception)
            {
                SweetAlert.Show("Error", "Error al registrar cliente" , SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
        }

        private void btn_editar_cli_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            conexion.Open();
            OracleCommand comando = new OracleCommand("actualizarCliente", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idCli", OracleType.VarChar).Value = txt_id.Text;
            comando.Parameters.Add("rutCli", OracleType.VarChar).Value = txt_rut_cli.Text;
            comando.Parameters.Add("nomCli", OracleType.VarChar).Value = txt_nombre_cli.Text;
            comando.Parameters.Add("mailCli", OracleType.VarChar).Value = txt_correo_cli.Text;
            comando.Parameters.Add("estCli", OracleType.Char).Value = txt_estado_cli.Text;
            comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El cliente fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
        }
            catch(Exception)
            {
                SweetAlert.Show("Error", "Error al modificar los datos del cliente", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
        }

        private void btn_eliminar_cli_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            conexion.Open();
            OracleCommand comando = new OracleCommand("eliminarCliente", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("idCli", OracleType.VarChar).Value = txt_id.Text;
            comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El cliente fue eliminado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch(Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar el cliente", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();

        }

        private void btn_buscar_cli_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("buscarPersonas", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("buscarPer", OracleType.VarChar).Value = txt_buscar.Text;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgNuevoCliente.ItemsSource = tabla.DefaultView;

            }
            catch
            {
                SweetAlert.Show("Error al buscar", "Hubo un problema al buscar el cliente", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void resetAll()
        {
            txt_id.Text = "";
            txt_rut_cli.Text = "";
            txt_nombre_cli.Text = "";
            txt_correo_cli.Text = "";
            txt_estado_cli.Text = "";
        }

        private void btn_refrescar_Click_1(object sender, RoutedEventArgs e)
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
            btn_nuevo_cli.IsEnabled = true;
        }

        private void dgNuevoCliente_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id.Text = dr.Row.ItemArray[0].ToString();
                txt_rut_cli.Text = dr.Row.ItemArray[1].ToString();
                txt_nombre_cli.Text = dr.Row.ItemArray[2].ToString();
                txt_correo_cli.Text = dr.Row.ItemArray[3].ToString();
                txt_estado_cli.Text = dr.Row.ItemArray[4].ToString();
             
                btn_nuevo_cli.IsEnabled = false;
                btn_eliminar_cli.IsEnabled = true;
                btn_editar_cli.IsEnabled = true;

            }
        }

    }
}
