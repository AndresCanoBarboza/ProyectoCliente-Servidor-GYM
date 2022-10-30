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
    public static class AfiliacionesSedes
    {
                        
        public static List<AfiliacionSede> afiSedes = new List<AfiliacionSede>();

        const string cadenaConexion = "Data Source = CANOBARBOZA-OME\\SQLEXPRESS03; Initial Catalog = FITUNED; Integrated Security = True;";

        #region Querys
        const string queryAct = "Select IdAfiliacion, FechaAfiliacion, IdCliente, IdSede From AfiliacionSede";

        const string queryAgregar = "Insert Into AfiliacionSede ([IdAfiliacion], [FechaAfiliacion], [IdCliente], [IdSede])" +
                "Values (@pId, @pfechaAfi, @pidCliente, @pidSede)";

        #endregion

        public static void AgregarAfiServicio(AfiliacionSede nuevaAfi)
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

            SqlCommand commandAf = new SqlCommand(queryAgregar, sql);

            commandAf.CommandType = CommandType.Text;
            commandAf.CommandText = queryAgregar;
            commandAf.Connection = sql;
            commandAf.Parameters.AddWithValue("@pId", nuevaAfi.afilacionId);
            commandAf.Parameters.AddWithValue("@pfechaAfi", nuevaAfi.afiliacionFecha);
            commandAf.Parameters.AddWithValue("@pidCliente", nuevaAfi.cliente.clienteId);
            commandAf.Parameters.AddWithValue("@pidSede", nuevaAfi.afiliacionClienteSede.sedeId);
            
            try
            {
                commandAf.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al insertar al Cliente a Sede en la base de datos");
                sql.Close();
                return;

            }

            sql.Close();
        }

        public static void ActualizarListaAfi() 
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
            
            afiSedes.Clear();
            while (reader.Read()) 
            {
                AfiliacionSede aS = new AfiliacionSede()
                {
                    afilacionId = int.Parse(reader["IdAfiliacion"].ToString()),
                    afiliacionFecha = DateTime.Parse(reader["FechaAfiliacion"].ToString()),
                    //cliente = reader["IdCliente"].ToString(),
                    //afiliacionClienteSede = reader["IdSede"].ToString()
                    //afiliacionClienteSede = reader["IdSede"].ToString()
                    

                };

                afiSedes.Add(aS);
            }

            sql.Close();
        } 

    }
}
