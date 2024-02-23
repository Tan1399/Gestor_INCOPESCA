using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestor_TFG
{
    public partial class AgregarForm : Form
    {
        public AgregarForm()
        {
            InitializeComponent();
        }


        public void volver() {
        
        opciones op = new opciones();
            op.Show();
        
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            volver();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //agregar los datos y mandarlos a la bd
            string mensaje = string.Empty;

            agregar objagr = new agregar()
            {


              


                Username= textBox1.Text,
                Type= textBox2.Text,
                Value= Convert.ToInt32(textBox3.Text),
                Realice_Maintence= Convert.ToInt32(((OpcionCombo)cbomaintence.SelectedItem).Valor)==1? true:false,
                No_Serie= Convert.ToInt32(textBox3.Text),
                Transfer= Convert.ToInt32(((OpcionCombo)cbotraslado.SelectedItem).Valor) == 1 ? true : false,
                Trasfer_Date= dateTimePicker1.Value,
                Transfer_Place= textBox7.Text,
                last_maintence= dateTimePicker2.Value,
                Agregate_Date=dateTimePicker3.Value,
                model=  Convert.ToChar(textBox4.Text),
                brand= textBox5.Text,









            };


            clean();

        }

        private void AgregarForm_Load(object sender, EventArgs e)
        {
          
            // Load yes or no in cbos
            cbomaintence.Items.Add(new OpcionCombo() { Valor = 1, Text = "Si" });
            cbomaintence.Items.Add(new OpcionCombo() { Valor = 0, Text = " No " });
            cbomaintence.DisplayMember = "Text";
            cbomaintence.ValueMember = "Valor";
            cbomaintence.SelectedIndex = 0;


         
            cbotraslado.Items.Add(new OpcionCombo() { Valor = 1, Text = "Si" });
            cbotraslado.Items.Add(new OpcionCombo() { Valor = 0, Text = " No " });
            cbotraslado.DisplayMember = "Text";
            cbotraslado.ValueMember = "Valor";
            cbotraslado.SelectedIndex = 0;








        }
      


        public void clean() {
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
            switch (selectedItem.Valor) {

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
    }
}
