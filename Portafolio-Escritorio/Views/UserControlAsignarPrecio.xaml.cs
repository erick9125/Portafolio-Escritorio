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
using SweetAlertSharp;
using SweetAlertSharp.Enums;
using System.Data.OracleClient;
using System.Data;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlAsignarPrecio.xaml
    /// </summary>
    public partial class UserControlAsignarPrecio : UserControl
    {
        [Obsolete]
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlAsignarPrecio()
        {
            InitializeComponent();
        }

        private void dg_asignar_prec_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarProductosConPrecio", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_asignar_prec.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void dg_asignar_prec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_prod_asig.Text = dr.Row.ItemArray[0].ToString();
                txt_precio.Text = dr.Row.ItemArray[2].ToString();
                dp_fec_ini.Text = dr.Row.ItemArray[3].ToString();
                dp_fec_term.Text = dr.Row.ItemArray[4].ToString();

                if (txt_precio.Text == "")
                {
                btn_registrar_prec.IsEnabled = true;
                btn_editar_prec.IsEnabled = false;
                btn_eliminar_prec.IsEnabled = false;
                } else
                {
                    btn_registrar_prec.IsEnabled = false;
                    btn_editar_prec.IsEnabled = true;
                    btn_eliminar_prec.IsEnabled = true;
                }
                

            }
        }

        private void btn_registrar_prec_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarPrecio", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_precio", OracleType.Number).Value = txt_precio.Text;
                comando.Parameters.Add("p_fec_ini", OracleType.DateTime).Value = dp_fec_ini.SelectedDate;
                comando.Parameters.Add("p_fec_ter", OracleType.DateTime).Value = dp_fec_term.SelectedDate;
                comando.Parameters.Add("p_id_produ", OracleType.Number).Value = txt_id_prod_asig.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El Precio fue asignado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al asignar el nuevo precio", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
            btn_eliminar_prec.IsEnabled = true;
            btn_editar_prec.IsEnabled = true;
        }

        private void btn_editar_prec_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarPrecio", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idPre", OracleType.Number).Value = txt_id_prod_asig.Text;
                comando.Parameters.Add("fIniPre", OracleType.DateTime).Value = dp_fec_ini.SelectedDate;
                comando.Parameters.Add("fTerPre", OracleType.DateTime).Value = dp_fec_term.SelectedDate;
                comando.Parameters.Add("prec", OracleType.VarChar).Value = txt_precio.Text;
                
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El Precio fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al modificar el precio del producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
            btn_registrar_prec.IsEnabled = true;
        }

        private void btn_eliminar_prec_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminarPrecio", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idProdu", OracleType.Number).Value = txt_id_prod_asig.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El precio fue eliminado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar el precio del producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void btn_refrescar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarProductosConPrecio", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_asignar_prec.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void resetAll()
        {
            txt_id_prod_asig.Text = "";
            txt_precio.Text = "";

            
        }
    }
}
