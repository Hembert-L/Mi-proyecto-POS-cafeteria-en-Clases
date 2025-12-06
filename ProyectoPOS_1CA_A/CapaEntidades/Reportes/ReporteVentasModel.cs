using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Infrastructure;   // Requerido para usar LicenseType y GeneratePdf
using QuestPDF.Fluent;        // Extensiones para Page(), Table(), Text(), etc.

namespace ProyectoPOS_1CA_A.CapaEntidades.Reportes
{
    public class ReporteVentasModel
    {
        
        // Tabla con la información de ventas (producto, cantidad, etc.)
        public DataTable Tabla { get; }

        // Fechas de inicio y fin del período consultado
        public DateTime Inicio { get; }

        public DateTime Fin { get; }

        // Constructor que recibe los valores y los asigna
        public ReporteVentasModel(DataTable tabla, DateTime inicio, DateTime fin)
        {
            Tabla = tabla;   // Datos del DataTable
            Inicio = inicio; // Fecha inicial
            Fin = fin;       // Fecha final
        }
    }
}


