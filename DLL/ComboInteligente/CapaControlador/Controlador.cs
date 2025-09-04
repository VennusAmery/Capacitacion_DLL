using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();
        public string[] items(string empleados, string codigo_empleado, string nombre_completo)
        {
            string[] Items = sn.llenarCmb(empleados, codigo_empleado, nombre_completo);
            return Items;
        }

        ///Controlador 2///
        public DataTable enviar(string empleados, string codigo_empleado, string nombre_completo)
        {
            var dt1 = sn.obtener(empleados, codigo_empleado, nombre_completo);
            return dt1;
        }
    }
}