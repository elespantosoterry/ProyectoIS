namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class gestionCursos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuevoCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardarNuevoCursoBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cursoAsignado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.asignarCursoBT = new System.Windows.Forms.Button();
            this.grupoAsignado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.periodoAsignado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.profesorAsignado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eliminarCursoBT = new System.Windows.Forms.Button();
            this.cursoEliminado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(12, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(351, 46);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Gestión de Cursos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nuevoCurso);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guardarNuevoCursoBT);
            this.panel1.Location = new System.Drawing.Point(20, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 584);
            this.panel1.TabIndex = 1;
            // 
            // nuevoCurso
            // 
            this.nuevoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nuevoCurso.Location = new System.Drawing.Point(19, 94);
            this.nuevoCurso.Name = "nuevoCurso";
            this.nuevoCurso.Size = new System.Drawing.Size(329, 30);
            this.nuevoCurso.TabIndex = 8;
            this.nuevoCurso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crear Curso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guardarNuevoCursoBT
            // 
            this.guardarNuevoCursoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.guardarNuevoCursoBT.Location = new System.Drawing.Point(69, 518);
            this.guardarNuevoCursoBT.Name = "guardarNuevoCursoBT";
            this.guardarNuevoCursoBT.Size = new System.Drawing.Size(220, 47);
            this.guardarNuevoCursoBT.TabIndex = 11;
            this.guardarNuevoCursoBT.Text = "Guardar";
            this.guardarNuevoCursoBT.UseVisualStyleBackColor = true;
            this.guardarNuevoCursoBT.Click += new System.EventHandler(this.guardarNuevoCursoBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cursoAsignado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.asignarCursoBT);
            this.panel2.Controls.Add(this.grupoAsignado);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.periodoAsignado);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.profesorAsignado);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(444, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 584);
            this.panel2.TabIndex = 2;
            // 
            // cursoAsignado
            // 
            this.cursoAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cursoAsignado.FormattingEnabled = true;
            this.cursoAsignado.Location = new System.Drawing.Point(21, 365);
            this.cursoAsignado.Name = "cursoAsignado";
            this.cursoAsignado.Size = new System.Drawing.Size(329, 33);
            this.cursoAsignado.TabIndex = 19;
            this.cursoAsignado.SelectedIndexChanged += new System.EventHandler(this.cursoAsignado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Curso";
            // 
            // asignarCursoBT
            // 
            this.asignarCursoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.asignarCursoBT.Location = new System.Drawing.Point(78, 518);
            this.asignarCursoBT.Name = "asignarCursoBT";
            this.asignarCursoBT.Size = new System.Drawing.Size(220, 47);
            this.asignarCursoBT.TabIndex = 12;
            this.asignarCursoBT.Text = "Guardar";
            this.asignarCursoBT.UseVisualStyleBackColor = true;
            this.asignarCursoBT.Click += new System.EventHandler(this.asignarCursoBT_Click);
            // 
            // grupoAsignado
            // 
            this.grupoAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.grupoAsignado.FormattingEnabled = true;
            this.grupoAsignado.Location = new System.Drawing.Point(21, 286);
            this.grupoAsignado.Name = "grupoAsignado";
            this.grupoAsignado.Size = new System.Drawing.Size(329, 33);
            this.grupoAsignado.TabIndex = 17;
            this.grupoAsignado.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Grupo";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // periodoAsignado
            // 
            this.periodoAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodoAsignado.FormattingEnabled = true;
            this.periodoAsignado.Location = new System.Drawing.Point(21, 198);
            this.periodoAsignado.Name = "periodoAsignado";
            this.periodoAsignado.Size = new System.Drawing.Size(329, 33);
            this.periodoAsignado.TabIndex = 15;
            this.periodoAsignado.SelectedIndexChanged += new System.EventHandler(this.periodoAsignado_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Periodo";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // profesorAsignado
            // 
            this.profesorAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.profesorAsignado.FormattingEnabled = true;
            this.profesorAsignado.Location = new System.Drawing.Point(21, 112);
            this.profesorAsignado.Name = "profesorAsignado";
            this.profesorAsignado.Size = new System.Drawing.Size(329, 33);
            this.profesorAsignado.TabIndex = 13;
            this.profesorAsignado.SelectedIndexChanged += new System.EventHandler(this.profesorAsignado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Profesor";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asignar Curso";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.eliminarCursoBT);
            this.panel3.Controls.Add(this.cursoEliminado);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(863, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 584);
            this.panel3.TabIndex = 3;
            // 
            // eliminarCursoBT
            // 
            this.eliminarCursoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.eliminarCursoBT.Location = new System.Drawing.Point(84, 518);
            this.eliminarCursoBT.Name = "eliminarCursoBT";
            this.eliminarCursoBT.Size = new System.Drawing.Size(220, 47);
            this.eliminarCursoBT.TabIndex = 18;
            this.eliminarCursoBT.Text = "Guardar";
            this.eliminarCursoBT.UseVisualStyleBackColor = true;
            this.eliminarCursoBT.Click += new System.EventHandler(this.eliminarCursoBT_Click);
            // 
            // cursoEliminado
            // 
            this.cursoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cursoEliminado.FormattingEnabled = true;
            this.cursoEliminado.Location = new System.Drawing.Point(21, 105);
            this.cursoEliminado.Name = "cursoEliminado";
            this.cursoEliminado.Size = new System.Drawing.Size(329, 33);
            this.cursoEliminado.TabIndex = 19;
            this.cursoEliminado.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Curso";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eliminar Curso";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(411, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Retroceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gestionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titulo);
            this.Name = "gestionCursos";
            this.Text = "gestionCursos";
            this.Load += new System.EventHandler(this.gestionCursos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nuevoCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button guardarNuevoCursoBT;
        private System.Windows.Forms.ComboBox profesorAsignado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox periodoAsignado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox grupoAsignado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button asignarCursoBT;
        private System.Windows.Forms.ComboBox cursoEliminado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button eliminarCursoBT;
        private System.Windows.Forms.ComboBox cursoAsignado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}