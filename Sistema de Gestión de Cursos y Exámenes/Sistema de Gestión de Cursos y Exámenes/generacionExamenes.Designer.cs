﻿namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class generacionExamenes
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
            this.EtiquetaCurso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guardarConfExamen = new System.Windows.Forms.Button();
            this.SeleccionarCurso = new System.Windows.Forms.ComboBox();
            this.EtiquetaGrupo = new System.Windows.Forms.Label();
            this.SeleccionarGrupo = new System.Windows.Forms.ComboBox();
            this.EtiquetaFecha = new System.Windows.Forms.Label();
            this.calendarExamen = new System.Windows.Forms.MonthCalendar();
            this.EtiquetaDuracion = new System.Windows.Forms.Label();
            this.SeleccionarDuracion = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GuardarExamen = new System.Windows.Forms.Button();
            this.IndiceExamen = new System.Windows.Forms.TextBox();
            this.IndiceBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IndiceExamenPuntaje = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PuntajeCambiar = new System.Windows.Forms.TextBox();
            this.EtiquetaNpreguntas = new System.Windows.Forms.Label();
            this.NumeroPreguntas = new System.Windows.Forms.TextBox();
            this.GuardarExamen2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.titulo.Size = new System.Drawing.Size(440, 46);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Generación de Examen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.NumeroPreguntas);
            this.panel1.Controls.Add(this.EtiquetaNpreguntas);
            this.panel1.Controls.Add(this.SeleccionarDuracion);
            this.panel1.Controls.Add(this.EtiquetaDuracion);
            this.panel1.Controls.Add(this.calendarExamen);
            this.panel1.Controls.Add(this.EtiquetaFecha);
            this.panel1.Controls.Add(this.SeleccionarGrupo);
            this.panel1.Controls.Add(this.EtiquetaGrupo);
            this.panel1.Controls.Add(this.SeleccionarCurso);
            this.panel1.Controls.Add(this.EtiquetaCurso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guardarConfExamen);
            this.panel1.Location = new System.Drawing.Point(20, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 584);
            this.panel1.TabIndex = 2;
            // 
            // EtiquetaCurso
            // 
            this.EtiquetaCurso.AutoSize = true;
            this.EtiquetaCurso.BackColor = System.Drawing.Color.Transparent;
            this.EtiquetaCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EtiquetaCurso.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaCurso.Location = new System.Drawing.Point(14, 64);
            this.EtiquetaCurso.Name = "EtiquetaCurso";
            this.EtiquetaCurso.Size = new System.Drawing.Size(65, 25);
            this.EtiquetaCurso.TabIndex = 5;
            this.EtiquetaCurso.Text = "Curso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generar Examen";
            // 
            // guardarConfExamen
            // 
            this.guardarConfExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.guardarConfExamen.Location = new System.Drawing.Point(53, 518);
            this.guardarConfExamen.Name = "guardarConfExamen";
            this.guardarConfExamen.Size = new System.Drawing.Size(265, 47);
            this.guardarConfExamen.TabIndex = 11;
            this.guardarConfExamen.Text = "Generar Examen Aleatorio";
            this.guardarConfExamen.UseVisualStyleBackColor = true;
            // 
            // SeleccionarCurso
            // 
            this.SeleccionarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeleccionarCurso.FormattingEnabled = true;
            this.SeleccionarCurso.Location = new System.Drawing.Point(19, 92);
            this.SeleccionarCurso.Name = "SeleccionarCurso";
            this.SeleccionarCurso.Size = new System.Drawing.Size(329, 33);
            this.SeleccionarCurso.TabIndex = 14;
            // 
            // EtiquetaGrupo
            // 
            this.EtiquetaGrupo.AutoSize = true;
            this.EtiquetaGrupo.BackColor = System.Drawing.Color.Transparent;
            this.EtiquetaGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EtiquetaGrupo.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaGrupo.Location = new System.Drawing.Point(14, 128);
            this.EtiquetaGrupo.Name = "EtiquetaGrupo";
            this.EtiquetaGrupo.Size = new System.Drawing.Size(66, 25);
            this.EtiquetaGrupo.TabIndex = 15;
            this.EtiquetaGrupo.Text = "Grupo";
            // 
            // SeleccionarGrupo
            // 
            this.SeleccionarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeleccionarGrupo.FormattingEnabled = true;
            this.SeleccionarGrupo.Location = new System.Drawing.Point(19, 156);
            this.SeleccionarGrupo.Name = "SeleccionarGrupo";
            this.SeleccionarGrupo.Size = new System.Drawing.Size(329, 33);
            this.SeleccionarGrupo.TabIndex = 16;
            // 
            // EtiquetaFecha
            // 
            this.EtiquetaFecha.AutoSize = true;
            this.EtiquetaFecha.BackColor = System.Drawing.Color.Transparent;
            this.EtiquetaFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EtiquetaFecha.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaFecha.Location = new System.Drawing.Point(14, 192);
            this.EtiquetaFecha.Name = "EtiquetaFecha";
            this.EtiquetaFecha.Size = new System.Drawing.Size(67, 25);
            this.EtiquetaFecha.TabIndex = 17;
            this.EtiquetaFecha.Text = "Fecha";
            // 
            // calendarExamen
            // 
            this.calendarExamen.Location = new System.Drawing.Point(53, 216);
            this.calendarExamen.MaxSelectionCount = 365;
            this.calendarExamen.Name = "calendarExamen";
            this.calendarExamen.TabIndex = 21;
            // 
            // EtiquetaDuracion
            // 
            this.EtiquetaDuracion.AutoSize = true;
            this.EtiquetaDuracion.BackColor = System.Drawing.Color.Transparent;
            this.EtiquetaDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EtiquetaDuracion.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaDuracion.Location = new System.Drawing.Point(14, 387);
            this.EtiquetaDuracion.Name = "EtiquetaDuracion";
            this.EtiquetaDuracion.Size = new System.Drawing.Size(90, 25);
            this.EtiquetaDuracion.TabIndex = 22;
            this.EtiquetaDuracion.Text = "Duración";
            // 
            // SeleccionarDuracion
            // 
            this.SeleccionarDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SeleccionarDuracion.FormattingEnabled = true;
            this.SeleccionarDuracion.Location = new System.Drawing.Point(19, 415);
            this.SeleccionarDuracion.Name = "SeleccionarDuracion";
            this.SeleccionarDuracion.Size = new System.Drawing.Size(329, 33);
            this.SeleccionarDuracion.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.GuardarExamen2);
            this.panel2.Controls.Add(this.PuntajeCambiar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.IndiceExamenPuntaje);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.IndiceBanco);
            this.panel2.Controls.Add(this.IndiceExamen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.GuardarExamen);
            this.panel2.Location = new System.Drawing.Point(436, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 584);
            this.panel2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 50);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ingrese el número de pregunta del \r\nBanco de Preguntas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 50);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese el número de pregunta del \r\nexamen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(13, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cambiar preguntas";
            // 
            // GuardarExamen
            // 
            this.GuardarExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GuardarExamen.Location = new System.Drawing.Point(69, 518);
            this.GuardarExamen.Name = "GuardarExamen";
            this.GuardarExamen.Size = new System.Drawing.Size(220, 47);
            this.GuardarExamen.TabIndex = 11;
            this.GuardarExamen.Text = "Guardar cambios";
            this.GuardarExamen.UseVisualStyleBackColor = true;
            // 
            // IndiceExamen
            // 
            this.IndiceExamen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IndiceExamen.Location = new System.Drawing.Point(19, 117);
            this.IndiceExamen.Name = "IndiceExamen";
            this.IndiceExamen.Size = new System.Drawing.Size(123, 30);
            this.IndiceExamen.TabIndex = 24;
            // 
            // IndiceBanco
            // 
            this.IndiceBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IndiceBanco.Location = new System.Drawing.Point(19, 203);
            this.IndiceBanco.Name = "IndiceBanco";
            this.IndiceBanco.Size = new System.Drawing.Size(123, 30);
            this.IndiceBanco.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(13, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cambiar puntajes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 50);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ingrese el número de pregunta del \r\nexamen:";
            // 
            // IndiceExamenPuntaje
            // 
            this.IndiceExamenPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IndiceExamenPuntaje.Location = new System.Drawing.Point(19, 399);
            this.IndiceExamenPuntaje.Name = "IndiceExamenPuntaje";
            this.IndiceExamenPuntaje.Size = new System.Drawing.Size(123, 30);
            this.IndiceExamenPuntaje.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ingrese el puntaje que desea asignar:";
            // 
            // PuntajeCambiar
            // 
            this.PuntajeCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PuntajeCambiar.Location = new System.Drawing.Point(19, 460);
            this.PuntajeCambiar.Name = "PuntajeCambiar";
            this.PuntajeCambiar.Size = new System.Drawing.Size(123, 30);
            this.PuntajeCambiar.TabIndex = 30;
            // 
            // EtiquetaNpreguntas
            // 
            this.EtiquetaNpreguntas.AutoSize = true;
            this.EtiquetaNpreguntas.BackColor = System.Drawing.Color.Transparent;
            this.EtiquetaNpreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EtiquetaNpreguntas.ForeColor = System.Drawing.Color.Black;
            this.EtiquetaNpreguntas.Location = new System.Drawing.Point(14, 451);
            this.EtiquetaNpreguntas.Name = "EtiquetaNpreguntas";
            this.EtiquetaNpreguntas.Size = new System.Drawing.Size(202, 25);
            this.EtiquetaNpreguntas.TabIndex = 24;
            this.EtiquetaNpreguntas.Text = "Numero de Preguntas";
            // 
            // NumeroPreguntas
            // 
            this.NumeroPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NumeroPreguntas.Location = new System.Drawing.Point(19, 479);
            this.NumeroPreguntas.Name = "NumeroPreguntas";
            this.NumeroPreguntas.Size = new System.Drawing.Size(123, 30);
            this.NumeroPreguntas.TabIndex = 31;
            // 
            // GuardarExamen2
            // 
            this.GuardarExamen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GuardarExamen2.Location = new System.Drawing.Point(69, 239);
            this.GuardarExamen2.Name = "GuardarExamen2";
            this.GuardarExamen2.Size = new System.Drawing.Size(220, 47);
            this.GuardarExamen2.TabIndex = 31;
            this.GuardarExamen2.Text = "Guardar cambios";
            this.GuardarExamen2.UseVisualStyleBackColor = true;
            // 
            // generacionExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titulo);
            this.Name = "generacionExamenes";
            this.Text = "generacionExamenes";
            this.Load += new System.EventHandler(this.generacionExamenes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EtiquetaCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guardarConfExamen;
        private System.Windows.Forms.Label EtiquetaFecha;
        private System.Windows.Forms.ComboBox SeleccionarGrupo;
        private System.Windows.Forms.Label EtiquetaGrupo;
        private System.Windows.Forms.ComboBox SeleccionarCurso;
        private System.Windows.Forms.ComboBox SeleccionarDuracion;
        private System.Windows.Forms.Label EtiquetaDuracion;
        private System.Windows.Forms.MonthCalendar calendarExamen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarExamen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IndiceBanco;
        private System.Windows.Forms.TextBox IndiceExamen;
        private System.Windows.Forms.TextBox NumeroPreguntas;
        private System.Windows.Forms.Label EtiquetaNpreguntas;
        private System.Windows.Forms.TextBox PuntajeCambiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IndiceExamenPuntaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GuardarExamen2;
    }
}