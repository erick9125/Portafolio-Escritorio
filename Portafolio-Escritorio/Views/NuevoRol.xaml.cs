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
using System.Data.OracleClient;
using System.Data;
using SweetAlertSharp;
using SweetAlertSharp.Enums;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para NuevoRol.xaml
    /// </summary>
    public partial class NuevoRol : Window
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public NuevoRol()
        {
            InitializeComponent();
        }

        private void btn_volver_rol_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dg_nuevo_rol_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarNuevoRol", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_nuevo_rol.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void dg_nuevo_rol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_nuevo_rol.Text = dr.Row.ItemArray[0].ToString();
                txt_nuevo_rol.Text = dr.Row.ItemArray[1].ToString();

                if (txt_nuevo_rol.Text == "")
                {
                    btn_editar_rol.IsEnabled = false;
                    btn_eliminar_rol.IsEnabled = false;
                }
                else
                {
                    btn_editar_rol.IsEnabled = true;
                    btn_eliminar_rol.IsEnabled = true;
                    btn_registrar_rol.IsEnabled = false;
                }


            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarNuevoRol", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_nuevo_rol.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }


        private void resetAll()
        {
            txt_id_nuevo_rol.Text = "";
            txt_nuevo_rol.Text = "";


        }

        private void btn_registrar_rol_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nuevo_rol.Text.Length >= 4)
            {
                try
                {
                    conexion.Open();
                    OracleCommand comando = new OracleCommand("insertarNuevoRol", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nomb", OracleType.VarChar).Value = txt_nuevo_rol.Text;
                    comando.ExecuteNonQuery();
                    SweetAlert.Show("Operación Realizada", "Rol registrado con exito!", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                    this.resetAll();
                }
                catch (Exception)
                {
                    SweetAlert.Show("Error", "Ocurrio un problema al registrar el nuevo rol", SweetAlertButton.OK, SweetAlertImage.ERROR);
                    this.resetAll();
                }

                conexion.Close();
            }
            else
            {
                SweetAlert.Show("Error", "El nuevo rol debe tener un minimo de 4 caracteres", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
        }

        private void btn_editar_rol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarRol", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idR", OracleType.Number).Value = txt_id_nuevo_rol.Text;
                comando.Parameters.Add("nombR", OracleType.VarChar).Value = txt_nuevo_rol.Text;


                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El rol fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al modificar el rol del usuario seleccionado", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
        }

        private void btn_eliminar_rol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminarRol", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idRol", OracleType.Number).Value = txt_id_nuevo_rol.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El ROL fue eliminado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar el ROL seleccionado", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }
    }
}
