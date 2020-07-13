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
    /// Lógica de interacción para NuevoMedioPago.xaml
    /// </summary>
    public partial class NuevoMedioPago : Window
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public NuevoMedioPago()
        {
            InitializeComponent();
        }

        private void btn_volver_mediop_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dg_medio_pago_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarNuevoMedioPago", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_medio_pago.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void dg_medio_pago_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_mediop.Text = dr.Row.ItemArray[0].ToString();
                txt_nuevo_mediop.Text = dr.Row.ItemArray[1].ToString();

                if (txt_nuevo_mediop.Text == "")
                {
                    btn_edit_mediop.IsEnabled = false;
                    btn_eliminar_mediop.IsEnabled = false;
                }
                else
                {
                    btn_edit_mediop.IsEnabled = true;
                    btn_eliminar_mediop.IsEnabled = true;
                    btn_registrar_pago.IsEnabled = false;
                }


            }
        }

        private void resetAll()
        {
            txt_nuevo_mediop.Text = "";
            txt_id_mediop.Text = "";
            

        }

        private void btn_registrar_pago_Click(object sender, RoutedEventArgs e)
        {
            if (txt_nuevo_mediop.Text != "")
            {
                try
                {
                    conexion.Open();
                    OracleCommand comando = new OracleCommand("insertarNuevoMedioPago", conexion);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("p_nomb", OracleType.VarChar).Value = txt_nuevo_mediop.Text;
                    comando.ExecuteNonQuery();
                    SweetAlert.Show("Operación Realizada", "Medio de pago registrado con exito!", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                    this.resetAll();
                }
                catch (Exception)
                {
                    SweetAlert.Show("Error", "Ocurrio un problema al registrar el nuevo medio de pago", SweetAlertButton.OK, SweetAlertImage.ERROR);
                    this.resetAll();
                }

                conexion.Close();
            }
            else
            {
                SweetAlert.Show("Error", "El campo medio de pago no puede estar vacio", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
        }

        private void btn_actualizar_pago_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarNuevoMedioPago", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_medio_pago.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_edit_mediop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarMedioPago", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idMP", OracleType.Number).Value = txt_id_mediop.Text;
                comando.Parameters.Add("nombMP", OracleType.VarChar).Value = txt_nuevo_mediop.Text;


                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El Medio de pago fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
                btn_registrar_pago.IsEnabled = true;
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Error al modificar el medio de pago seleccionado", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }

            conexion.Close();
        }

        private void btn_eliminar_mediop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminarMedioPago", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idMP", OracleType.Number).Value = txt_id_mediop.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El medio de pago fue eliminado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar el medio de pago seleccionado", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }
    }
}
