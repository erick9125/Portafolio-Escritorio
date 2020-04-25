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

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para manuales.xaml
    /// </summary>
    public partial class manuales : Window
    {
        public manuales()
        {
            InitializeComponent();
        }

        private void Btn_salir_man_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
