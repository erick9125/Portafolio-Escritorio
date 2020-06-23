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
using SweetAlertSharp;
using SweetAlertSharp.Enums;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para soporte.xaml
    /// </summary>
    public partial class soporte : Window
    {
        public soporte()
        {
            InitializeComponent();
        }

        private void Btn_salir_Sop_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_enviar_pro_Click(object sender, RoutedEventArgs e)
        {
            
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                mmsg.To.Add(txt_correo.Text);
                mmsg.Subject = txt_asunto.Text;
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                mmsg.Body = txt_descripcion.Text;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress("negocio.yuyitos@gmail.com");

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
                cliente.Credentials = new System.Net.NetworkCredential("negocio.yuyitos@gmail.com", "Yuyito2020");

                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(mmsg);
                SweetAlert.Show("Operación Realizada", "El correo fue enviado con exito!", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                this.resetAll();
            }
            catch (Exception ex)
            {
                SweetAlert.Show("Error", "Ocurrio un problema mientras se enviaba el correo", SweetAlertButton.OK, SweetAlertImage.ERROR);
                MessageBox.Show(ex.ToString());
            }
           
        }

        public void resetAll()
        {
            txt_correo.Text = "";
            txt_asunto.Text = "";
            txt_descripcion.Text = "";
        }
    }
}
