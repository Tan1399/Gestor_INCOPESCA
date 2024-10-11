using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
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
           
            int value;
            if (!int.TryParse(textBox3.Text, out value))
            {


                MessageBox.Show("debe agregarse un dato tipo entero");
               return;
                //value = 0; 
            }

            int noSerie;
            if (!int.TryParse(textBox6.Text, out noSerie))
            {
                MessageBox.Show("debe agregarse un dato tipo entero");
                return;
                //noSerie = 0; 
            }

        
            try
            {
                var selectedItem = (OpcionCombo)cbotraslado.SelectedItem;
                string mensaje = string.Empty;
                string fechaComoCadena="";
               
                DateTime fechaEspecial = new DateTime(1900, 1, 1);

              
                if (dateTimePicker1.Visible==false)
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

                    fechaPicker1Valor2= dateTimePicker2.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    // Si no es visible, usar una cadena vacía o una fecha especial
                    // Para usar una cadena vacía:
                    fechaPicker1Valor2 = "";
                    // O, para usar una fecha especial (por ejemplo, "01/01/1900"):

                }





                int idnombreagregado = new CN_Agregar().agregar(objagr, out mensaje);
                if (idnombreagregado != 0)
                {


                    dgvdata.Rows.Add(new object[] { textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,dateTimePicker3.Value,
            ((OpcionCombo)cbotraslado.SelectedItem).Text.ToString(), fechaPicker1Valor,textBox7.Text,((OpcionCombo)cbomaintence.SelectedItem).Text.ToString(), fechaPicker1Valor2});


                    clean();

                }

                else
                {

                    MessageBox.Show(mensaje);


                }



            }
            catch (Exception ex) {

                MessageBox.Show("Ingresar datos que sean válidos");
            
            }






           

           

           
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
