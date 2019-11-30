namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class gestionAlumnos
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.codigoRetiro = new System.Windows.Forms.TextBox();
            this.eliminarCursoBT = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.retiroGrupos = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.codigoMatricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cuposMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.asignarCursoBT = new System.Windows.Forms.Button();
            this.matriculaGrupos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nuevoCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nuevaContraseña = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nuevoUsuario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.nuevoApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nuevoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardarNuevoCursoBT = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(418, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Retroceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.codigoRetiro);
            this.panel3.Controls.Add(this.eliminarCursoBT);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.retiroGrupos);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(870, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 584);
            this.panel3.TabIndex = 16;
            // 
            // codigoRetiro
            // 
            this.codigoRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.codigoRetiro.Location = new System.Drawing.Point(21, 103);
            this.codigoRetiro.Name = "codigoRetiro";
            this.codigoRetiro.Size = new System.Drawing.Size(329, 30);
            this.codigoRetiro.TabIndex = 23;
            this.codigoRetiro.TextChanged += new System.EventHandler(this.codigoRetiro_TextChanged);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(16, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "Código de Alumno";
            // 
            // retiroGrupos
            // 
            this.retiroGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.retiroGrupos.FormattingEnabled = true;
            this.retiroGrupos.Location = new System.Drawing.Point(21, 172);
            this.retiroGrupos.Name = "retiroGrupos";
            this.retiroGrupos.Size = new System.Drawing.Size(329, 33);
            this.retiroGrupos.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(16, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 25);
            this.label14.TabIndex = 20;
            this.label14.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Retirar Alumno";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.codigoMatricula);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cuposMatricula);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.asignarCursoBT);
            this.panel2.Controls.Add(this.matriculaGrupos);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(451, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 584);
            this.panel2.TabIndex = 15;
            // 
            // codigoMatricula
            // 
            this.codigoMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.codigoMatricula.Location = new System.Drawing.Point(21, 264);
            this.codigoMatricula.Name = "codigoMatricula";
            this.codigoMatricula.Size = new System.Drawing.Size(329, 30);
            this.codigoMatricula.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(16, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Código de Alumno";
            // 
            // cuposMatricula
            // 
            this.cuposMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cuposMatricula.Location = new System.Drawing.Point(21, 190);
            this.cuposMatricula.Name = "cuposMatricula";
            this.cuposMatricula.ReadOnly = true;
            this.cuposMatricula.Size = new System.Drawing.Size(89, 30);
            this.cuposMatricula.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cupos Disponibles";
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
            // matriculaGrupos
            // 
            this.matriculaGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.matriculaGrupos.FormattingEnabled = true;
            this.matriculaGrupos.Location = new System.Drawing.Point(21, 112);
            this.matriculaGrupos.Name = "matriculaGrupos";
            this.matriculaGrupos.Size = new System.Drawing.Size(329, 33);
            this.matriculaGrupos.TabIndex = 13;
            this.matriculaGrupos.SelectedIndexChanged += new System.EventHandler(this.matriculaGrupos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Matricular Alumno";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nuevoCodigo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nuevaContraseña);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nuevoUsuario);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.nuevoApellido);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nuevoNombre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guardarNuevoCursoBT);
            this.panel1.Location = new System.Drawing.Point(27, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 584);
            this.panel1.TabIndex = 14;
            // 
            // nuevoCodigo
            // 
            this.nuevoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nuevoCodigo.Location = new System.Drawing.Point(20, 348);
            this.nuevoCodigo.Name = "nuevoCodigo";
            this.nuevoCodigo.Size = new System.Drawing.Size(329, 30);
            this.nuevoCodigo.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Código de Alumno";
            // 
            // nuevaContraseña
            // 
            this.nuevaContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nuevaContraseña.Location = new System.Drawing.Point(20, 283);
            this.nuevaContraseña.Name = "nuevaContraseña";
            this.nuevaContraseña.Size = new System.Drawing.Size(329, 30);
            this.nuevaContraseña.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Contraseña";
            // 
            // nuevoUsuario
            // 
            this.nuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nuevoUsuario.Location = new System.Drawing.Point(20, 220);
            this.nuevoUsuario.Name = "nuevoUsuario";
            this.nuevoUsuario.Size = new System.Drawing.Size(329, 30);
            this.nuevoUsuario.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(15, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Usuario";
            // 
            // nuevoApellido
            // 
            this.nuevoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nuevoApellido.Location = new System.Drawing.Point(19, 157);
            this.nuevoApellido.Name = "nuevoApellido";
            this.nuevoApellido.Size = new System.Drawing.Size(329, 30);
            this.nuevoApellido.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apellidos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nuevoNombre
            // 
            this.nuevoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nuevoNombre.Location = new System.Drawing.Point(19, 94);
            this.nuevoNombre.Name = "nuevoNombre";
            this.nuevoNombre.Size = new System.Drawing.Size(329, 30);
            this.nuevoNombre.TabIndex = 8;
            this.nuevoNombre.TextChanged += new System.EventHandler(this.nuevoNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registrar Alumno";
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
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(19, 15);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(380, 46);
            this.titulo.TabIndex = 13;
            this.titulo.Text = "Gestión de Alumnos";
            // 
            // gestionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titulo);
            this.Name = "gestionAlumnos";
            this.Text = "gestionAlumnos";
            this.Load += new System.EventHandler(this.gestionAlumnos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button eliminarCursoBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button asignarCursoBT;
        private System.Windows.Forms.ComboBox matriculaGrupos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nuevoApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nuevoNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarNuevoCursoBT;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nuevaContraseña;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox nuevoUsuario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox codigoMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cuposMatricula;
        private System.Windows.Forms.TextBox nuevoCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox codigoRetiro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox retiroGrupos;
        private System.Windows.Forms.Label label14;
    }
}