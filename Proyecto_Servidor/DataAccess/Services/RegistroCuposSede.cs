using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities.Models;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccess.Services
{
    public static class RegistroCuposSede
    {
        public static List<CupoporSede> cuposSede = new List<CupoporSede>(20);

        private const string cadenaConexion = "Data Source = CANOBARBOZA-OME\\SQLEXPRESS03; Initial Catalog = FITUNED; Integrated Security = True;";

        #region Querys

        const string queryAgregar = "Insert Into CupoSede ([IdSede], [FechaCupo], [Cupos])" +
                "Values (@pId, @pfechaCupo, @pcupos)";

        const string queryAct = "select * from CupoSede";

        #endregion
        public static void AgregarCuposServicio(CupoporSede nuevoCupo)
        {
            SqlConnection sql = new SqlConnection(cadenaConexion);
            try
            {
                sql.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al conectarse con la base de datos");
                return;
            }

            SqlCommand commandC = new SqlCommand(queryAgregar, sql);
                        
            commandC.CommandType = CommandType.Text;
            commandC.CommandText = queryAgregar;
            commandC.Connection = sql;
            commandC.Parameters.AddWithValue("@pId", nuevoCupo.sede.nombreSede);
            commandC.Parameters.AddWithValue("@pfechaCupo", nuevoCupo.fechaCupos);
            commandC.Parameters.AddWithValue("@pcupos", nuevoCupo.cupos);
            
            try
            {
                commandC.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al insertar los cupos por sede en la base de datos");
                sql.Close();
                return;

            }

            sql.Close();
        }

        public static void ActualizarListaCupos()
        {
            SqlConnection sql = new SqlConnection(cadenaConexion);

            try
            {
                sql.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al conectarse con la base de datos");
                return;
            }

            SqlCommand command = new SqlCommand(queryAct, sql);
            SqlDataReader reader = command.ExecuteReader();

            cuposSede.Clear();
            while (reader.Read())
            {
                CupoporSede cs = new CupoporSede()
                {
                    fechaCupos = DateTime.Parse(reader["FechaCupo"].ToString()),
                    cupos = int.Parse(reader["Cupos"].ToString()),
                };

                cuposSede.Add(cs);
            }

            sql.Close();
        }


    }
}
