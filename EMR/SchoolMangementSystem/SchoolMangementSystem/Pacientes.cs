using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public partial class Pacientes : Form
    {
        public Pacientes()
        {
            InitializeComponent();
            displayPacienteData();
        }

        public void displayPacienteData()
        {
            AddPacienteData adData = new AddPacienteData();
            DataPacienteView.DataSource = adData.pacienteData();
          //  student_studentData.DataSource = adData.pacienteData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

        }
    }
}
