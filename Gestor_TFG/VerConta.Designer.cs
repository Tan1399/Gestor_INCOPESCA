namespace Gestor_TFG
{
    partial class VerConta
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnvolver = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.REALIZÓ_MANTENIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_DE_SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_AGREGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGAR_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MantenimientoTI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ÚLTIMO_MATENIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.btnvolver);
            this.panel3.Location = new System.Drawing.Point(-1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 546);
            this.panel3.TabIndex = 32;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 140;
            this.iconPictureBox1.Location = new System.Drawing.Point(18, 24);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(140, 140);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 33;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Firebrick;
            this.btnvolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvolver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvolver.ForeColor = System.Drawing.Color.White;
            this.btnvolver.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnvolver.IconColor = System.Drawing.Color.White;
            this.btnvolver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnvolver.IconSize = 16;
            this.btnvolver.Location = new System.Drawing.Point(18, 302);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(132, 77);
            this.btnvolver.TabIndex = 32;
            this.btnvolver.Text = "Volver";
            this.btnvolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvdata);
            this.panel1.Location = new System.Drawing.Point(178, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 549);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.txtbusqueda);
            this.panel2.Controls.Add(this.cbobusqueda);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 84);
            this.panel2.TabIndex = 31;
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
            this.btnbuscar.Location = new System.Drawing.Point(1258, 22);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(59, 42);
            this.btnbuscar.TabIndex = 27;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(832, 34);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(207, 20);
            this.txtbusqueda.TabIndex = 26;
            // 
            // cbobusqueda
            // 
            this.cbobusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobusqueda.FormattingEnabled = true;
            this.cbobusqueda.Location = new System.Drawing.Point(519, 33);
            this.cbobusqueda.Name = "cbobusqueda";
            this.cbobusqueda.Size = new System.Drawing.Size(207, 21);
            this.cbobusqueda.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(390, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "VER";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REALIZÓ_MANTENIMIENTO,
            this.ID,
            this.TIPO,
            this.Column1,
            this.MODELO,
            this.MARCA,
            this.No_DE_SERIE,
            this.FECHA_AGREGADO,
            this.TRASLADO,
            this.FECHA_TRASLADO,
            this.LUGAR_TRASLADO,
            this.MantenimientoTI,
            this.ÚLTIMO_MATENIMIENTO});
            this.dgvdata.Location = new System.Drawing.Point(6, 105);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(1440, 432);
            this.dgvdata.TabIndex = 28;
            // 
            // REALIZÓ_MANTENIMIENTO
            // 
            this.REALIZÓ_MANTENIMIENTO.HeaderText = "ID";
            this.REALIZÓ_MANTENIMIENTO.Name = "REALIZÓ_MANTENIMIENTO";
            this.REALIZÓ_MANTENIMIENTO.ReadOnly = true;
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
            // No_DE_SERIE
            // 
            this.No_DE_SERIE.HeaderText = "No_SERIE";
            this.No_DE_SERIE.Name = "No_DE_SERIE";
            this.No_DE_SERIE.ReadOnly = true;
            // 
            // FECHA_AGREGADO
            // 
            this.FECHA_AGREGADO.HeaderText = "FECHA_AGREGADO";
            this.FECHA_AGREGADO.Name = "FECHA_AGREGADO";
            this.FECHA_AGREGADO.ReadOnly = true;
            this.FECHA_AGREGADO.Width = 115;
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
            // MantenimientoTI
            // 
            this.MantenimientoTI.HeaderText = "MANTENIMIENTO";
            this.MantenimientoTI.Name = "MantenimientoTI";
            this.MantenimientoTI.ReadOnly = true;
            // 
            // ÚLTIMO_MATENIMIENTO
            // 
            this.ÚLTIMO_MATENIMIENTO.HeaderText = "ULTIMO_MANTENIMIENTO";
            this.ÚLTIMO_MATENIMIENTO.Name = "ÚLTIMO_MATENIMIENTO";
            this.ÚLTIMO_MATENIMIENTO.ReadOnly = true;
            this.ÚLTIMO_MATENIMIENTO.Width = 150;
            // 
            // VerConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 554);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerConta";
            this.Text = "VerConta";
            this.Load += new System.EventHandler(this.VerConta_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnvolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn REALIZÓ_MANTENIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_DE_SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_AGREGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MantenimientoTI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ÚLTIMO_MATENIMIENTO;
    }
}