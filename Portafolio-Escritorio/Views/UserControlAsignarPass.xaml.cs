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
    /// Lógica de interacción para UserControlAsignarPass.xaml
    /// </summary>
    public partial class UserControlAsignarPass : UserControl
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlAsignarPass()
        {
            InitializeComponent();
        }

        private void dgv_pass_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SeleccionarPersonaUsuario", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_pass.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_guardar_pass_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nueva_pass.Text.Length >= 8)
            {
                try
                {
                    conexion.Open();
                    OracleCommand comando = new OracleCommand("insertarPass", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.VarChar).Value = txt_id_pass.Text;
                    comando.Parameters.Add("p_pass", OracleType.VarChar).Value = txt_nueva_pass.Text;
                    comando.ExecuteNonQuery();
                    SweetAlert.Show("Operación Realizada", "La nueva contraseña fue asignada con exito!", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                    this.resetAll();
                }
                catch (Exception)
                {
                    SweetAlert.Show("Error", "Ocurrio un problema al asignar la nueva contraseña", SweetAlertButton.OK, SweetAlertImage.ERROR);
                    this.resetAll();
                }

                conexion.Close();
            }
            else
            {
                SweetAlert.Show("Error", "La contraseña debe tener un minimo de 8 digitos", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
           
        }

        private void resetAll()
        {
            txt_id_pass.Text = "";
            txt_nueva_pass.Text = "";
            txt_buscar_pass.Text = "";
            

        }

        private void dgv_pass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_pass.Text = dr.Row.ItemArray[0].ToString();
                txt_nueva_pass.Text = dr.Row.ItemArray[4].ToString();
                
                if(txt_nueva_pass.Text =="")
                {
                    btn_edit_pass.IsEnabled = false;
                    btn_guardar_pass.IsEnabled = true;
                } 
                else
                {
                    btn_edit_pass.IsEnabled = true;
                    btn_guardar_pass.IsEnabled = false;
                }


            }
        }

        private void btn_buscar_pass_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("buscarPersonas", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idCli", OracleType.VarChar).Value = txt_buscar_pass.Text;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgv_pass.ItemsSource = tabla.DefaultView;

            }
            catch
            {
                SweetAlert.Show("Error al buscar", "Hubo un problema al buscar el cliente", SweetAlertButton.YesNo, SweetAlertImage.INFORMATION);
            }
            conexion.Close();
        }

        private void btn_edit_pass_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarPass", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idPer", OracleType.Number).Value = txt_id_pass.Text;
                comando.Parameters.Add("passCh", OracleType.VarChar).Value = txt_nueva_pass.Text;
               

                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "La contraseña fue cambiada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al modificar la contraseña del usuario seleccionado", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SeleccionarPersonaUsuario", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_pass.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }
    }
}
