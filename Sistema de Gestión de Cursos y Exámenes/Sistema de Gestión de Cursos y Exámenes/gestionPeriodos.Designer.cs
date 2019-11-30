namespace Sistema_de_Gestión_de_Cursos_y_Exámenes
{
    partial class gestionPeriodos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.abrirPeriodoBT = new System.Windows.Forms.Button();
            this.nuevoPeriodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calendarPeriodo = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cerrarPeriodoBT = new System.Windows.Forms.Button();
            this.periodoEliminado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.abrirPeriodoBT);
            this.panel2.Controls.Add(this.nuevoPeriodo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.calendarPeriodo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(48, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 567);
            this.panel2.TabIndex = 4;
            // 
            // abrirPeriodoBT
            // 
            this.abrirPeriodoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.abrirPeriodoBT.Location = new System.Drawing.Point(112, 504);
            this.abrirPeriodoBT.Name = "abrirPeriodoBT";
            this.abrirPeriodoBT.Size = new System.Drawing.Size(220, 47);
            this.abrirPeriodoBT.TabIndex = 13;
            this.abrirPeriodoBT.Text = "Guardar";
            this.abrirPeriodoBT.UseVisualStyleBackColor = true;
            this.abrirPeriodoBT.Click += new System.EventHandler(this.abrirPeriodoBT_Click);
            // 
            // nuevoPeriodo
            // 
            this.nuevoPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nuevoPeriodo.Location = new System.Drawing.Point(21, 284);
            this.nuevoPeriodo.Name = "nuevoPeriodo";
            this.nuevoPeriodo.Size = new System.Drawing.Size(329, 30);
            this.nuevoPeriodo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // calendarPeriodo
            // 
            this.calendarPeriodo.Location = new System.Drawing.Point(162, 77);
            this.calendarPeriodo.MaxSelectionCount = 365;
            this.calendarPeriodo.Name = "calendarPeriodo";
            this.calendarPeriodo.TabIndex = 20;
            this.calendarPeriodo.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarPeriodo_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Abrir Periodo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(16, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Duración";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cerrarPeriodoBT);
            this.panel3.Controls.Add(this.periodoEliminado);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(534, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(376, 567);
            this.panel3.TabIndex = 5;
            // 
            // cerrarPeriodoBT
            // 
            this.cerrarPeriodoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cerrarPeriodoBT.Location = new System.Drawing.Point(78, 504);
            this.cerrarPeriodoBT.Name = "cerrarPeriodoBT";
            this.cerrarPeriodoBT.Size = new System.Drawing.Size(220, 47);
            this.cerrarPeriodoBT.TabIndex = 18;
            this.cerrarPeriodoBT.Text = "Guardar";
            this.cerrarPeriodoBT.UseVisualStyleBackColor = true;
            this.cerrarPeriodoBT.Click += new System.EventHandler(this.cerrarPeriodoBT_Click);
            // 
            // periodoEliminado
            // 
            this.periodoEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.periodoEliminado.FormattingEnabled = true;
            this.periodoEliminado.Location = new System.Drawing.Point(21, 105);
            this.periodoEliminado.Name = "periodoEliminado";
            this.periodoEliminado.Size = new System.Drawing.Size(329, 33);
            this.periodoEliminado.TabIndex = 19;
            this.periodoEliminado.SelectedIndexChanged += new System.EventHandler(this.periodoEliminado_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(125)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eliminar Periodo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(478, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "Retroceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.Transparent;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.titulo.ForeColor = System.Drawing.Color.Black;
            this.titulo.Location = new System.Drawing.Point(40, 9);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(383, 46);
            this.titulo.TabIndex = 23;
            this.titulo.Text = "Gestión de Periodos";
            // 
            // gestionPeriodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.panel2);
            this.Name = "gestionPeriodos";
            this.Text = "gestionPeriodos";
            this.Load += new System.EventHandler(this.gestionPeriodos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar calendarPeriodo;
        private System.Windows.Forms.TextBox nuevoPeriodo;
        private System.Windows.Forms.Button abrirPeriodoBT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cerrarPeriodoBT;
        private System.Windows.Forms.ComboBox periodoEliminado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label titulo;
    }
}