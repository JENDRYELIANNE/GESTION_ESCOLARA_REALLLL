namespace CAPA_PRESENTACION
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Maestrosbtn = new System.Windows.Forms.Button();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbAreaTecnica = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Limpiarbtn = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtdireccio = new System.Windows.Forms.TextBox();
            this.teltxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Telefonolbl = new System.Windows.Forms.Label();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.nombrelbl = new System.Windows.Forms.Label();
            this.Areatecnicalbl = new System.Windows.Forms.Label();
            this.Apellidolbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.Direccionlbl = new System.Windows.Forms.Label();
            this.Buscartxt = new System.Windows.Forms.TextBox();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Cerrarbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.Cerrarbtn);
            this.groupBox1.Controls.Add(this.Maestrosbtn);
            this.groupBox1.Controls.Add(this.Eliminarbtn);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.cmbAreaTecnica);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Limpiarbtn);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtdireccio);
            this.groupBox1.Controls.Add(this.teltxt);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.Telefonolbl);
            this.groupBox1.Controls.Add(this.Guardarbtn);
            this.groupBox1.Controls.Add(this.nombrelbl);
            this.groupBox1.Controls.Add(this.Areatecnicalbl);
            this.groupBox1.Controls.Add(this.Apellidolbl);
            this.groupBox1.Controls.Add(this.Emaillbl);
            this.groupBox1.Controls.Add(this.Direccionlbl);
            this.groupBox1.Location = new System.Drawing.Point(-7, -14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(602, 1067);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Maestrosbtn
            // 
            this.Maestrosbtn.Location = new System.Drawing.Point(50, 796);
            this.Maestrosbtn.Name = "Maestrosbtn";
            this.Maestrosbtn.Size = new System.Drawing.Size(481, 63);
            this.Maestrosbtn.TabIndex = 23;
            this.Maestrosbtn.Text = "Maestros";
            this.Maestrosbtn.UseVisualStyleBackColor = true;
            this.Maestrosbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Eliminarbtn.Location = new System.Drawing.Point(50, 634);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(492, 57);
            this.Eliminarbtn.TabIndex = 22;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = false;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnActualizar.Location = new System.Drawing.Point(47, 552);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(495, 58);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAreaTecnica
            // 
            this.cmbAreaTecnica.FormattingEnabled = true;
            this.cmbAreaTecnica.Location = new System.Drawing.Point(217, 419);
            this.cmbAreaTecnica.Name = "cmbAreaTecnica";
            this.cmbAreaTecnica.Size = new System.Drawing.Size(325, 28);
            this.cmbAreaTecnica.TabIndex = 20;
            this.cmbAreaTecnica.SelectedIndexChanged += new System.EventHandler(this.cmbAreaTecnica_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(-6, -15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1253, 99);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "LLENAR CON TUS DATOS";
            // 
            // Limpiarbtn
            // 
            this.Limpiarbtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Limpiarbtn.Location = new System.Drawing.Point(47, 710);
            this.Limpiarbtn.Name = "Limpiarbtn";
            this.Limpiarbtn.Size = new System.Drawing.Size(495, 61);
            this.Limpiarbtn.TabIndex = 17;
            this.Limpiarbtn.Text = "Limpiar";
            this.Limpiarbtn.UseVisualStyleBackColor = false;
            this.Limpiarbtn.Click += new System.EventHandler(this.Limpiarbtn_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtApellido.Location = new System.Drawing.Point(217, 158);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Multiline = true;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(325, 37);
            this.txtApellido.TabIndex = 12;
            // 
            // txtdireccio
            // 
            this.txtdireccio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtdireccio.Location = new System.Drawing.Point(217, 214);
            this.txtdireccio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdireccio.Multiline = true;
            this.txtdireccio.Name = "txtdireccio";
            this.txtdireccio.Size = new System.Drawing.Size(325, 37);
            this.txtdireccio.TabIndex = 11;
            // 
            // teltxt
            // 
            this.teltxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teltxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.teltxt.Location = new System.Drawing.Point(217, 267);
            this.teltxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.teltxt.Multiline = true;
            this.teltxt.Name = "teltxt";
            this.teltxt.Size = new System.Drawing.Size(325, 37);
            this.teltxt.TabIndex = 10;
            // 
            // emailtxt
            // 
            this.emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailtxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailtxt.Location = new System.Drawing.Point(217, 331);
            this.emailtxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.emailtxt.Multiline = true;
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(325, 37);
            this.emailtxt.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(217, 90);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 37);
            this.txtNombre.TabIndex = 7;
            // 
            // Telefonolbl
            // 
            this.Telefonolbl.AutoSize = true;
            this.Telefonolbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefonolbl.Location = new System.Drawing.Point(43, 284);
            this.Telefonolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefonolbl.Name = "Telefonolbl";
            this.Telefonolbl.Size = new System.Drawing.Size(89, 20);
            this.Telefonolbl.TabIndex = 3;
            this.Telefonolbl.Text = "Telefono";
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Guardarbtn.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Guardarbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbtn.Location = new System.Drawing.Point(47, 475);
            this.Guardarbtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(495, 45);
            this.Guardarbtn.TabIndex = 6;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = false;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrelbl.Location = new System.Drawing.Point(43, 107);
            this.nombrelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(80, 20);
            this.nombrelbl.TabIndex = 0;
            this.nombrelbl.Text = "Nombre";
            // 
            // Areatecnicalbl
            // 
            this.Areatecnicalbl.AutoSize = true;
            this.Areatecnicalbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Areatecnicalbl.Location = new System.Drawing.Point(43, 419);
            this.Areatecnicalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Areatecnicalbl.Name = "Areatecnicalbl";
            this.Areatecnicalbl.Size = new System.Drawing.Size(128, 20);
            this.Areatecnicalbl.TabIndex = 5;
            this.Areatecnicalbl.Text = "Area tecnica";
            // 
            // Apellidolbl
            // 
            this.Apellidolbl.AutoSize = true;
            this.Apellidolbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidolbl.Location = new System.Drawing.Point(43, 175);
            this.Apellidolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Apellidolbl.Name = "Apellidolbl";
            this.Apellidolbl.Size = new System.Drawing.Size(82, 20);
            this.Apellidolbl.TabIndex = 1;
            this.Apellidolbl.Text = "Apellido";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(43, 348);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(58, 20);
            this.Emaillbl.TabIndex = 4;
            this.Emaillbl.Text = "Email";
            // 
            // Direccionlbl
            // 
            this.Direccionlbl.AutoSize = true;
            this.Direccionlbl.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccionlbl.Location = new System.Drawing.Point(43, 231);
            this.Direccionlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Direccionlbl.Name = "Direccionlbl";
            this.Direccionlbl.Size = new System.Drawing.Size(96, 20);
            this.Direccionlbl.TabIndex = 2;
            this.Direccionlbl.Text = "Direccion";
            // 
            // Buscartxt
            // 
            this.Buscartxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Buscartxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Buscartxt.Location = new System.Drawing.Point(739, 14);
            this.Buscartxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Buscartxt.Multiline = true;
            this.Buscartxt.Name = "Buscartxt";
            this.Buscartxt.Size = new System.Drawing.Size(677, 37);
            this.Buscartxt.TabIndex = 27;
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.BackColor = System.Drawing.Color.LightPink;
            this.Buscarbtn.Location = new System.Drawing.Point(604, 14);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(128, 37);
            this.Buscarbtn.TabIndex = 26;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = false;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(601, 57);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(1050, 981);
            this.dgvDatos.TabIndex = 25;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            // 
            // Cerrarbtn
            // 
            this.Cerrarbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Cerrarbtn.Location = new System.Drawing.Point(50, 978);
            this.Cerrarbtn.Name = "Cerrarbtn";
            this.Cerrarbtn.Size = new System.Drawing.Size(495, 61);
            this.Cerrarbtn.TabIndex = 18;
            this.Cerrarbtn.Text = "Cerrar";
            this.Cerrarbtn.UseVisualStyleBackColor = false;
            this.Cerrarbtn.Click += new System.EventHandler(this.Cerrarbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1666, 1050);
            this.Controls.Add(this.Buscartxt);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiarbtn;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtdireccio;
        private System.Windows.Forms.TextBox teltxt;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label Telefonolbl;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label Areatecnicalbl;
        private System.Windows.Forms.Label Apellidolbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label Direccionlbl;
        private System.Windows.Forms.TextBox Buscartxt;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cmbAreaTecnica;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Button Maestrosbtn;
        private System.Windows.Forms.Button Cerrarbtn;
    }
}

