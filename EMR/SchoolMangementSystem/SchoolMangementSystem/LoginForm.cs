using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolMangementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dieg0\OneDrive\Documentos\school.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Usuario y contraseña son campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connect.Open();

                    String selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", password.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Sesión iniciada correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MainForm mForm = new MainForm();
                            mForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario/Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    connect.Close();
                }
                

            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
