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
    /// Lógica de interacción para UserControlEstadoDeuda.xaml
    /// </summary>
    public partial class UserControlEstadoDeuda : UserControl
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlEstadoDeuda()
        {
            InitializeComponent();
        }

        private void dgv_buscar_deuda_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarDeudores", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_buscar_deuda.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }

        private void btn_buscar_deuda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("buscarDeudor", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("buscarDeu", OracleType.VarChar).Value = txt_buscar_deuda.Text;
                comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
                comando.ExecuteNonQuery();

                OracleDataAdapter adaptador = new OracleDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgv_buscar_deuda.ItemsSource = tabla.DefaultView;

            }
            catch
            {
                SweetAlert.Show("Error al buscar", "Hubo un problema al buscar deudor", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            conexion.Close();
        }

        private void btn_enviar_email_Click(object sender, EventArgs e)
        {

            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage(); // se instancia y se crea la variable mmsg
            mmsg.To.Add(txt_email.Text); // agregan los componentes del mail, a quien va dirigido
            mmsg.Subject = txt_asunto.Text; // asunto del correo
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;// encodea en UTF8 lo q esta en el asunto por tema de servidores
            mmsg.Bcc.Add("negocio.yuyitos@gmail.com"); // para agregar una copia del correo (alternativo)

            mmsg.Body = txtMensaje.Text;//contenido del mensaje
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;// se debe encodear en UTF8 para que tenga una salida gráfica
            mmsg.IsBodyHtml = true;// si el cuerpo del mensaje es HTML
            mmsg.From = new System.Net.Mail.MailAddress("negocio.yuyitos@gmail.com");// persona q envía el correo

            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();// se debe crear el cliente correo
            cliente.Credentials = new System.Net.NetworkCredential("negocio.yuyitos@gmail.com", "Yuyito2020");// se crean las credenciales del correo

            cliente.Port = 587;// puerto gmail
            cliente.EnableSsl = true;//
            cliente.Host = "smtp.gmail.com";  // para dominios  mail.dominio.com 


            try
            {
                cliente.Send(mmsg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Enviar Correo");
            }

        }

        private void dgv_buscar_deuda_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;
            DataRowView dr = dg.SelectedItem as DataRowView;
            if (dr != null)
            {
                txt_email.Text = dr.Row.ItemArray[3].ToString();

            }
        }
    }
}
