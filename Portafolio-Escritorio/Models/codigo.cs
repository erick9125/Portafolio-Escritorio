using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio_Escritorio.Models
{
    class Codigo
    {
        public Codigo(string codigoBarra, Image codigoImagen)
        {
            this.CodigoBarra = codigoBarra;
            CodigoImagen = codigoImagen;
        }

        public string CodigoBarra { get; set; }
        public Image CodigoImagen { get; set; }
    }
}
