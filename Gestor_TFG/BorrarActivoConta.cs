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
    public partial class BorrarActivoConta : Form
    {
        public BorrarActivoConta()
        {
            InitializeComponent();
        }

        public void volver()
        {

            OpcionesConta op = new OpcionesConta();
            op.Show();



        }

        private void cbotraslado_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedItem = (OpcionCombo)cbotraslado.SelectedItem;
            switch (selectedItem.Valor)
            {

                case 1:


                    dateTimePicker1.Visible = true;
                    break;

                case 0
                :

                    dateTimePicker1.Visible = false;


                    break;



            }





        }


        private void cbomaintence_SelectedIndexChanged(object sender, EventArgs e)
        {


            var selectedItem = (OpcionCombo)cbomaintence.SelectedItem;

            switch (selectedItem.Valor)
            {
                case 1:
                    dateTimePicker2.Visible = true;



                    break;


                case 0:
                    dateTimePicker2.Visible = false;


                    break;


            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == "0")
            {

                MessageBox.Show("Primero seleccione el activo que desea borrar");
                return;


            }
            if (Convert.ToInt32(textBox2.Text) != 0)
            {


                if (MessageBox.Show("¿Desea eliminar los datos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {

                    agregar objagre = new agregar()
                    {

                        Iduser = Convert.ToInt32(textBox2.Text)


                    };
                    bool respuesta = new CN_Agregar().EliminarConta(objagre);

                    //  string mostrar_respuesta = respuesta.ToString();

                    if (respuesta)
                    {

                        dgvdata.Rows.RemoveAt(Convert.ToInt32(textBox1.Text));
                        clean();
                        MessageBox.Show("Dato borrado con éxito");

                    }

                    else
                    {

                        //MessageBox.Show("Respuesta : " + mostrar_respuesta);

                        MessageBox.Show("Error no se pudo borrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

            }
        }


        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;


                if (indice >= 0)
                {


                    textBox1.Text = indice.ToString();

                    string valorSeleccionado = dgvdata.Rows[indice].Cells["TRASLADO"].Value?.ToString() ?? string.Empty;

                    string valorSeleccionado2 = dgvdata.Rows[indice].Cells["MantenimientoTI"].Value?.ToString() ?? string.Empty;

                    string fechaTrasladoStr = dgvdata.Rows[indice].Cells["FECHA_TRASLADO"].Value?.ToString();
                    DateTime fechaAgregado;
                    bool conversionExitosa = DateTime.TryParse(fechaTrasladoStr, out fechaAgregado);
                    string fechaAgregadoStr = dgvdata.Rows[indice].Cells["FECHA_AGREGADO"].Value?.ToString();
                    DateTime fechaTraslado;
                    bool conversionExitosa2 = DateTime.TryParse(fechaAgregadoStr, out fechaTraslado);
                    string UltimomantenimientoStr = dgvdata.Rows[indice].Cells["ULTIMO_MANTENIMIENTO"].Value?.ToString();
                    DateTime ultimomantenimiento;
                    bool conversionExitosa3 = DateTime.TryParse(UltimomantenimientoStr, out ultimomantenimiento);


                    textBox2.Text = dgvdata.Rows[indice].Cells["ID"].Value.ToString();
                    textBox9.Text = dgvdata.Rows[indice].Cells["Persona_Asignada"].Value.ToString();
                    textBox8.Text = dgvdata.Rows[indice].Cells["TIPO"].Value.ToString();
                    textBox3.Text = dgvdata.Rows[indice].Cells["Valor"].Value.ToString();
                    textBox4.Text = dgvdata.Rows[indice].Cells["MODELO"].Value.ToString();
                    textBox5.Text = dgvdata.Rows[indice].Cells["MARCA"].Value.ToString();
                    textBox6.Text = dgvdata.Rows[indice].Cells["No_DE_SERIE"].Value.ToString();
                    textBox7.Text = dgvdata.Rows[indice].Cells["LUGAR_TRASLADO"].Value.ToString();
                    if (conversionExitosa)
                    {
                        dateTimePicker1.Value = fechaAgregado;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now;
                    }

                    if (conversionExitosa2)
                    {
                        dateTimePicker3.Value = fechaTraslado;
                    }
                    else
                    {
                        dateTimePicker3.Value = DateTime.Now;
                    }

                    if (conversionExitosa3)
                    {
                        dateTimePicker2.Value = ultimomantenimiento;
                    }
                    else
                    {
                        dateTimePicker2.Value = DateTime.Now;
                    }

                    cbotraslado.SelectedIndex = cbotraslado.FindStringExact(valorSeleccionado);


                    cbomaintence.SelectedIndex = cbomaintence.FindStringExact(valorSeleccionado2);





                }


            }

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
            {


                return;
            }

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;



            }

        }



        public void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            cbomaintence.SelectedIndex = 0;
            cbotraslado.SelectedIndex = 0;



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            volver();
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

        private void BorrarActivoConta_Load(object sender, EventArgs e)
        {
             cbomaintence.Items.Add(new OpcionCombo() { Valor = 1, Text = "Si" });
            cbomaintence.Items.Add(new OpcionCombo() { Valor = 0, Text = "No" });
            cbomaintence.DisplayMember = "Text";
            cbomaintence.ValueMember = "Valor";
            cbomaintence.SelectedIndex = 0;



            cbotraslado.Items.Add(new OpcionCombo() { Valor = 1, Text = "Si" });
            cbotraslado.Items.Add(new OpcionCombo() { Valor = 0, Text = "No" });
            cbotraslado.DisplayMember = "Text";
            cbotraslado.ValueMember = "Valor";
            cbotraslado.SelectedIndex = 0;


            List<agregar> agregars = new CN_Agregar().ListarConta();



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

                dgvdata.Rows.Add(new object[] { "", item.Iduser, item.Username, item.Type, item.Value, item.model, item.brand, item.No_Serie, item.Agregate_Date, item.Transfer == true ? "Si" : "No", item.Trasfer_Date, item.Transfer_Place, item.Realice_Maintence == true ? "si" : "no", item.last_maintence });



            }

        }

        private void dgvdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;


                if (indice >= 0)
                {


                    textBox1.Text = indice.ToString();

                    string valorSeleccionado = dgvdata.Rows[indice].Cells["TRASLADO"].Value?.ToString() ?? string.Empty;

                    string valorSeleccionado2 = dgvdata.Rows[indice].Cells["MantenimientoTI"].Value?.ToString() ?? string.Empty;

                    string fechaTrasladoStr = dgvdata.Rows[indice].Cells["FECHA_TRASLADO"].Value?.ToString();
                    DateTime fechaAgregado;
                    bool conversionExitosa = DateTime.TryParse(fechaTrasladoStr, out fechaAgregado);
                    string fechaAgregadoStr = dgvdata.Rows[indice].Cells["FECHA_AGREGADO"].Value?.ToString();
                    DateTime fechaTraslado;
                    bool conversionExitosa2 = DateTime.TryParse(fechaAgregadoStr, out fechaTraslado);
                    string UltimomantenimientoStr = dgvdata.Rows[indice].Cells["ULTIMO_MANTENIMIENTO"].Value?.ToString();
                    DateTime ultimomantenimiento;
                    bool conversionExitosa3 = DateTime.TryParse(UltimomantenimientoStr, out ultimomantenimiento);


                    textBox2.Text = dgvdata.Rows[indice].Cells["ID"].Value.ToString();
                    textBox9.Text = dgvdata.Rows[indice].Cells["Persona_Asignada"].Value.ToString();
                    textBox8.Text = dgvdata.Rows[indice].Cells["TIPO"].Value.ToString();
                    textBox3.Text = dgvdata.Rows[indice].Cells["Valor"].Value.ToString();
                    textBox4.Text = dgvdata.Rows[indice].Cells["MODELO"].Value.ToString();
                    textBox5.Text = dgvdata.Rows[indice].Cells["MARCA"].Value.ToString();
                    textBox6.Text = dgvdata.Rows[indice].Cells["No_DE_SERIE"].Value.ToString();
                    textBox7.Text = dgvdata.Rows[indice].Cells["LUGAR_TRASLADO"].Value.ToString();
                    if (conversionExitosa)
                    {
                        dateTimePicker1.Value = fechaAgregado;
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now;
                    }

                    if (conversionExitosa2)
                    {
                        dateTimePicker3.Value = fechaTraslado;
                    }
                    else
                    {
                        dateTimePicker3.Value = DateTime.Now;
                    }

                    if (conversionExitosa3)
                    {
                        dateTimePicker2.Value = ultimomantenimiento;
                    }
                    else
                    {
                        dateTimePicker2.Value = DateTime.Now;
                    }

                    cbotraslado.SelectedIndex = cbotraslado.FindStringExact(valorSeleccionado);


                    cbomaintence.SelectedIndex = cbomaintence.FindStringExact(valorSeleccionado2);





                }


            }

        }

        private void dgvdata_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex < 0)
            {


                return;
            }

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;



            }

        }

        private void cbotraslado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedItem = (OpcionCombo)cbotraslado.SelectedItem;
            switch (selectedItem.Valor)
            {

                case 1:


                    dateTimePicker1.Visible = true;
                    break;

                case 0
                :

                    dateTimePicker1.Visible = false;


                    break;



            }

        }

        private void cbomaintence_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedItem = (OpcionCombo)cbomaintence.SelectedItem;

            switch (selectedItem.Valor)
            {
                case 1:
                    dateTimePicker2.Visible = true;



                    break;


                case 0:
                    dateTimePicker2.Visible = false;


                    break;


            }

        }
    }
}
