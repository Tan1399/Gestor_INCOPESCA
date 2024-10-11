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
    public partial class EditarRecursos : Form
    {
        public EditarRecursos()
        {
            InitializeComponent();
        }


        public void volver()
        {

            OpcionesRecursos op = new OpcionesRecursos();
            op.Show();



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
        private void EditarRecursos_Load(object sender, EventArgs e)
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


            List<agregar> agregars = new CN_Agregar().ListarRecursos();



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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;


                if (indice >= 0)
                {


                    txtindice.Text = indice.ToString();

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


                    txtid.Text = dgvdata.Rows[indice].Cells["ID"].Value.ToString();
                    textBox1.Text = dgvdata.Rows[indice].Cells["Persona_Asignada"].Value.ToString();
                    textBox2.Text = dgvdata.Rows[indice].Cells["TIPO"].Value.ToString();
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

      

        private void btneditar_Click(object sender, EventArgs e)
        {

            int value;
            if (!int.TryParse(textBox3.Text, out value))
            {
                MessageBox.Show("debe agregarse un dato tipo entero");
                return;

                // value = 0;
            }

            int noSerie;
            if (!int.TryParse(textBox6.Text, out noSerie))
            {
                MessageBox.Show("debe agregarse un dato tipo entero");
                return;

                // noSerie = 0;
            }


            try
            {
                var selectedItem = (OpcionCombo)cbotraslado.SelectedItem;
                string mensaje = string.Empty;
                string fechaComoCadena = "";

                DateTime fechaEspecial = new DateTime(1900, 1, 1);


                if (dateTimePicker1.Visible == false)
                {

                    fechaComoCadena = dateTimePicker1.Value.ToString("");

                }



                DateTime? transferDate = null;
                if (dateTimePicker1.Visible)
                {
                    transferDate = dateTimePicker1.Value;
                }
                else
                {




                    transferDate = fechaEspecial;
                }

                var selectedItem2 = (OpcionCombo)cbomaintence.SelectedItem;
                string mensaje2 = string.Empty;
                string fechaComoCadena2 = "";

                DateTime fechaEspecial2 = new DateTime(1900, 1, 1);


                if (dateTimePicker2.Visible == false)
                {

                    fechaComoCadena2 = dateTimePicker2.Value.ToString("");

                }



                DateTime? lastmaintence = null;
                if (dateTimePicker2.Visible)
                {
                    lastmaintence = dateTimePicker2.Value;
                }
                else
                {




                    lastmaintence = fechaEspecial2;
                }





                agregar objagr = new agregar()

                {







                    //agregar los datos y mandarlos a la bd

                    Iduser = Convert.ToInt32(txtid.Text),
                    Username = textBox1.Text,
                    Type = textBox2.Text,
                    Value = value,
                    Realice_Maintence = Convert.ToInt32(((OpcionCombo)cbomaintence.SelectedItem).Valor) == 1 ? true : false,
                    No_Serie = noSerie,
                    Transfer = Convert.ToInt32(((OpcionCombo)cbotraslado.SelectedItem).Valor) == 1 ? true : false,



                    Trasfer_Date = (DateTime)transferDate,




                    Transfer_Place = textBox7.Text,
                    last_maintence = (DateTime)lastmaintence,
                    Agregate_Date = dateTimePicker3.Value,
                    model = textBox4.Text,
                    brand = textBox5.Text










                };

                string fechaPicker1Valor;
                if (dateTimePicker1.Visible)
                {

                    fechaPicker1Valor = dateTimePicker1.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Si no es visible, usar una cadena vacía o una fecha especial
                    // Para usar una cadena vacía:
                    fechaPicker1Valor = "";
                    // O, para usar una fecha especial (por ejemplo, "01/01/1900"):

                }

                string fechaPicker1Valor2;
                if (dateTimePicker2.Visible)
                {

                    fechaPicker1Valor2 = dateTimePicker2.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Si no es visible, usar una cadena vacía o una fecha especial
                    // Para usar una cadena vacía:
                    fechaPicker1Valor2 = "";
                    // O, para usar una fecha especial (por ejemplo, "01/01/1900"):

                }



                if (objagr.Iduser == 0)
                {

                    int idnombreagregado = new CN_Agregar().agregar3(objagr, out mensaje);
                    if (idnombreagregado != 0)
                    {


                        dgvdata.Rows.Add(new object[] { txtid.Text,textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,dateTimePicker3.Value,
            ((OpcionCombo)cbotraslado.SelectedItem).Text.ToString(), fechaPicker1Valor,textBox7.Text,((OpcionCombo)cbomaintence.SelectedItem).Text.ToString(), fechaPicker1Valor2});


                        clean();


                    }

                    else
                    {

                        MessageBox.Show(mensaje);


                    }

                }

                else
                {
                    bool resultado = new CN_Agregar().EditarRecursos(objagr, out mensaje);
                    if (resultado)
                    {

                        DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                        row.Cells["ID"].Value = txtid.Text;
                        row.Cells["Persona_Asignada"].Value = textBox1.Text;
                        row.Cells["TIPO"].Value = textBox2.Text;
                        row.Cells["Valor"].Value = textBox3.Text;
                        row.Cells["MODELO"].Value = textBox4.Text;
                        row.Cells["MARCA"].Value = textBox5.Text;
                        row.Cells["No_DE_SERIE"].Value = textBox6.Text;
                        row.Cells["FECHA_AGREGADO"].Value = dateTimePicker3.Value;
                        row.Cells["TRASLADO"].Value = ((OpcionCombo)cbotraslado.SelectedItem).Text.ToString();
                        row.Cells["FECHA_TRASLADO"].Value = fechaPicker1Valor;
                        row.Cells["LUGAR_TRASLADO"].Value = textBox7.Text;
                        row.Cells["MantenimientoTI"].Value = ((OpcionCombo)cbomaintence.SelectedItem).Text.ToString();
                        row.Cells["ULTIMO_MANTENIMIENTO"].Value = fechaPicker1Valor2;



                        clean();




                    }
                    else
                    {


                        MessageBox.Show(mensaje);

                    }


                }

            }




            catch (Exception ex)
            {

                MessageBox.Show("Ingresar datos que sean válidos");

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
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
            cbomaintence.SelectedIndex = 0;
            cbotraslado.SelectedIndex = 0;



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

        private void iconButton1_Click(object sender, EventArgs e)
        {

            volver();
            this.Hide();
        }

        private void dgvdata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {

                int indice = e.RowIndex;


                if (indice >= 0)
                {


                    txtindice.Text = indice.ToString();

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


                    txtid.Text = dgvdata.Rows[indice].Cells["ID"].Value.ToString();
                    textBox1.Text = dgvdata.Rows[indice].Cells["Persona_Asignada"].Value.ToString();
                    textBox2.Text = dgvdata.Rows[indice].Cells["TIPO"].Value.ToString();
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
