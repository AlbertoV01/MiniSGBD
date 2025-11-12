using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opConexión.Interfaces
{
    public interface IMotorBdd
    {
        string Motor { get; }
        string CadenaConexion(string servidor, string usuario, string contraseña);
        bool ProbarConexion(string servidor, string usuario, string contraseña, out string mensaje);
        DataTable ObtenerBases(string servidor, string usuario, string contraseña, out string mensaje);
        DataTable ObtenerTablas(string servidor, string usuario, string contraseña, string baseDatos, out string mensaje);
        DataTable ObtenerCampos(string servidor, string usuario, string contraseña, string baseDatos, string tabla, out string mensaje);
        DataTable EjecutarConsulta(string servidor, string usuario, string contraseña, string baseDatos, string query, out string mensaje);


    }
}
