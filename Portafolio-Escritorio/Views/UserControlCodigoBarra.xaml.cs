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

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlCodigoBarra.xaml
    /// </summary>
    public partial class UserControlCodigoBarra : UserControl
    {
        public UserControlCodigoBarra()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text.Trim().Length < 12)
            {
                MessageBox.Show("favor ingresar minimo 12 caracteres");
                return;
                
            }
            CreateBarCode();
            btnGuardar.IsEnabled = true;
            
        }

        private void CreateBarCode()
        {  //se crea imagen de código de barras
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            b.IncludeLabel = true;
            System.Drawing.Image img = b.Encode(BarcodeLib.TYPE.CODE128,
                                        txtCodigo.Text,
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

        }
    }
}
