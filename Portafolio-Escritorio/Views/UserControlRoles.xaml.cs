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
    /// Lógica de interacción para UserControlRoles.xaml
    /// </summary>
    public partial class UserControlRoles : UserControl
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlRoles()
        {
            InitializeComponent();
        }

        private void dgvRoles_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarPersonasRol", conexion);
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
            if (txt_id_rol.Text != "" && txt_id_rol_user.Text != "")
            {
                try
                {
                    conexion.Open();
                    OracleCommand comando = new OracleCommand("insertarRol", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_id", OracleType.Number).Value = txt_id_rol_user.Text;
                    comando.Parameters.Add("p_idRol", OracleType.Number).Value = txt_id_rol.Text;
                    comando.ExecuteNonQuery();
                    SweetAlert.Show("Operación Realizada", "Se ha asignado el Rol al usuario seleccionado con exito!", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                    this.resetAll();
                }
                catch (Exception ex)
                {
                    SweetAlert.Show("Error", "Error al asignar el Rol", SweetAlertButton.OK, SweetAlertImage.ERROR);
                    MessageBox.Show(ex.ToString());
                }

                conexion.Close();
            }
            else
            {
                SweetAlert.Show("Error", "No pueden estar vacios los campos de texto antes de asignar un Rol", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

        }

        private void dgvRoles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_rol_user.Text = dr.Row.ItemArray[0].ToString();
            }
        }

        private void cb_roles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cb_roles.SelectedItem).Row.ItemArray[0].ToString();
            txt_id_rol.Text = valor;
        }

        private void resetAll()
        {
            txt_buscar_rol.Text = "";
            txt_id_rol.Text = "";
            txt_id_rol_user.Text = "";

        }

        private void btn_editar_rol_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarRolAsignado", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idRUser", OracleType.VarChar).Value = txt_id_rol_user.Text;
                comando.Parameters.Add("idRol", OracleType.VarChar).Value = txt_id_rol.Text;
                

                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El rol asignado fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al modificar El rol asignado", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
        }


            private void btn_nuevo_rol_Click(object sender, RoutedEventArgs e)
        {
            Views.NuevoRol rol = new NuevoRol();
            rol.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarPersonasRol", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvRoles.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }
    }
}
