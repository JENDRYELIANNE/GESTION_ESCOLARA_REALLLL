namespace CAPA_PRESENTACION
{
    partial class frmMaestro1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaestro1));
            this.Cerrarbtn = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maestrocmb = new System.Windows.Forms.ComboBox();
            this.materiacmb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.estudiantecmb = new System.Windows.Forms.ComboBox();
            this.GuardadAbtn = new System.Windows.Forms.Button();
            this.areacmb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Limpiarbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.buscartxt = new System.Windows.Forms.TextBox();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verReportebtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrarbtn
            // 
            this.Cerrarbtn.BackColor = System.Drawing.Color.DarkBlue;
            this.Cerrarbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cerrarbtn.Location = new System.Drawing.Point(1045, 653);
            this.Cerrarbtn.Name = "Cerrarbtn";
            this.Cerrarbtn.Size = new System.Drawing.Size(147, 35);
            this.Cerrarbtn.TabIndex = 2;
            this.Cerrarbtn.Text = "Cerrar";
            this.Cerrarbtn.UseVisualStyleBackColor = false;
            this.Cerrarbtn.Click += new System.EventHandler(this.Cerrarbtn_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Regresar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Regresar.Location = new System.Drawing.Point(383, 653);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(154, 35);
            this.Regresar.TabIndex = 3;
            this.Regresar.Text = "⇚ Regresar ";
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.verReportebtn);
            this.groupBox1.Controls.Add(this.maestrocmb);
            this.groupBox1.Controls.Add(this.materiacmb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Eliminarbtn);
            this.groupBox1.Controls.Add(this.estudiantecmb);
            this.groupBox1.Controls.Add(this.GuardadAbtn);
            this.groupBox1.Controls.Add(this.areacmb);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Limpiarbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-13, -25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 819);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // maestrocmb
            // 
            this.maestrocmb.FormattingEnabled = true;
            this.maestrocmb.Location = new System.Drawing.Point(178, 310);
            this.maestrocmb.Name = "maestrocmb";
            this.maestrocmb.Size = new System.Drawing.Size(182, 28);
            this.maestrocmb.TabIndex = 27;
            this.maestrocmb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // materiacmb
            // 
            this.materiacmb.FormattingEnabled = true;
            this.materiacmb.Location = new System.Drawing.Point(178, 262);
            this.materiacmb.Name = "materiacmb";
            this.materiacmb.Size = new System.Drawing.Size(182, 28);
            this.materiacmb.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 25;
            this.label5.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 27);
            this.label4.TabIndex = 24;
            this.label4.Text = "Maestro";
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.BackColor = System.Drawing.Color.Navy;
            this.Eliminarbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminarbtn.Location = new System.Drawing.Point(59, 465);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(244, 57);
            this.Eliminarbtn.TabIndex = 23;
            this.Eliminarbtn.Text = "Eliminar ✖️";
            this.Eliminarbtn.UseVisualStyleBackColor = false;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // estudiantecmb
            // 
            this.estudiantecmb.FormattingEnabled = true;
            this.estudiantecmb.Location = new System.Drawing.Point(178, 127);
            this.estudiantecmb.Name = "estudiantecmb";
            this.estudiantecmb.Size = new System.Drawing.Size(182, 28);
            this.estudiantecmb.TabIndex = 22;
            // 
            // GuardadAbtn
            // 
            this.GuardadAbtn.BackColor = System.Drawing.Color.RoyalBlue;
            this.GuardadAbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardadAbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GuardadAbtn.Location = new System.Drawing.Point(59, 379);
            this.GuardadAbtn.Name = "GuardadAbtn";
            this.GuardadAbtn.Size = new System.Drawing.Size(244, 54);
            this.GuardadAbtn.TabIndex = 20;
            this.GuardadAbtn.Text = "Guardar asignación";
            this.GuardadAbtn.UseVisualStyleBackColor = false;
            this.GuardadAbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // areacmb
            // 
            this.areacmb.FormattingEnabled = true;
            this.areacmb.Location = new System.Drawing.Point(178, 198);
            this.areacmb.Name = "areacmb";
            this.areacmb.Size = new System.Drawing.Size(182, 28);
            this.areacmb.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 81);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(75, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "ASIGNACIONES";
            // 
            // Limpiarbtn
            // 
            this.Limpiarbtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.Limpiarbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Limpiarbtn.Location = new System.Drawing.Point(59, 557);
            this.Limpiarbtn.Name = "Limpiarbtn";
            this.Limpiarbtn.Size = new System.Drawing.Size(244, 55);
            this.Limpiarbtn.TabIndex = 15;
            this.Limpiarbtn.Text = "Limpiar 🧹";
            this.Limpiarbtn.UseVisualStyleBackColor = false;
            this.Limpiarbtn.Click += new System.EventHandler(this.Limpiarbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "area tecnica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estudiante";
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Buscarbtn.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbtn.Location = new System.Drawing.Point(369, 16);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(148, 41);
            this.Buscarbtn.TabIndex = 5;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = false;
            this.Buscarbtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // buscartxt
            // 
            this.buscartxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscartxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buscartxt.Location = new System.Drawing.Point(532, 20);
            this.buscartxt.Multiline = true;
            this.buscartxt.Name = "buscartxt";
            this.buscartxt.Size = new System.Drawing.Size(589, 37);
            this.buscartxt.TabIndex = 7;
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(369, 84);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.RowHeadersWidth = 62;
            this.dgvMaterias.RowTemplate.Height = 28;
            this.dgvMaterias.Size = new System.Drawing.Size(823, 563);
            this.dgvMaterias.TabIndex = 9;
            this.dgvMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellContentClick);
            // 
            // verReportebtn
            // 
            this.verReportebtn.Location = new System.Drawing.Point(59, 647);
            this.verReportebtn.Name = "verReportebtn";
            this.verReportebtn.Size = new System.Drawing.Size(244, 66);
            this.verReportebtn.TabIndex = 28;
            this.verReportebtn.Text = "VER REPORTE 📋";
            this.verReportebtn.UseVisualStyleBackColor = true;
            this.verReportebtn.Click += new System.EventHandler(this.verReportebtn_Click);
            // 
            // frmMaestro1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1204, 714);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.buscartxt);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Cerrarbtn);
            this.Controls.Add(this.Regresar);
            this.Name = "frmMaestro1";
            this.Text = "frmMaestro1";
            this.Load += new System.EventHandler(this.frmMaestro1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Cerrarbtn;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.TextBox buscartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Limpiarbtn;
        private System.Windows.Forms.ComboBox areacmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GuardadAbtn;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ComboBox estudiantecmb;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.ComboBox maestrocmb;
        private System.Windows.Forms.ComboBox materiacmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button verReportebtn;
    }
}