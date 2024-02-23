namespace Gestor_TFG
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.Prueba = new System.Windows.Forms.Label();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.Dep_info = new FontAwesome.Sharp.IconMenuItem();
            this.Dep_contabilidad = new FontAwesome.Sharp.IconMenuItem();
            this.Dep_Recursoshumanos = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 164);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1117, 158);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip2.Location = new System.Drawing.Point(0, 24);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1117, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // Prueba
            // 
            this.Prueba.AutoSize = true;
            this.Prueba.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Prueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Prueba.ForeColor = System.Drawing.Color.White;
            this.Prueba.Location = new System.Drawing.Point(503, 9);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(94, 31);
            this.Prueba.TabIndex = 4;
            this.Prueba.Text = "MENU";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dep_info,
            this.Dep_contabilidad,
            this.Dep_Recursoshumanos,
            this.menureportes,
            this.iconMenuItem2,
            this.iconMenuItem4,
            this.iconMenuItem3,
            this.menuacercade});
            this.menuStrip3.Location = new System.Drawing.Point(0, 48);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1117, 73);
            this.menuStrip3.TabIndex = 5;
            this.menuStrip3.Text = "menuStrip1";
            // 
            // Dep_info
            // 
            this.Dep_info.AutoSize = false;
            this.Dep_info.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.Dep_info.IconColor = System.Drawing.Color.Black;
            this.Dep_info.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dep_info.IconSize = 50;
            this.Dep_info.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Dep_info.Name = "Dep_info";
            this.Dep_info.Size = new System.Drawing.Size(122, 69);
            this.Dep_info.Text = " Departamento TI";
            this.Dep_info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Dep_info.Click += new System.EventHandler(this.Dep_info_Click);
            // 
            // Dep_contabilidad
            // 
            this.Dep_contabilidad.AutoSize = false;
            this.Dep_contabilidad.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.Dep_contabilidad.IconColor = System.Drawing.Color.Black;
            this.Dep_contabilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dep_contabilidad.IconSize = 50;
            this.Dep_contabilidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Dep_contabilidad.Name = "Dep_contabilidad";
            this.Dep_contabilidad.Size = new System.Drawing.Size(122, 69);
            this.Dep_contabilidad.Text = " ";
            this.Dep_contabilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Dep_Recursoshumanos
            // 
            this.Dep_Recursoshumanos.AutoSize = false;
            this.Dep_Recursoshumanos.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.Dep_Recursoshumanos.IconColor = System.Drawing.Color.Black;
            this.Dep_Recursoshumanos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Dep_Recursoshumanos.IconSize = 50;
            this.Dep_Recursoshumanos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Dep_Recursoshumanos.Name = "Dep_Recursoshumanos";
            this.Dep_Recursoshumanos.Size = new System.Drawing.Size(122, 69);
            this.Dep_Recursoshumanos.Text = " ";
            this.Dep_Recursoshumanos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(122, 69);
            this.menureportes.Text = " ";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.AutoSize = false;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.IconSize = 50;
            this.iconMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem2.Text = " ";
            this.iconMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.AutoSize = false;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem4.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem4.IconSize = 50;
            this.iconMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem4.Text = " ";
            this.iconMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.AutoSize = false;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.IconSize = 50;
            this.iconMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(122, 69);
            this.iconMenuItem3.Text = " ";
            this.iconMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(122, 69);
            this.menuacercade.Text = " ";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 284);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.Label Prueba;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private FontAwesome.Sharp.IconMenuItem Dep_info;
        private FontAwesome.Sharp.IconMenuItem Dep_contabilidad;
        private FontAwesome.Sharp.IconMenuItem Dep_Recursoshumanos;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}