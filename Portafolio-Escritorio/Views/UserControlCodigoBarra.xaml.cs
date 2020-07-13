using System;
using System.Collections.Generic;
using System.Drawing;
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
using BarcodeLib;
using System.Drawing.Imaging;
using Color = System.Drawing.Color;
using System.IO;
using System.Text.RegularExpressions;
using SweetAlertSharp;
using SweetAlertSharp.Enums;
using System.Data.OracleClient;
using System.Data;
using Oracle.DataAccess.Types;
using Microsoft.Win32;
using Portafolio_Escritorio.Models;
using System.Runtime.CompilerServices;


namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlCodigoBarra.xaml
    /// </summary>
    public partial class UserControlCodigoBarra : UserControl
    {
        [Obsolete]
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlCodigoBarra()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_proveedor.Text.Trim().Length < 3)
            {
                SweetAlert.Show("Error", "Favor ingresar minimo 3 caracteres para el código", SweetAlertButton.OK, SweetAlertImage.ERROR);
                return;
                
            }
            CreateBarCode();
            btnGuardar.IsEnabled = true;
            
        }

        public class codigo
        {
            public codigo(string codigoBarra)
            {
                this.codigoBarra = codigoBarra;
            }

            public string codigoBarra { get; set; }
        }

        String barra { get; set; }
        

        public void CreateBarCode()
        {  //se crea imagen de código de barras
            barra = txt_proveedor.Text + txt_id_marca.Text + txt_tipo_produc.Text+ txt_fecha_v.Text + txt_correlativo.Text;
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            b.IncludeLabel = true;
            System.Drawing.Image img = b.Encode(BarcodeLib.TYPE.CODE128,
                                        barra,
                                        System.Drawing.Color.Black,
                                        System.Drawing.Color.White,
                                        300,
                                        65);
            //Para mostrar la imagen en la ventana
            //Creaamos la fuente de imagen desde la memoria
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);//guarda la imagen en memoria
            img.Save("C:/cb/"+barra+".jpg");
            //my buffer byte
            byte[] buffer = ms.GetBuffer();
            //Crea un nuevo MemoryStream que tenga el contenido del búfer
            MemoryStream bufferPasser = new MemoryStream(buffer);


            //Creo una nueva imagen de mapa de bits para trabajar
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = bufferPasser;
            bitmap.EndInit();
            meraControl.Source = bitmap;//establecer la fuente del tipo de control de imagen como el nuevo BitmapImage creado anteriormente.  
            
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]"); //expresión regular que coincide con el texto no permitido
            return !regex.IsMatch(text);
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (IsTextAllowed(e.Text)) { }
            else { e.Handled = true; }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String SourceLoc = "C:/cb/" + barra + ".jpg";
                FileStream fs = new FileStream(SourceLoc, FileMode.Open, FileAccess.Read);
                byte[] ImageData = new byte[fs.Length];
                fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();

                //bloque para insertar los datos
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarCodigo", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_codigo_b", OracleType.VarChar).Value = barra;
                comando.Parameters.Add("p_id_m", OracleType.Number).Value = txt_id_marca.Text;
                comando.Parameters.Add("p_id_prod_t", OracleType.Number).Value = txt_tipo_produc.Text;
                comando.Parameters.Add("p_id_prod", OracleType.Number).Value = txt_id_produ_cb.Text;
                var param = comando.Parameters.Add("p_foto_c", OracleType.Blob);

                param.Direction = ParameterDirection.Input;
                param.Value = ImageData;

                comando.ExecuteNonQuery();
                SweetAlert.Show("Operación Realizada", "El código fue registrado con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();

            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Error al registrar código", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }

            conexion.Close();
        }
       

        private void resetAll()
        {
            txt_proveedor.Text = "";
            txt_id_marca.Text = "";
            txt_tipo_produc.Text = "";
            txt_fecha_v.Text = "";
            txt_correlativo.Text = "";
            txt_id_produ_cb.Text = "";
        }

       
        private void cb_tipo_prod_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_TIPO,NOMBRE from TIPO_PRODUC order by NOMBRE asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_tipo_prod.ItemsSource = dt.AsDataView();
            cb_tipo_prod.DisplayMemberPath = "NOMBRE";
            cb_tipo_prod.SelectedValuePath = "ID_TIPO";
            conexion.Close();
        }


        private void cb_tipo_prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cb_tipo_prod.SelectedItem).Row.ItemArray[0].ToString();
            txt_tipo_produc.Text = valor;
           
        }

        private void cb_proveedor_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT ID_PROV, NOMBRE FROM PROVEEDOR ORDER BY NOMBRE ASC", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_proveedor.ItemsSource = dt.AsDataView();
            cb_proveedor.DisplayMemberPath = "NOMBRE";
            cb_proveedor.SelectedValuePath = "ID_PROV";
            conexion.Close();
        }

        private void cb_proveedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cb_proveedor.SelectedItem).Row.ItemArray[0].ToString();
            txt_proveedor.Text = valor;
        }

        private void ListBox_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_MARCA,DESCRIPCION from MARCA order by DESCRIPCION asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_id_marca.ItemsSource = dt.AsDataView();
            cb_id_marca.DisplayMemberPath = "DESCRIPCION";
            cb_id_marca.SelectedValuePath = "ID_MARCA";
            conexion.Close();
        }

        private void cb_id_marca_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cb_id_marca.SelectedItem).Row.ItemArray[0].ToString();
            txt_id_marca.Text = valor;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //numero correlativo
            int cant = 0;
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT max(substr(codigo_barra,-20,3))  from CODIGO_BARRA", conexion);

            cant = Convert.ToInt32(comando.ExecuteScalar());
            txt_correlativo.Text = Convert.ToString(cant + 1);
            conexion.Close();

        }


        private void lb_productos_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_PRODU,DESCRIPCION, TO_CHAR(FECHA_VENCIMIENTO,'DDMMYYYY')  from PRODUCTO order by DESCRIPCION asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            lb_productos.ItemsSource = dt.AsDataView();
            lb_productos.DisplayMemberPath = "DESCRIPCION";
            lb_productos.SelectedValuePath = "ID_PRODU";
            conexion.Close();
        }

        private void lb_productos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)lb_productos.SelectedItem).Row.ItemArray[0].ToString();
            txt_id_produ_cb.Text = valor;
            string fecha = ((System.Data.DataRowView)lb_productos.SelectedItem).Row.ItemArray[2].ToString();
            txt_fecha_v.Text = fecha;
        }
    }
}
