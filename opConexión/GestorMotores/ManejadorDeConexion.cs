using opConexión.Interfaces;
using opConexión.MotoresBdd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opConexión.GestorMotores
{
    public class ManejadorDeConexion
    {
       
        private static readonly Dictionary<string, IMotorBdd> Motores = new Dictionary<string, IMotorBdd>()
        {
            { "SQL Server", new MotorSqlServer() },
            { "MySql", new MotorMySql() }
        };

        public static IMotorBdd ObtenerMotor(string nombreMotor)
        {
            if (Motores.ContainsKey(nombreMotor))
                return Motores[nombreMotor];

            throw new Exception($"Motor de base de datos no soportado: {nombreMotor}");
        }

    }
}
