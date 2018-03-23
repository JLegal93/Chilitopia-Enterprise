using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace Chilitopia_Enterprise
{
    class BDSql
    {
        /*
         * agregar el tema de la conexion, si esta abierto, se cierra para volver a abrir
         * si esta cerrado lo que sea que se tenga que hacer.
         */
        SqlConnection sqlConnection1;
        SqlCommand cmd;
        SqlDataReader reader;
        public BDSql()
        {
            StartDB();
            //TestConsulta();
            //TestInsersion();
        }

        private void StartDB()
        {
           sqlConnection1 = new SqlConnection(@"Data Source=localhost;Initial Catalog=Chilitopia;User ID=sa;Password=admin123");

            cmd = new SqlCommand()
            {
                CommandType = CommandType.Text
            };
            cmd.Connection = sqlConnection1;
            sqlConnection1.Open();

        }
        private void TestConsulta()
        {
            String aux = "";
            cmd.CommandText = "SELECT * FROM zonas;";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                aux = reader[1].ToString();
                MessageBox.Show(aux, "Chilitopia Eterprise");
            }
            reader.Close();
            sqlConnection1.Close();

        }
        private void TestInsersion()
        {
            String nombre_zona = "Trolazo";

            try
            {
                cmd.CommandText = "INSERT into Zonas (nombre_zona) VALUES (@nombre_zona)";
                cmd.Parameters.AddWithValue("@nombre_zona", nombre_zona);
                int recordsAffected = cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
               MessageBox.Show( e.Message.ToString(),"error");
            }
            finally
            {
                sqlConnection1.Close();
            }
        }
    }
}
