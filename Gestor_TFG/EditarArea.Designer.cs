namespace Gestor_TFG
{
    partial class EditarArea
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
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbobusqueda = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona_Asignada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_DE_SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_AGREGADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUGAR_TRASLADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MantenimientoTI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ULTIMO_MANTENIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbomaintence = new System.Windows.Forms.ComboBox();
            this.cbotraslado = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(100, 30);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(53, 20);
            this.txtindice.TabIndex = 157;
            this.txtindice.Text = "-1";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(159, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(53, 20);
            this.txtid.TabIndex = 156;
            this.txtid.Text = "0";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.RosyBrown;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(9, 599);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(189, 23);
            this.iconButton1.TabIndex = 155;
            this.iconButton1.Text = "Volver";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btneditar.IconColor = System.Drawing.Color.White;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 16;
            this.btneditar.Location = new System.Drawing.Point(9, 561);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(189, 23);
            this.btneditar.TabIndex = 154;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvdata);
            this.panel1.Location = new System.Drawing.Point(229, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 549);
            this.panel1.TabIndex = 153;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.txtbusqueda);
            this.panel2.Controls.Add(this.cbobusqueda);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
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
            this.btnbuscar.Location = new System.Drawing.Point(1206, 22);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(91, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 55);
            this.label12.TabIndex = 0;
            this.label12.Text = "EDITAR";
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.ID,
            this.Persona_Asignada,
            this.TIPO,
            this.Valor,
            this.MODELO,
            this.MARCA,
            this.No_DE_SERIE,
            this.FECHA_AGREGADO,
            this.TRASLADO,
            this.FECHA_TRASLADO,
            this.LUGAR_TRASLADO,
            this.MantenimientoTI,
            this.ULTIMO_MANTENIMIENTO});
            this.dgvdata.Location = new System.Drawing.Point(7, 105);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.Size = new System.Drawing.Size(1366, 432);
            this.dgvdata.TabIndex = 28;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick_1);
            this.dgvdata.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvdata_CellPainting);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 25;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Persona_Asignada
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Persona_Asignada.DefaultCellStyle = dataGridViewCellStyle1;
            this.Persona_Asignada.HeaderText = "Persona_Asignada";
            this.Persona_Asignada.Name = "Persona_Asignada";
            this.Persona_Asignada.ReadOnly = true;
            // 
            // TIPO
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIPO.DefaultCellStyle = dataGridViewCellStyle2;
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "VALOR";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
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
            // ULTIMO_MANTENIMIENTO
            // 
            this.ULTIMO_MANTENIMIENTO.HeaderText = "ULTIMO_MANTENIMIENTO";
            this.ULTIMO_MANTENIMIENTO.Name = "ULTIMO_MANTENIMIENTO";
            this.ULTIMO_MANTENIMIENTO.ReadOnly = true;
            this.ULTIMO_MANTENIMIENTO.Width = 150;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(10, 518);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker2.TabIndex = 152;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 151;
            this.label11.Text = "Ultimo_Mantenimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 150;
            this.label10.Text = "Mantenimiento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "Lugar_Traslado";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(10, 436);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(164, 20);
            this.textBox7.TabIndex = 148;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 400);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(201, 20);
            this.dateTimePicker1.TabIndex = 147;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 146;
            this.label8.Text = "Fecha_Traslado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 145;
            this.label7.Text = "Traslado";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(10, 321);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(202, 20);
            this.dateTimePicker3.TabIndex = 144;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 143;
            this.label6.Text = "Fecha_Agregado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 142;
            this.label5.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 141;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 140;
            this.label3.Text = "No_Serie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 139;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "Tipo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 137;
            this.label15.Text = "Persona asiganada:";
            // 
            // cbomaintence
            // 
            this.cbomaintence.BackColor = System.Drawing.SystemColors.Window;
            this.cbomaintence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomaintence.FormattingEnabled = true;
            this.cbomaintence.Location = new System.Drawing.Point(11, 475);
            this.cbomaintence.Name = "cbomaintence";
            this.cbomaintence.Size = new System.Drawing.Size(201, 21);
            this.cbomaintence.TabIndex = 136;
            this.cbomaintence.SelectedIndexChanged += new System.EventHandler(this.cbomaintence_SelectedIndexChanged_1);
            // 
            // cbotraslado
            // 
            this.cbotraslado.BackColor = System.Drawing.SystemColors.Window;
            this.cbotraslado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotraslado.FormattingEnabled = true;
            this.cbotraslado.Location = new System.Drawing.Point(10, 360);
            this.cbotraslado.Name = "cbotraslado";
            this.cbotraslado.Size = new System.Drawing.Size(202, 21);
            this.cbotraslado.TabIndex = 135;
            this.cbotraslado.SelectedIndexChanged += new System.EventHandler(this.cbotraslado_SelectedIndexChanged_1);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(10, 282);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(164, 20);
            this.textBox6.TabIndex = 134;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(9, 240);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(165, 20);
            this.textBox5.TabIndex = 133;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 20);
            this.textBox4.TabIndex = 132;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 20);
            this.textBox3.TabIndex = 131;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 20);
            this.textBox2.TabIndex = 130;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 129;
            // 
            // EditarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 630);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbomaintence);
            this.Controls.Add(this.cbotraslado);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarArea";
            this.Text = "EditarArea";
            this.Load += new System.EventHandler(this.EditarArea_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtid;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btneditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbobusqueda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewButtonColumn btnseleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona_Asignada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_DE_SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_AGREGADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUGAR_TRASLADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MantenimientoTI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ULTIMO_MANTENIMIENTO;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbomaintence;
        private System.Windows.Forms.ComboBox cbotraslado;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}