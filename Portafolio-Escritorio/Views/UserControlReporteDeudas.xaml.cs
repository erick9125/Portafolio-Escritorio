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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.Collections;
using System.Windows.Controls.Primitives;
using SweetAlertSharp;
using SweetAlertSharp.Enums;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlReporteDeudas.xaml
    /// </summary>
    public partial class UserControlReporteDeudas : UserControl
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = xe; PASSWORD= yuyito; USER ID= SGYBD_V6;");
        public UserControlReporteDeudas()
        {
            InitializeComponent();
        }

        private void btn_word_deuda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgv_reporte_deuda.SelectAllCells();
                dgv_reporte_deuda.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, dgv_reporte_deuda);
                String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
                String result = (string)Clipboard.GetData(DataFormats.Text);
                dgv_reporte_deuda.UnselectAllCells();
                System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"C:\Users\Emy&Tamy\Desktop\Deuda.doc");
                file1.WriteLine(result.Replace(',', ' '));
                file1.Close();
                SweetAlert.Show("Operación Realizada", "Se ha generado el archivo WORD Deuda.doc con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
            }
            catch (Exception)
            {
                SweetAlert.Show("Error", "Ocurrio un problema mientras se generaba el documento WORD", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
           
        }

        private void btn_excel_deuda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgv_reporte_deuda.SelectAllCells();
                dgv_reporte_deuda.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
                ApplicationCommands.Copy.Execute(null, dgv_reporte_deuda);
                String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
                String result = (string)Clipboard.GetData(DataFormats.Text);
                dgv_reporte_deuda.UnselectAllCells();
                System.IO.StreamWriter file1 = new System.IO.StreamWriter(@"C:\Users\Emy&Tamy\Desktop\Deuda.xls");
                file1.WriteLine(result.Replace(',', ' '));
                file1.Close();

                SweetAlert.Show("Operación Realizada", " Se ha generado el archivo excel Deuda.xls con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
            }
            catch(Exception)
            {
                SweetAlert.Show("Error", "Ocurrio un problema mientras se generaba el documento EXCEL", SweetAlertButton.OK, SweetAlertImage.ERROR);
            }
            
        }

        // inicio metodo para exportar a pdf
        private void btn_pdf_deuda_Click(object sender, RoutedEventArgs e)
        {
            PdfPTable table = new PdfPTable(dgv_reporte_deuda.Columns.Count);
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new System.IO.FileStream(@"C:\Users\Emy&Tamy\Desktop\Stock.pdf", System.IO.FileMode.Create));
            doc.Open();
            for (int j = 0; j < dgv_reporte_deuda.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dgv_reporte_deuda.Columns[j].Header.ToString()));
            }
            table.HeaderRows = 1;
            IEnumerable itemsSource = dgv_reporte_deuda.ItemsSource as IEnumerable;
            if (itemsSource != null)
            {
                foreach (var item in itemsSource)
                {
                    DataGridRow row = dgv_reporte_deuda.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                    if (row != null)
                    {
                        DataGridCellsPresenter presenter = FindVisualChild<DataGridCellsPresenter>(row);
                        for (int i = 0; i < dgv_reporte_deuda.Columns.Count; ++i)
                        {
                            DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(i);
                            TextBlock txt = cell.Content as TextBlock;
                            if (txt != null)
                            {
                                table.AddCell(new Phrase(txt.Text));
                            }
                        }
                    }
                }

                doc.Add(table);
                doc.Close();

                SweetAlert.Show("Operación Realizada", "  Se ha generado el archivo PDF Deuda.pdf con exito", SweetAlertButton.OK, SweetAlertImage.SUCCESS);
                
            }
        }
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj)
       where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        public static childItem FindVisualChild<childItem>(DependencyObject obj)
            where childItem : DependencyObject
        {
            foreach (childItem child in FindVisualChildren<childItem>(obj))
            {
                return child;
            }

            return null;
        }
        // fin metodo para exportar a PDF

        private void dgv_reporte_deuda_Loaded(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarDeudores", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgv_reporte_deuda.ItemsSource = tabla.DefaultView;
            conexion.Close();
        }
    }
}
