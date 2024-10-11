namespace Gestor_TFG
{
    partial class agregarname
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_AGREGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REALIZÓ_MANTENIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_DE_SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGAR_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÚLTIMO_MATENIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbomaintence = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-1, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 71;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(-4, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 72;
            this.label15.Text = "Persona asiganada:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.dgvdata);
            this.panel1.Controls.Add(this.btnlimpiar);
            this.panel1.Controls.Add(this.btnbuscar);
            this.panel1.Controls.Add(this.txtbusqueda);
            this.panel1.Controls.Add(this.cbobusqueda);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(208, -64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 579);
            this.panel1.TabIndex = 73;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TIPO,
            this.Column1,
            this.FECHA_AGREGADO,
            this.REALIZÓ_MANTENIMIENTO,
            this.No_DE_SERIE,
            this.TRASLADO,
            this.FECHA_TRASLADO,
            this.LUGAR_TRASLADO,
            this.ÚLTIMO_MATENIMIENTO,
            this.MODELO,
            this.MARCA});
            this.dgvdata.Location = new System.Drawing.Point(3, 64);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(1338, 515);
            this.dgvdata.TabIndex = 28;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "Persona_Asignada";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TIPO
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle2;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "VALOR";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // FECHA_AGREGADO
            // 
            this.FECHA_AGREGADO.HeaderText = "FECHA_AGREGADO";
            this.FECHA_AGREGADO.Name = "FECHA_AGREGADO";
            this.FECHA_AGREGADO.ReadOnly = true;
            this.FECHA_AGREGADO.Width = 115;
            // 
            // REALIZÓ_MANTENIMIENTO
            // 
            this.REALIZÓ_MANTENIMIENTO.HeaderText = "ID";
            this.REALIZÓ_MANTENIMIENTO.Name = "REALIZÓ_MANTENIMIENTO";
            this.REALIZÓ_MANTENIMIENTO.ReadOnly = true;
            // 
            // No_DE_SERIE
            // 
            this.No_DE_SERIE.HeaderText = "No_SERIE";
            this.No_DE_SERIE.Name = "No_DE_SERIE";
            this.No_DE_SERIE.ReadOnly = true;
            // 
            // TRASLADO
            // 
            this.TRASLADO.HeaderText = "TRASLADO";
            this.TRASLADO.Name = "TRASLADO";
            this.TRASLADO.ReadOnly = true;
            // 
            // FECHA_TRASLADO
            // 
            this.FECHA_TRASLADO.HeaderText = "FECHA_TRASLADO";
            this.FECHA_TRASLADO.Name = "FECHA_TRASLADO";
            this.FECHA_TRASLADO.ReadOnly = true;
            this.FECHA_TRASLADO.Width = 115;
            // 
            // LUGAR_TRASLADO
            // 
            this.LUGAR_TRASLADO.HeaderText = "LUGAR_TRASLADO";
            this.LUGAR_TRASLADO.Name = "LUGAR_TRASLADO";
            this.LUGAR_TRASLADO.ReadOnly = true;
            this.LUGAR_TRASLADO.Width = 115;
            // 
            // ÚLTIMO_MATENIMIENTO
            // 
            this.ÚLTIMO_MATENIMIENTO.HeaderText = "ULTIMO_MANTENIMIENTO";
            this.ÚLTIMO_MATENIMIENTO.Name = "ÚLTIMO_MATENIMIENTO";
            this.ÚLTIMO_MATENIMIENTO.ReadOnly = true;
            this.ÚLTIMO_MATENIMIENTO.Width = 150;
            // 
            // MODELO
            // 
            this.MODELO.HeaderText = "MODELO";
            this.MODELO.Name = "MODELO";
            this.MODELO.ReadOnly = true;
            // 
            // MARCA
            // 
            this.MARCA.HeaderText = "MARCA";
            this.MARCA.Name = "MARCA";
            this.MARCA.ReadOnly = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.SystemColors.Window;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(1201, 22);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(29, 23);
            this.btnlimpiar.TabIndex = 27;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(1149, 22);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(30, 23);
            this.btnbuscar.TabIndex = 26;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(916, 24);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(207, 20);
            this.txtbusqueda.TabIndex = 25;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(691, 24);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(207, 21);
            this.cbobusqueda.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(610, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Buscar por:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(5, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1441, 42);
            this.label13.TabIndex = 21;
            this.label13.Text = "Agregar";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.S;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(2, 325);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(189, 23);
            this.btnguardar.TabIndex = 74;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RosyBrown;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.S;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(2, 354);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(189, 23);
            this.iconButton1.TabIndex = 75;
            this.iconButton1.Text = "Volver";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1, 92);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker3.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Fecha";
            // 
            // cbomaintence
            // 
            this.cbomaintence.BackColor = System.Drawing.SystemColors.Window;
            this.cbomaintence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomaintence.FormattingEnabled = true;
            this.cbomaintence.Location = new System.Drawing.Point(2, 141);
            this.cbomaintence.Name = "cbomaintence";
            this.cbomaintence.Size = new System.Drawing.Size(190, 21);
            this.cbomaintence.TabIndex = 78;
            this.cbomaintence.SelectedIndexChanged += new System.EventHandler(this.cbomaintence_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "SI/NO";
            // 
            // agregarname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 595);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbomaintence);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox1);
            this.Name = "agregarname";
            this.Text = "agregarname";
            this.Load += new System.EventHandler(this.agregarname_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvdata;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbomaintence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_AGREGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn REALIZÓ_MANTENIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_DE_SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÚLTIMO_MATENIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
    }
}