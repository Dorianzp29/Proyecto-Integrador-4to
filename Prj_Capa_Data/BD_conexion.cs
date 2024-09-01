using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Data
{
    public class BD_conexion
    {

        public string Conectar()

            {
            string cadena = "Data Source=DORIAN;Initial Catalog=ProyectoIntegrador4to;uid=sa;pwd=12345";
            return cadena;
        }
    }
}
