using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;

namespace SchoolMangementSystem
{
    public partial class AddStudentForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dieg0\OneDrive\Documentos\school.mdf;Integrated Security=True;Connect Timeout=30");
        public AddStudentForm()
        {
            InitializeComponent();

            displayPacienteData();  
        }

        public void displayPacienteData() 
        {
            AddPacienteData adData = new AddPacienteData();
                
            PacienteDataGridView.DataSource = adData.pacienteData();
            PacienteDataGridView.Columns[1].HeaderText = "Nombres";
            PacienteDataGridView.Columns[2].HeaderText = "Apellidos";
            PacienteDataGridView.Columns[3].HeaderText = "Sexo";
            PacienteDataGridView.Columns[4].HeaderText = "Dirección";
            PacienteDataGridView.Columns[5].HeaderText = "Edad";
            PacienteDataGridView.Columns[6].HeaderText = "Edificio";
            PacienteDataGridView.Columns[7].HeaderText = "Estado";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdPacienteText.Text == ""
              || NombrePacienteText.Text == ""
              || ApellidoPacienteText.Text == ""
              || SexoPacienteText.Text == ""
              || DireccionPacienteText.Text == ""
              || EdadPacienteText.Text == ""
              || EdificioPacienteText.Text == ""
              || EstadoPacienteText.Text == ""

          )
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        
                        string checkPacienteID = "SELECT COUNT(*) FROM paciente WHERE id = @PacienteID";

                        using (SqlCommand checkSID = new SqlCommand(checkPacienteID, connect))
                        {
                            checkSID.Parameters.AddWithValue("@PacienteID", IdPacienteText.Text.Trim());
                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Paciente ID: " + IdPacienteText.Text.Trim() + " ya existe"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO paciente (id, paciente_nombre" +
                                    ", paciente_apellido, paciente_direccion, paciente_sexo, paciente_estado" +
                                    ", paciente_edificio, paciente_edad) " +
                                    "VALUES(@PacienteID, @pacienteNombre, @pacienteApellido, @pacienteDireccion" +
                                    ", @pacienteSexo, @pacienteEstado, @pacienteEdificio, @pacienteEdad)";

                                
                                

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@PacienteID", IdPacienteText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pacienteNombre", NombrePacienteText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pacienteSexo", SexoPacienteText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pacienteDireccion", DireccionPacienteText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pacienteEdad", EdadPacienteText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pacienteEdificio", EdificioPacienteText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pacienteEstado", EstadoPacienteText.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pacienteApellido", ApellidoPacienteText.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayPacienteData();

                                    MessageBox.Show("El paciente fue añadido!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public void clearFields()
        {
            IdPacienteText.Text = "";
            NombrePacienteText.Text = "";
            SexoPacienteText.SelectedIndex = -1;
            DireccionPacienteText.Text = "";
            EdadPacienteText.SelectedIndex = -1;
            EdificioPacienteText.SelectedIndex = -1;
            EstadoPacienteText.SelectedIndex = -1;
            ApellidoPacienteText.Text = "";
      
        }

        public string imagePath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (.jpg; *.png)|.jpg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagePath = open.FileName;


            }
        }


        private void student_updateBtn_Click(object sender, EventArgs e)
        {
            if (IdPacienteText.Text == ""
                || NombrePacienteText.Text == ""
                || ApellidoPacienteText.Text == ""
                || SexoPacienteText.Text == ""
                || DireccionPacienteText.Text == ""
                || EdadPacienteText.Text == ""
                || EdificioPacienteText.Text == ""
                || EstadoPacienteText.Text == ""
              
                )
            {
                MessageBox.Show("Porfavor seleccione un paciente de la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("¿Estas seguro que deseas actualizar los datos del paciente?: "
                            + IdPacienteText.Text.Trim() + "?", "Mensaje de confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Now;

                            String updateData = "UPDATE paciente SET paciente_nombre = @pacienteNombre, " +
                                "paciente_apellido = @pacienteApellido, paciente_direccion = @pacienteDireccion, " +
                                "paciente_sexo = @pacienteSexo, paciente_edad = @pacienteEdad, " +
                                "paciente_edificio = @pacienteEdificio, paciente_estado = @pacienteEstado " +
                                "WHERE id = @pacienteID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@pacienteNombre", NombrePacienteText.Text.Trim());
                                cmd.Parameters.AddWithValue("@pacienteSexo", SexoPacienteText.Text.Trim());
                                cmd.Parameters.AddWithValue("@pacienteDireccion", DireccionPacienteText.Text.Trim());
                                cmd.Parameters.AddWithValue("@pacienteEdad", EdadPacienteText.Text.Trim());
                                cmd.Parameters.AddWithValue("@pacienteEdificio", EdificioPacienteText.Text.Trim());
                                cmd.Parameters.AddWithValue("@pacienteEstado", EstadoPacienteText.Text.Trim());
                                cmd.Parameters.AddWithValue("@pacienteApellido", ApellidoPacienteText.Text.Trim());
                                cmd.Parameters.AddWithValue("@pacienteID", IdPacienteText.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayPacienteData();

                                MessageBox.Show("Actualizacion completada!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void student_studentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = PacienteDataGridView.Rows[e.RowIndex];
                IdPacienteText.Text = row.Cells[0].Value.ToString();
                NombrePacienteText.Text = row.Cells[1].Value.ToString();
                ApellidoPacienteText.Text = row.Cells[2].Value.ToString();
                SexoPacienteText.Text = row.Cells[3].Value.ToString();
                DireccionPacienteText.Text = row.Cells[4].Value.ToString();
                EdadPacienteText.Text = row.Cells[5].Value.ToString();
                EdificioPacienteText.Text = row.Cells[6].Value.ToString();






                EstadoPacienteText.Text = row.Cells[7].Value.ToString();

            }
        }

        private void student_deleteBtn_Click(object sender, EventArgs e)
        {
            if (IdPacienteText.Text == "")
            {
                MessageBox.Show("Porfavor seleccione un paciente de la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        DialogResult check = MessageBox.Show("Esta seguro que quiere borrar el paciente ID: "
                            + IdPacienteText.Text + "?", "Mensaje de confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Now;

                            string deleteData = "DELETE FROM paciente WHERE id = @PacienteID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                     
                                cmd.Parameters.AddWithValue("@PacienteID", IdPacienteText.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayPacienteData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                clearFields();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void student_studentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
