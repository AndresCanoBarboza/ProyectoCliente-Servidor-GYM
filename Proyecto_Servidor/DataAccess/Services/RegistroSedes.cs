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
    public static class RegistroSedes
    {
        private const string cadenaConexion = "Data Source = CANOBARBOZA-OME\\SQLEXPRESS03; Initial Catalog = FITUNED; Integrated Security = True;";

    # region Querys
        const string query = "Insert Into Sede ([IdSede], [Nombre], [Direccion], [Estado], [Telefono])" +
                "Values (@psedeId, @pnombreSede, @pdireccionSede, @pestado, @ptelefono)";

        const string queryAct = "select IdSede, Nombre, Direccion, Estado, Telefono from Sede";

    #endregion
        public static List<Sede> sedes = new List<Sede>(20);
                
        public static void AgregarSedeServicio(Sede nuevaSede)
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
                        
            SqlCommand command = new SqlCommand(query, sql);
                                    
            command.CommandType = CommandType.Text;
            command.CommandText = query;
            command.Connection = sql;
            command.Parameters.AddWithValue("@pSedeId", nuevaSede.sedeId);
            command.Parameters.AddWithValue("@pnombreSede", nuevaSede.nombreSede);
            command.Parameters.AddWithValue("@pdireccionSede", nuevaSede.direccionSede);
            command.Parameters.AddWithValue("@pestado", nuevaSede.estado);
            command.Parameters.AddWithValue("@ptelefono", nuevaSede.telefono);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al insertar la Sede en la base de datos");
                sql.Close();
                return;                        
            }
            
            sql.Close();
        }

        public static void ActualizarListaSedes()
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

            sedes.Clear();
            while (reader.Read())
            {
                Sede s = new Sede()
                {
                    sedeId = int.Parse(reader["IdSede"].ToString()),
                    nombreSede = reader["Nombre"].ToString(),
                    direccionSede = reader["Direccion"].ToString(),
                    estado = bool.Parse(reader["Estado"].ToString()),
                    telefono = reader["Telefono"].ToString()
                };

                sedes.Add(s);
            }

            sql.Close();
        }

    }

    
}
