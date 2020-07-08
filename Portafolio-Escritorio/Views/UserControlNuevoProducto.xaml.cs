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
    /// Lógica de interacción para UserControlNuevoProducto.xaml
    /// </summary>
    public partial class UserControlNuevoProducto : UserControl
    {
        [Obsolete]
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlNuevoProducto()
        {
            InitializeComponent();
        }

        

        private void cb_prod_tipo_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_TIPO,NOMBRE from TIPO_PRODUC order by NOMBRE asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_prod_tipo.ItemsSource = dt.AsDataView();
            cb_prod_tipo.DisplayMemberPath = "NOMBRE";
            cb_prod_tipo.SelectedValuePath = "ID_TIPO";
            conexion.Close();
        }

       /* private void cb_prod_barra_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_CODIGO,CODIGO_BARRA from CODIGO_BARRA order by CODIGO_BARRA asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_prod_barra.ItemsSource = dt.AsDataView();
            cb_prod_barra.DisplayMemberPath = "CODIGO_BARRA";
            cb_prod_barra.SelectedValuePath = "ID_TIPO";
            conexion.Close();
        }
        */      


        private void btn_editar_prod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizarProducto", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idPro", OracleType.VarChar).Value = txt_id_prod.Text;
                comando.Parameters.Add("desPro", OracleType.VarChar).Value = txt_prod_descrip.Text;
                comando.Parameters.Add("tipPro", OracleType.VarChar).Value = txt_prod_id_tip.Text;
                comando.Parameters.Add("sto", OracleType.Number).Value = txt_prod_stock.Text;
                comando.Parameters.Add("marPro", OracleType.VarChar).Value = txt_prod_id_mar.Text;
                comando.Parameters.Add("fvPro", OracleType.DateTime).Value = dp_prod_ven.SelectedDate;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El Producto fue modificado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al modificar los datos del Producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }

        private void btn_eliminar_prod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("eliminarProducto", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idPro", OracleType.VarChar).Value = txt_id_prod.Text;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El producto fue eliminado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "No fue posible eliminar el producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void lb_prod_marca_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_MARCA,DESCRIPCION from MARCA order by DESCRIPCION asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            lb_prod_marca.ItemsSource = dt.AsDataView();
            lb_prod_marca.DisplayMemberPath = "DESCRIPCION";
            lb_prod_marca.SelectedValuePath = "ID_MARCA";
            conexion.Close();
        }

        private void cb_prod_tipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cb_prod_tipo.SelectedItem).Row.ItemArray[0].ToString();
            txt_prod_id_tip.Text = valor;
        }

        private void lb_prod_marca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)lb_prod_marca.SelectedItem).Row.ItemArray[0].ToString();
            txt_prod_id_mar.Text = valor;
        }

        private void btn_registrar_prod_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarProducto", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_descripcion", OracleType.VarChar).Value = txt_prod_descrip.Text;
                comando.Parameters.Add("p_id_tipo", OracleType.VarChar).Value = txt_prod_id_tip.Text;
                comando.Parameters.Add("p_stock", OracleType.Number).Value = txt_prod_stock.Text;
                comando.Parameters.Add("p_id_marca", OracleType.VarChar).Value = txt_prod_id_mar.Text;
                comando.Parameters.Add("p_fecha_v", OracleType.DateTime).Value = dp_prod_ven.SelectedDate;
                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El Producto fue registrado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al registrar Producto", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }

        private void btn_buscar_prod_Click(object sender, RoutedEventArgs e)
        {

        }

        private void resetAll()
        {
            txt_id_prod.Text = "";
            txt_prod_descrip.Text = "";
            txt_prod_id_mar.Text = "";
            txt_prod_id_tip.Text = "";
            txt_prod_stock.Text = "";
            dp_prod_ven.Text = "";
            
        }

        private void dg_productos_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarProductosCompleto", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_productos.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_actualizar_prod_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarProductosCompleto", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dg_productos.ItemsSource = tabla.DefaultView;
            conexion.Close();
            btn_registrar_prod.IsEnabled = true;
            

        }

        private void dg_productos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_id_prod.Text = dr.Row.ItemArray[0].ToString();
                txt_prod_descrip.Text = dr.Row.ItemArray[1].ToString();
                txt_prod_id_tip.Text = dr.Row.ItemArray[2].ToString();
                txt_prod_stock.Text = dr.Row.ItemArray[3].ToString();
                txt_prod_id_mar.Text = dr.Row.ItemArray[4].ToString();
                dp_prod_ven.Text = dr.Row.ItemArray[5].ToString();

                btn_registrar_prod.IsEnabled = false;
                btn_editar_prod.IsEnabled = true;
                btn_eliminar_prod.IsEnabled = true;

            }
        }
    }
}
