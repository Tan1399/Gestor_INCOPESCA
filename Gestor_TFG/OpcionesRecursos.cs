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
    public partial class OpcionesRecursos : Form
    {
        public OpcionesRecursos()
        {
            InitializeComponent();
        }

        public void Menu()
        {

            Menu men = new Menu();
            men.Show();
        }
        public void agregarRecursos()
        {

            AgregarRecursos agr = new AgregarRecursos();
            agr.Show();


        }

        public void verRecursos()
        {


            VerRecursos ver = new VerRecursos();
            ver.Show();

        }

        public void editarRecursos()
        {

            EditarRecursos edi = new EditarRecursos();

            edi.Show();


        }

        public void borrarRecursos()
        {

            BorrarActivoRecursos borr = new BorrarActivoRecursos();

            borr.Show();



        }

        public void vertotal()
        {

            VerTotalDepartamentoRecursos vt = new VerTotalDepartamentoRecursos();

            vt.Show();



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            agregarRecursos();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            editarRecursos();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            vertotal();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            verRecursos();
            this.Hide();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Menu();
            this.Hide();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            borrarRecursos();
            this.Hide();
        }

        private void OpcionesRecursos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
