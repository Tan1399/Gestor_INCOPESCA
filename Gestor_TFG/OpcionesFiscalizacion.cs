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
    public partial class OpcionesFiscalizacion : Form
    {
        public OpcionesFiscalizacion()
        {
            InitializeComponent();
        }

        public void fiscalizacion_registro()
        {

            AgregarFiscal ag = new AgregarFiscal();
            ag.Show();

        }

        public void borrar_fiscalizacion()
        {
            BorrarActivoFiscalizacion br = new BorrarActivoFiscalizacion();
            br.Show();

        }
        public void editar_fiscalizacion()
        {
            EditarFiscalizacion ed = new EditarFiscalizacion();
            ed.Show();

        }

        public void ver_fiscalizacion()
        {
            VerFiscal vr = new VerFiscal();
            vr.Show();

        }

        public void volver()
        {
            Menu mn = new Menu();
            mn.Show();


        }
        public void vertotal()
        {

            VerTotalDepFiscal vt = new VerTotalDepFiscal();

            vt.Show();



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            fiscalizacion_registro();
            this.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            editar_fiscalizacion();
            this.Hide();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            borrar_fiscalizacion();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ver_fiscalizacion();
            this.Hide();

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            vertotal();
            this.Hide();
        }
    }
}
