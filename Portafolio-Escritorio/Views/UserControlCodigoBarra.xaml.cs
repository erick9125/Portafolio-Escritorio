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
using System.Drawing;
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

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlCodigoBarra.xaml
    /// </summary>
    public partial class UserControlCodigoBarra : UserControl
    {
        [Obsolete]
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= 1234; USER ID= ERICK;");
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

        
        private void CreateBarCode()
        {  //se crea imagen de código de barras
            var cod = txt_proveedor.Text + txt_id_marca.Text + txt_tipo_produc.Text+ txt_fecha_v.Text + txt_correlativo.Text;
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            b.IncludeLabel = true;
            System.Drawing.Image img = b.Encode(BarcodeLib.TYPE.CODE128,
                                        cod,
                                        System.Drawing.Color.Black,
                                        System.Drawing.Color.White,
                                        300,
                                        65);
            //Para mostrar la imagen en la ventana
            //Creaamos la fuente de imagen desde la memoria
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);//guarda la imagen en memoria
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

                //bloque para insertar los datos
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertarCodigo", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("p_codigo_b", OracleType.VarChar).Value = txt_proveedor.Text;
                comando.Parameters.Add("p_id_m", OracleType.VarChar).Value = txt_id_marca.Text;
                comando.Parameters.Add("p_id_prod_t", OracleType.VarChar).Value = txt_tipo_produc.Text;

                OracleParameter blobParameter = new OracleParameter();
                blobParameter.OracleType = OracleType.Blob;
                blobParameter.ParameterName = "p_foto_c";
               // blobParameter.Value = blob;

                comando.Parameters.Add(blobParameter);
               
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
        }

        private void cb_id_marca_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_MARCA,DESCRIPCION from MARCA order by ID_MARCA asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_id_marca.ItemsSource = dt.AsDataView();
            cb_id_marca.DisplayMemberPath = "DESCRIPCION";
            cb_id_marca.SelectedValuePath = "ID_MARCA";
            conexion.Close();
        }

        private void cb_tipo_prod_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("select ID_TIPO,NOMBRE from TIPO_PRODUC order by ID_TIPO asc", conexion);
            comando.CommandType = System.Data.CommandType.Text;

            OracleDataAdapter oda = new OracleDataAdapter(comando);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            cb_tipo_prod.ItemsSource = dt.AsDataView();
            cb_tipo_prod.DisplayMemberPath = "NOMBRE";
            cb_tipo_prod.SelectedValuePath = "ID_TIPO";
            conexion.Close();
        }

        private void cb_id_marca_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cb_id_marca.SelectedItem).Row.ItemArray[0].ToString();
            txt_id_marca.Text = valor;
            
        }

        private void cb_tipo_prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cb_tipo_prod.SelectedItem).Row.ItemArray[0].ToString();
            txt_tipo_produc.Text = valor;
           
        }

        private void cb_proveedor_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT ID_PROV, NOMBRE FROM PROVEEDOR ORDER BY ID_PROV ASC", conexion);
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
    }
}
