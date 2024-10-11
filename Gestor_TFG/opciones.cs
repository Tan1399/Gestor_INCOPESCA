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
    public partial class opciones : Form
    {

        public void Menu() {

            Menu men = new Menu();
            men.Show();
        }


        public void verTi() {

            VerTotalTI verti = new VerTotalTI();
            verti.Show();
        
        }
        public void agregarTI() {

            AgregarForm agr = new AgregarForm();
            agr.Show();
        
        
        }

        public void verTI() {


            Ver ver = new Ver();
            ver.Show();
        
        }

        public void editarTI() {

            EditarActivoTI edi = new EditarActivoTI();

            edi.Show();
        
        
        }

        public void borrarTI() { 

        BorrarActivoTi borr = new BorrarActivoTi();

            borr.Show();



        }

        public void vertotal()
        {

          VerTotalTI vt = new VerTotalTI();

            vt.Show();



        }



        public opciones()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*agregarname agrn = new agregarname();
            agrn.Show();*/
            agregarTI();





        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            verTI();



        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            this.Hide();
            editarTI();


        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

            this.Hide();
            borrarTI();

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu();
            this.Hide();

        }

        private void opciones_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            vertotal();
            this.Hide();
        }
    }
}
