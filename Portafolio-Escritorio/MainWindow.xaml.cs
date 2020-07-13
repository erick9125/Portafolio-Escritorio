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
using MaterialDesignThemes.Wpf;
using SweetAlertSharp;
using SweetAlertSharp.Enums;
using System.Data;

namespace Portafolio_Escritorio
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        [Obsolete]
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");

        [Obsolete]
        private void Btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            if (txt_user.Text.Contains("@") & txt_user.Text.Contains('.'))
            {
              if (txt_pass.Password.Length >= 8)
                {
                    conexion.Open();
                    OracleCommand comando = new OracleCommand("SELECT P.MAIL ,U.PASSWORD ,RA.ID_ASIGNADO from PERSONA P JOIN USUARIO U ON U.PERSONA_ID_PERSONA = P.ID_PERSONA JOIN ROL_ASIGNADO RA ON P.ID_PERSONA = RA.PERSONA_ID_PERSONA WHERE P.MAIL = :usuario AND U.PASSWORD = :pass", conexion);

                    comando.Parameters.AddWithValue(":usuario", txt_user.Text);
                    comando.Parameters.AddWithValue(":pass", txt_pass.Password);

                     OracleDataReader lector = comando.ExecuteReader();
                    OracleDataAdapter oda = new OracleDataAdapter(comando);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);

                    if (lector.Read())
                     {
                        if(dt.Rows[0][2].ToString() == "111")
                        {
                        Views.menu formulario = new Views.menu();
                         conexion.Close();
                         formulario.Show();
                         this.Close();
                        }
                        else if(dt.Rows[0][2].ToString() == "112")
                        {
                            Views.menu2 formulario = new Views.menu2();
                            conexion.Close();
                            formulario.Show();
                            this.Close();
                        }
                        else if(dt.Rows[0][2].ToString() == "114")
                        {
                            Views.menu3 formulario = new Views.menu3();
                            conexion.Close();
                            formulario.Show();
                            this.Close();
                        }
                        else
                        {
                            SweetAlert.Show("Error", "El usuario ingresado no tiene perfil asignado, contacte al administrador", SweetAlertButton.OK, SweetAlertImage.ERROR);
                            conexion.Close();
                        }
                       
                     }
                     else
                     {

                         SweetAlert.Show("Datos Incorrectos", "El usuario o la contraseña son incorrectos", SweetAlertButton.OK, SweetAlertImage.ERROR);
                         conexion.Close();
                     }

                   /* OracleDataAdapter oda = new OracleDataAdapter(comando);
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    if(dt.Rows.Count == 1)
                    {
                        this.Hide();
                        if(dt.Rows[0][2].ToString() == "111")
                        {
                            Views.menu formulario = new Views.menu();
                            conexion.Close();
                            formulario.Show();
                            this.Close();
                        }
                        else if (dt.Rows[0][2].ToString() == "112")
                        {
                            Views.menu2 formulario = new Views.menu2();
                            conexion.Close();
                            formulario.Show();
                            this.Close();
                        }
                        else if (dt.Rows[0][2].ToString() == "114")
                        {
                            Views.menu3 formulario = new Views.menu3();
                            conexion.Close();
                            formulario.Show();
                            this.Close();
                        }
                        else
                        {
                            SweetAlert.Show("Datos Incorrectos", "El usuario o la contraseña son incorrectos", SweetAlertButton.OK, SweetAlertImage.ERROR);
                            conexion.Close();
                        }
                    }*/
                }
              else
                {
                    SweetAlert.Show("Datos Incorrectos", "La contraseña debe tener un minimo de 8 digitos", SweetAlertButton.OK, SweetAlertImage.ERROR);
                }
                    
                
            }
            else
            {
                SweetAlert.Show("Datos Incorrectos", "Ingrese un usuario valido", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            
        }

        private void Btn_soporte_Click(object sender, RoutedEventArgs e)
        {
            Views.soporte soporte = new Views.soporte();
            soporte.Show();
        }

        private void Btn_manuales_Click(object sender, RoutedEventArgs e)
        {
            Views.manuales manuales = new Views.manuales();
            manuales.Show();
        }

        private void Btn_logout_prin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
