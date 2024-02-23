using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Gestor_TFG
{
    public partial class agregarname : Form
    {

        public agregarname()
        {
            InitializeComponent();
        }


        public void clean()
        {
           
            textBox1.Text = "";
            dateTimePicker3.Value = DateTime.Now;
            cbomaintence.SelectedIndex = 0;

         










        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {



            agregar obj = new agregar()
            {

                Username = textBox1.Text,
                last_maintence = dateTimePicker3.Value,
                //Realice_Maintence= cbomaintence.Text


            };

           // int idnombreagregado = new CN_Agregar().agregar(obj);

            /*if (idnombreagregado != 0) {


                dgvdata.Rows.Add(new object[] { textBox1.Text, dateTimePicker3.Value,
            ((OpcionCombo)cbomaintence.SelectedItem).Text.ToString()});



            }*/










            clean();









        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void agregarname_Load(object sender, EventArgs e)
        {


            cbomaintence.Items.Add(new OpcionCombo() { Valor = 1, Text = "si" });
            cbomaintence.Items.Add(new OpcionCombo() { Valor = 0, Text = " No " });
            cbomaintence.DisplayMember = "Text";
            cbomaintence.ValueMember = "Valor";
            cbomaintence.SelectedIndex = 0;

        }

        private void cbomaintence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
