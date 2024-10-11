using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_TFG
{
    public partial class VerPromocion : Form
    {
        public VerPromocion()
        {
            InitializeComponent();
        }

        public void volver()
        {

            OpcionesPromoción op = new OpcionesPromoción();
            op.Show();


        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobusqueda.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {

                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;

                }

            }


        }

    

    private void btnvolver_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }

        private void VerPromocion_Load(object sender, EventArgs e)
        {
            List<agregar> agregars = new CN_Agregar().ListarPromoción();



            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cbobusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Text = columna.HeaderText });
                }

            }
            cbobusqueda.DisplayMember = "Text";
            cbobusqueda.ValueMember = "Valor";
            cbobusqueda.SelectedIndex = 0;


            foreach (agregar item in agregars)
            {

                dgvdata.Rows.Add(new object[] { item.Iduser, item.Username, item.Type, item.Value, item.model, item.brand, item.No_Serie, item.Agregate_Date, item.Transfer == true ? "si" : "no", item.Trasfer_Date, item.Transfer_Place, item.Realice_Maintence == true ? "si" : "no", item.last_maintence });



            }
        }
    }
}
