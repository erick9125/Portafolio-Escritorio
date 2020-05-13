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
        {  //Create BarCode Image
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            b.IncludeLabel = true;
            System.Drawing.Image img = b.Encode(BarcodeLib.TYPE.CODE128,
                                        txtCodigo.Text,
                                        System.Drawing.Color.Black,
                                        System.Drawing.Color.White,
                                        300,
                                        65);
            //To show image on Window
            //Create image source from Memory
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);//save image in memory
            //my buffer byte
            byte[] buffer = ms.GetBuffer();
            //Create new MemoryStream that has the contents of buffer
            MemoryStream bufferPasser = new MemoryStream(buffer);

            //I create a new BitmapImage to work with
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = bufferPasser;
            bitmap.EndInit();
            meraControl.Source = bitmap;//I set the source of the image control type as the new //BitmapImage created earlier.            
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]"); //regex that matches disallowed text
            return !regex.IsMatch(text);
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (IsTextAllowed(e.Text)) { }
            else { e.Handled = true; }
        }
    }
}
