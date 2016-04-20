using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de bd
/// </summary>
public class bd
{
    
        private SqlConnection con;
        private SqlDataAdapter da;
        static DataTable dt;
        private SqlCommand cmd;

        public void Conectar()
        {
            con = new SqlConnection("Data Source = servidor; Initial Catalog = basedatos; Integrated Security = True; MultipleActiveResultSets = True");
            con.Open();
        }

        public void Desconectar()
        {
            con.Close();
        }

        public void CrearComando(string consulta)
        {
            cmd = new SqlCommand(consulta, con);
        }

        public void AsignarParametro(string param, SqlDbType tipo, object val)
        {
            cmd.Parameters.Add(param, tipo).Value = val;
        }

        public int EjecutarConsulta()
        {
            return cmd.ExecuteNonQuery();
        }
        public DataTable EjecutarDataTable()
        {
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt); return dt;
        } 
}