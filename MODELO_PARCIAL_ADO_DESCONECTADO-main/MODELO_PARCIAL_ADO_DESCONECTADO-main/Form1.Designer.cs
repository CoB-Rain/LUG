namespace ADM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Grilla_Alumnos = new DataGridView();
            Grilla_Asignatura = new DataGridView();
            Grilla_Materias_Cursadas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Grilla_Materias_Por_Cursar = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)Grilla_Alumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Asignatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Materias_Cursadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Materias_Por_Cursar).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Alumnos
            // 
            Grilla_Alumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Alumnos.Location = new Point(29, 50);
            Grilla_Alumnos.Name = "Grilla_Alumnos";
            Grilla_Alumnos.Size = new Size(240, 150);
            Grilla_Alumnos.TabIndex = 0;
            // 
            // Grilla_Asignatura
            // 
            Grilla_Asignatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Asignatura.Location = new Point(588, 50);
            Grilla_Asignatura.Name = "Grilla_Asignatura";
            Grilla_Asignatura.Size = new Size(200, 388);
            Grilla_Asignatura.TabIndex = 1;
            // 
            // Grilla_Materias_Cursadas
            // 
            Grilla_Materias_Cursadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Materias_Cursadas.Location = new Point(316, 50);
            Grilla_Materias_Cursadas.Name = "Grilla_Materias_Cursadas";
            Grilla_Materias_Cursadas.Size = new Size(240, 150);
            Grilla_Materias_Cursadas.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(666, 32);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Asignaturas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 32);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Alumnos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 32);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 5;
            label3.Text = "Materias Cursadas del Alumno";
            // 
            // Grilla_Materias_Por_Cursar
            // 
            Grilla_Materias_Por_Cursar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Materias_Por_Cursar.Location = new Point(29, 255);
            Grilla_Materias_Por_Cursar.Name = "Grilla_Materias_Por_Cursar";
            Grilla_Materias_Por_Cursar.Size = new Size(240, 150);
            Grilla_Materias_Por_Cursar.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 237);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 7;
            label4.Text = "Materias Que le faltan cursar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Grilla_Materias_Por_Cursar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Grilla_Materias_Cursadas);
            Controls.Add(Grilla_Asignatura);
            Controls.Add(Grilla_Alumnos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Grilla_Alumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Asignatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Materias_Cursadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla_Materias_Por_Cursar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Alumnos;
        private DataGridView Grilla_Asignatura;
        private DataGridView Grilla_Materias_Cursadas;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView Grilla_Materias_Por_Cursar;
        private Label label4;
    }
}
