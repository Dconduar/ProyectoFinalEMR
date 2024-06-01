
namespace SchoolMangementSystem
{
    partial class AddStudentForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EstadoPacienteText = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.student_deleteBtn = new System.Windows.Forms.Button();
            this.student_clearBtn = new System.Windows.Forms.Button();
            this.student_updateBtn = new System.Windows.Forms.Button();
            this.student_addBtn = new System.Windows.Forms.Button();
            this.EdificioPacienteText = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EdadPacienteText = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DireccionPacienteText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SexoPacienteText = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NombrePacienteText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IdPacienteText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ApellidoPacienteText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ApellidoPacienteText);
            this.panel2.Controls.Add(this.EstadoPacienteText);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.student_deleteBtn);
            this.panel2.Controls.Add(this.student_clearBtn);
            this.panel2.Controls.Add(this.student_updateBtn);
            this.panel2.Controls.Add(this.student_addBtn);
            this.panel2.Controls.Add(this.EdificioPacienteText);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.EdadPacienteText);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.DireccionPacienteText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SexoPacienteText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NombrePacienteText);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.IdPacienteText);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 394);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 281);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // EstadoPacienteText
            // 
            this.EstadoPacienteText.FormattingEnabled = true;
            this.EstadoPacienteText.Items.AddRange(new object[] {
            "Cuidados intensivos",
            "Postoperatoria de cirugía",
            "Cuidados posoperatorios.",
            "Muerte Cerebral"});
            this.EstadoPacienteText.Location = new System.Drawing.Point(705, 74);
            this.EstadoPacienteText.Margin = new System.Windows.Forms.Padding(4);
            this.EstadoPacienteText.Name = "EstadoPacienteText";
            this.EstadoPacienteText.Size = new System.Drawing.Size(191, 24);
            this.EstadoPacienteText.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(644, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Estado:";
            // 
            // student_deleteBtn
            // 
            this.student_deleteBtn.BackColor = System.Drawing.Color.Red;
            this.student_deleteBtn.FlatAppearance.BorderSize = 0;
            this.student_deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_deleteBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.student_deleteBtn.Location = new System.Drawing.Point(767, 214);
            this.student_deleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_deleteBtn.Name = "student_deleteBtn";
            this.student_deleteBtn.Size = new System.Drawing.Size(136, 43);
            this.student_deleteBtn.TabIndex = 17;
            this.student_deleteBtn.Text = "Eliminar";
            this.student_deleteBtn.UseVisualStyleBackColor = false;
            this.student_deleteBtn.Click += new System.EventHandler(this.student_deleteBtn_Click);
            // 
            // student_clearBtn
            // 
            this.student_clearBtn.BackColor = System.Drawing.Color.Red;
            this.student_clearBtn.FlatAppearance.BorderSize = 0;
            this.student_clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_clearBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_clearBtn.ForeColor = System.Drawing.Color.White;
            this.student_clearBtn.Location = new System.Drawing.Point(599, 214);
            this.student_clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_clearBtn.Name = "student_clearBtn";
            this.student_clearBtn.Size = new System.Drawing.Size(136, 43);
            this.student_clearBtn.TabIndex = 16;
            this.student_clearBtn.Text = "Limpiar";
            this.student_clearBtn.UseVisualStyleBackColor = false;
            // 
            // student_updateBtn
            // 
            this.student_updateBtn.BackColor = System.Drawing.Color.Red;
            this.student_updateBtn.FlatAppearance.BorderSize = 0;
            this.student_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_updateBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_updateBtn.ForeColor = System.Drawing.Color.White;
            this.student_updateBtn.Location = new System.Drawing.Point(416, 214);
            this.student_updateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_updateBtn.Name = "student_updateBtn";
            this.student_updateBtn.Size = new System.Drawing.Size(136, 43);
            this.student_updateBtn.TabIndex = 15;
            this.student_updateBtn.Text = "Actualizar";
            this.student_updateBtn.UseVisualStyleBackColor = false;
            this.student_updateBtn.Click += new System.EventHandler(this.student_updateBtn_Click);
            // 
            // student_addBtn
            // 
            this.student_addBtn.BackColor = System.Drawing.Color.Red;
            this.student_addBtn.FlatAppearance.BorderSize = 0;
            this.student_addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.student_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.student_addBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_addBtn.ForeColor = System.Drawing.Color.White;
            this.student_addBtn.Location = new System.Drawing.Point(248, 214);
            this.student_addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.student_addBtn.Name = "student_addBtn";
            this.student_addBtn.Size = new System.Drawing.Size(136, 43);
            this.student_addBtn.TabIndex = 14;
            this.student_addBtn.Text = "Agregar";
            this.student_addBtn.UseVisualStyleBackColor = false;
            this.student_addBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EdificioPacienteText
            // 
            this.EdificioPacienteText.FormattingEnabled = true;
            this.EdificioPacienteText.Items.AddRange(new object[] {
            "Edicio A",
            "Edicio B",
            "Edicio C",
            "Edicio D",
            "Edicio E"});
            this.EdificioPacienteText.Location = new System.Drawing.Point(705, 26);
            this.EdificioPacienteText.Margin = new System.Windows.Forms.Padding(4);
            this.EdificioPacienteText.Name = "EdificioPacienteText";
            this.EdificioPacienteText.Size = new System.Drawing.Size(191, 24);
            this.EdificioPacienteText.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Edificio:";
            // 
            // EdadPacienteText
            // 
            this.EdadPacienteText.FormattingEnabled = true;
            this.EdadPacienteText.Items.AddRange(new object[] {
            "1",
            "",
            "2",
            "",
            "3",
            "",
            "4",
            "",
            "5",
            "",
            "6",
            "7",
            "",
            "8",
            "",
            "9",
            "",
            "10",
            "",
            "11",
            "",
            "12",
            "",
            "13",
            "",
            "14",
            "",
            "15",
            "",
            "16",
            "",
            "17",
            "",
            "18",
            "",
            "19",
            "",
            "20",
            "",
            "21",
            "",
            "22",
            "",
            "23",
            "",
            "24",
            "",
            "25",
            "",
            "26",
            "",
            "27",
            "",
            "28",
            "",
            "29",
            "",
            "30",
            "",
            "31",
            "",
            "32",
            "",
            "33",
            "",
            "34",
            "",
            "35",
            "",
            "36",
            "",
            "37",
            "",
            "38",
            "",
            "39",
            "",
            "40",
            "",
            "41",
            "",
            "42",
            "",
            "43",
            "",
            "44",
            "",
            "45",
            "",
            "46",
            "",
            "47",
            "",
            "48",
            "",
            "49",
            "",
            "50",
            "",
            "51",
            "",
            "52",
            "",
            "53",
            "",
            "54",
            "",
            "55",
            "",
            "56",
            "",
            "57",
            "",
            "58",
            "",
            "59",
            "",
            "60",
            "",
            "61",
            "",
            "62",
            "",
            "63",
            "",
            "64",
            "",
            "65",
            "",
            "66",
            "",
            "67",
            "",
            "68",
            "",
            "69",
            "",
            "70",
            "",
            "71",
            "",
            "72",
            "",
            "73",
            "",
            "74",
            "",
            "75",
            "",
            "76",
            "",
            "77",
            "",
            "78",
            "",
            "79",
            "",
            "80",
            "",
            "81",
            "",
            "82",
            "",
            "83",
            "",
            "84",
            "",
            "85",
            "",
            "86",
            "",
            "87",
            "",
            "88",
            "",
            "89",
            "",
            "90",
            "",
            "91",
            "",
            "92",
            "",
            "93",
            "",
            "94",
            "",
            "95",
            "",
            "96",
            "",
            "97",
            "98",
            "",
            "99",
            "",
            "100"});
            this.EdadPacienteText.Location = new System.Drawing.Point(416, 122);
            this.EdadPacienteText.Margin = new System.Windows.Forms.Padding(4);
            this.EdadPacienteText.Name = "EdadPacienteText";
            this.EdadPacienteText.Size = new System.Drawing.Size(191, 24);
            this.EdadPacienteText.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edad:";
            // 
            // DireccionPacienteText
            // 
            this.DireccionPacienteText.Location = new System.Drawing.Point(416, 26);
            this.DireccionPacienteText.Margin = new System.Windows.Forms.Padding(4);
            this.DireccionPacienteText.Multiline = true;
            this.DireccionPacienteText.Name = "DireccionPacienteText";
            this.DireccionPacienteText.Size = new System.Drawing.Size(191, 80);
            this.DireccionPacienteText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Dirección:";
            // 
            // SexoPacienteText
            // 
            this.SexoPacienteText.FormattingEnabled = true;
            this.SexoPacienteText.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.SexoPacienteText.Location = new System.Drawing.Point(416, 169);
            this.SexoPacienteText.Margin = new System.Windows.Forms.Padding(4);
            this.SexoPacienteText.Name = "SexoPacienteText";
            this.SexoPacienteText.Size = new System.Drawing.Size(191, 24);
            this.SexoPacienteText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genero:";
            // 
            // NombrePacienteText
            // 
            this.NombrePacienteText.Location = new System.Drawing.Point(107, 75);
            this.NombrePacienteText.Margin = new System.Windows.Forms.Padding(4);
            this.NombrePacienteText.Multiline = true;
            this.NombrePacienteText.Name = "NombrePacienteText";
            this.NombrePacienteText.Size = new System.Drawing.Size(192, 30);
            this.NombrePacienteText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres:";
            // 
            // IdPacienteText
            // 
            this.IdPacienteText.Location = new System.Drawing.Point(107, 26);
            this.IdPacienteText.Margin = new System.Windows.Forms.Padding(4);
            this.IdPacienteText.Multiline = true;
            this.IdPacienteText.Name = "IdPacienteText";
            this.IdPacienteText.Size = new System.Drawing.Size(135, 30);
            this.IdPacienteText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Paciente ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PacienteDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 356);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // PacienteDataGridView
            // 
            this.PacienteDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PacienteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PacienteDataGridView.EnableHeadersVisualStyles = false;
            this.PacienteDataGridView.Location = new System.Drawing.Point(27, 58);
            this.PacienteDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.PacienteDataGridView.Name = "PacienteDataGridView";
            this.PacienteDataGridView.RowHeadersVisible = false;
            this.PacienteDataGridView.RowHeadersWidth = 51;
            this.PacienteDataGridView.Size = new System.Drawing.Size(1080, 276);
            this.PacienteDataGridView.TabIndex = 1;
            this.PacienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_studentData_CellClick);
            this.PacienteDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_studentData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Pacientes";
            // 
            // ApellidoPacienteText
            // 
            this.ApellidoPacienteText.Location = new System.Drawing.Point(107, 124);
            this.ApellidoPacienteText.Name = "ApellidoPacienteText";
            this.ApellidoPacienteText.Size = new System.Drawing.Size(192, 22);
            this.ApellidoPacienteText.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Apellidos:";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddStudentForm";
            this.Size = new System.Drawing.Size(1167, 708);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button student_deleteBtn;
        private System.Windows.Forms.Button student_clearBtn;
        private System.Windows.Forms.Button student_updateBtn;
        private System.Windows.Forms.Button student_addBtn;
        private System.Windows.Forms.ComboBox EdificioPacienteText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox EdadPacienteText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DireccionPacienteText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SexoPacienteText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombrePacienteText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdPacienteText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PacienteDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox EstadoPacienteText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ApellidoPacienteText;
    }
}
