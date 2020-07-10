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
    /// Lógica de interacción para UserControlMarcayFamilia.xaml
    /// </summary>
    public partial class UserControlMarcayFamilia : UserControl
    {
        [Obsolete]
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlMarcayFamilia()
        {
            InitializeComponent();
        }

        private void dg_marca_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECCIONARMARCA", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_marca.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void dg_familia_prod_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarFamilaProducto", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_familia_prod.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void dg_tipo_prod_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarTipoProducto", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_tipo_prod.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_actualizar_marca_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECCIONARMARCA", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_marca.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_actualizar_familia_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarFamilaProducto", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_familia_prod.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_actualizar_tipo_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarTipoProducto", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_tipo_prod.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_regis_marca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarMarca", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_marca", OracleType.VarChar).Value = txt_marca.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "La Marca fue registrada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al registrar la Marca", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }


        private void resetAll()
        {
            txt_marca.Text = "";
            txt_id_marca.Text = "";
            txt_id_fami.Text = "";
            txt_fami_prod.Text = "";
            txt_descrip_tipo.Text = "";
            txt_id_tipo.Text = "";
            txt_nomb_tipo.Text = "";
            txt_id_fami_prod.Text = "";

        }

        private void btn_edit_marca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarMarca", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idMar", OracleType.Number).Value = txt_id_marca.Text;
                comando.Parameters.Add("mar", OracleType.VarChar).Value = txt_marca.Text;
                
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "La Marca fue modificada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
                btn_regis_marca.IsEnabled = true;
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al modificar los datos de la Marca", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }

        private void btn_elim_marca_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminarMarca", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idMar", OracleType.VarChar).Value = txt_id_marca.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "La Marca fue eliminada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
                btn_regis_marca.IsEnabled = true;
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar la Marca", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void btn_regis_fami_prod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarFamiliaProducto", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_familia", OracleType.VarChar).Value = txt_fami_prod.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "La familia del producto fue registrada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al registrar la nueva familia de producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }

        private void btn_edit_fami_prod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarFamilia", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idFam", OracleType.VarChar).Value = txt_id_fami_prod.Text;
                comando.Parameters.Add("fam", OracleType.VarChar).Value = txt_fami_prod.Text;

                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "La familia de producto fue modificada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
                btn_regis_fami_prod.IsEnabled = true;
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al modificar los datos de la familia producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }

        private void btn_elim_fami_prod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminarfamilia", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idFam", OracleType.VarChar).Value = txt_id_fami_prod.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "La familia del producto fue eliminada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
                btn_regis_fami_prod.IsEnabled = true;
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar la familia del producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void btn_regis_tipo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarTipoProducto", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_nombre", OracleType.VarChar).Value = txt_nomb_tipo.Text;
                comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = txt_descrip_tipo.Text;
                comando.Parameters.Add("p_id_familia", OracleType.Number).Value = txt_id_fami.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El Tipo del producto fue registrada con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al registrar el nuevo tipo de producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }

        private void btn_edit_tipo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarTipo", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idTip", OracleType.Number).Value = txt_id_tipo.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txt_nomb_tipo.Text;
                comando.Parameters.Add("des", OracleType.VarChar).Value = txt_descrip_tipo.Text;
                comando.Parameters.Add("idFam", OracleType.Number).Value = txt_id_fami.Text;

                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El tipo de producto fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
                btn_regis_tipo.IsEnabled = true;
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al modificar los datos del tipo de producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }

        private void btn_elim_tipo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminartipo", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idTip", OracleType.VarChar).Value = txt_id_tipo.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El tipo de producto fue eliminado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
                btn_regis_tipo.IsEnabled = true;
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar el tipo de producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void dg_marca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_marca.Text = dr.Row.ItemArray[0].ToString();
                txt_marca.Text = dr.Row.ItemArray[1].ToString();
                
                btn_regis_marca.IsEnabled = false;
                btn_elim_marca.IsEnabled = true;
                btn_edit_marca.IsEnabled = true;

            }
        }

        private void dg_familia_prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                if (txt_nomb_tipo.Text == "")
                {
                    txt_id_fami_prod.Text = dr.Row.ItemArray[0].ToString();
                    txt_fami_prod.Text = dr.Row.ItemArray[1].ToString();
                }else
                {
                    txt_id_fami.Text = dr.Row.ItemArray[0].ToString();
                }
                
                

                btn_regis_fami_prod.IsEnabled = false;
                btn_elim_fami_prod.IsEnabled = true;
                btn_edit_fami_prod.IsEnabled = true;

            }
        }

        private void dg_tipo_prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_tipo.Text = dr.Row.ItemArray[0].ToString();
                txt_nomb_tipo.Text = dr.Row.ItemArray[1].ToString();
                txt_descrip_tipo.Text = dr.Row.ItemArray[2].ToString();
                txt_id_fami.Text = dr.Row.ItemArray[3].ToString();

                btn_regis_tipo.IsEnabled = false;
                btn_elim_tipo.IsEnabled = true;
                btn_edit_tipo.IsEnabled = true;

            }
        }
    }
}
