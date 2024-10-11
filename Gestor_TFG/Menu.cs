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
    public partial class Menu : Form
    {

        //carga el menu de opciones
        public void opciones() {



            opciones op = new opciones();
            op.Show();
        
        
        
        }

        public void opciones_conta() {
            OpcionesConta op = new OpcionesConta();
            op.Show();
        
        
        }

        public void opcionesRecursos (){
            OpcionesRecursos op = new OpcionesRecursos();
            op.Show();
        
        
        }
        public void opciones_pesquera() {
            OpcionesPesquera op = new OpcionesPesquera();
            op.Show();
        
        }


        public void configuraciones() {

            Configuraciones config = new Configuraciones();

            config.Show();
    ;        
        
        }
        public void opciones_fiscalizacion() {

          OpcionesFiscalizacion op = new OpcionesFiscalizacion();
            op.Show();
        }

        public void opciones_registro() {

            OpcionesRegistro op = new OpcionesRegistro();
            op.Show();
        
        }
        public void opciones_promocion() {

            OpcionesPromoción op = new OpcionesPromoción();
            op.Show();
        
        
        }




        public Menu()
        {
            InitializeComponent();
        }

        private void Dep_info_Click(object sender, EventArgs e)
        {

            this.Hide();
            opciones();

        }

        private void menuacercade_Click(object sender, EventArgs e)
        {

            Application.ExitThread();

        }

        private void Dep_contabilidad_Click(object sender, EventArgs e)
        {
            this.Hide();
            opciones_conta();
        }

        private void Dep_Recursoshumanos_Click(object sender, EventArgs e)
        {
            this.Hide();
            opcionesRecursos();
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            opciones_pesquera();
        }

        private void Prueba_Click(object sender, EventArgs e)
        {

        }

        private void DepPromociónmercado_Click(object sender, EventArgs e)
        {
            this.Hide();
            opciones_promocion();

        }

        private void AreaRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            opciones_registro();
        }

        private void DepartamentoFiscal_Click(object sender, EventArgs e)
        {
            this.Hide();
            opciones_fiscalizacion();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void iconMenuItem2_Click(object sender, EventArgs e)
        {

            this.Hide();
            configuraciones();

        }
    }
}
