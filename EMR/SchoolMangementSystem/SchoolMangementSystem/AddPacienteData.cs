using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    class AddPacienteData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dieg0\OneDrive\Documentos\school.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { set; get; }
   
        public string PacienteNombre { set; get; }
        public string PacienteApellido { set; get; }

        public string PacienteSexo { set; get; }
        public string PacienteDireccion { set; get; }
        public int PacienteEdad { set; get; }
        public string PacienteEdificio { set; get; }
        public string PacienteEstado { set; get; }

  

        public List<AddPacienteData> pacienteData()
        {
            List<AddPacienteData> listData = new List<AddPacienteData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = "SELECT * FROM paciente";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddPacienteData addSD = new AddPacienteData();
                            addSD.ID = (int)reader["id"];
                            addSD.PacienteNombre = reader["paciente_nombre"].ToString();
                            addSD.PacienteApellido = reader["paciente_apellido"].ToString();
                            addSD.PacienteSexo = reader["paciente_sexo"].ToString();
                            addSD.PacienteDireccion = reader["paciente_direccion"].ToString();
                            addSD.PacienteEdad = (int)(byte)(reader["paciente_edad"]);
                            addSD.PacienteEdificio = reader["paciente_edificio"].ToString();
                            addSD.PacienteEstado = reader["paciente_estado"].ToString();


                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database auxilio: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;

        }

        public List<AddPacienteData> dashboardPacienteData()
        {
            List<AddPacienteData> listData = new List<AddPacienteData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string sql = "SELECT * FROM paciente";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        cmd.Parameters.AddWithValue("@dateInsert", today.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddPacienteData addSD = new AddPacienteData();
                            addSD.ID = (int)reader["id"];
                            addSD.PacienteNombre = reader["paciente_nombre"].ToString();
                            addSD.PacienteApellido = reader["paciente_apellido"].ToString();
                            addSD.PacienteSexo = reader["paciente_sexo"].ToString();
                            addSD.PacienteDireccion = reader["paciente_direccion"].ToString();
                            addSD.PacienteEdad = (int)reader["paciente_edad"];
                            addSD.PacienteEdificio = reader["paciente_edificio"].ToString();
                            addSD.PacienteEstado = reader["paciente_estado"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
