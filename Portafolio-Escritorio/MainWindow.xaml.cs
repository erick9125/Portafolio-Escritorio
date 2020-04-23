﻿using System;
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
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= 1234; USER ID= ERICK;");

        [Obsolete]
        private void Btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * from PERSONA WHERE MAIL = :usuario AND PASSWORD = :pass", conexion);

            comando.Parameters.AddWithValue(":usuario", txt_user.Text);
            comando.Parameters.AddWithValue(":pass", txt_pass.Password);

            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                Views.menu formulario = new Views.menu();
                conexion.Close();
                formulario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos", "El usuario o la contraseña son incorrectos");
                conexion.Close();
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
