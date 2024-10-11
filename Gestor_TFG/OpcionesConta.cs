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
    public partial class OpcionesConta : Form
    {
        public OpcionesConta()
        {
            InitializeComponent();
        }

        public void Menu()
        {

            Menu men = new Menu();
            men.Show();
        }
        public void agregarConta()
        {

            AgregarContable agr = new AgregarContable();
            agr.Show();


        }

        public void verConta()
        {


            VerConta ver = new VerConta();
            ver.Show();

        }

        public void editarConta()
        {

            EditarConta edi = new EditarConta();

            edi.Show();


        }

        public void borrarConta()
        {

            BorrarActivoConta borr = new BorrarActivoConta();

            borr.Show();



        }

        public void vertotal()
        {

            VerTotalDepContable vt = new VerTotalDepContable();

            vt.Show();



        }

        private void OpcionesConta_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            /*agregarname agrn = new agregarname();
            agrn.Show();*/
            agregarConta();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {


            this.Hide();
            editarConta();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            vertotal();
            this.Hide();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            verConta();

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            borrarConta();

        }
    }
}
