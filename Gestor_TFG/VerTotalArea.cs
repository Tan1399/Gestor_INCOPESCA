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
    public partial class VerTotalArea : Form
    {
        public VerTotalArea()
        {
            InitializeComponent();
        }

        private sqlControl baseDeDatos = new sqlControl();
        private sqlControl baseDeDatos1 = new sqlControl();
        private sqlControl baseDeDatos2 = new sqlControl();
        private sqlControl baseDeDatos3 = new sqlControl();
        private sqlControl baseDeDatos4 = new sqlControl();
        private sqlControl baseDeDatos5 = new sqlControl();
        private sqlControl baseDeDatos6 = new sqlControl();
        private sqlControl baseDeDatos7 = new sqlControl();
        private sqlControl baseDeDatos8 = new sqlControl();
        private sqlControl baseDeDatos9 = new sqlControl();
        private sqlControl baseDeDatos10 = new sqlControl();
        private sqlControl baseDeDatos11 = new sqlControl();

        public void volver() {

            OpcionesRegistro op = new OpcionesRegistro();
            op.Show();
        
        
        }

        private void VerTotalArea_Load(object sender, EventArgs e)
        {
            int totalPersonasAsignadas = baseDeDatos.ContarFilasPorColumna6("Persona_Asignada");
            int totaltipo = baseDeDatos1.ContarFilasPorColumna6("Tipo");
            int totalValor = baseDeDatos2.ContarFilasPorColumna6("Valor");
            int totalModelo = baseDeDatos3.ContarFilasPorColumna6("Modelo");
            int totalMarca = baseDeDatos4.ContarFilasPorColumna6("Marca");
            int totalserie = baseDeDatos5.ContarFilasPorColumna6("No_Serie");
            int totalfecha = baseDeDatos6.ContarFilasPorColumna6("Fecha_Agregado");
            int totaltraslado = baseDeDatos7.ContarFilasPorColumna6("Traslado");
            int totalFechaTraslado = baseDeDatos8.ContarFilasPorColumna6("Fecha_Traslado");
            int totalLugarTraslado = baseDeDatos9.ContarFilasPorColumna6("Lugar_Traslado");
            int totalMantenimiento = baseDeDatos10.ContarFilasPorColumna6("Mantenimiento");
            int totalultimomantenimiento = baseDeDatos11.ContarFilasPorColumna6("Ultimo_Mantenimiento");

            label13.Text = $"{totalPersonasAsignadas}";
            label14.Text = $"{totaltipo}";
            label15.Text = $"{totalValor}";
            label16.Text = $"{totalModelo}";
            label17.Text = $"{totalMarca}";
            label18.Text = $"{totalserie}";
            label19.Text = $"{totalfecha}";
            label20.Text = $"{totaltraslado}";
            label21.Text = $"{totalFechaTraslado}";
            label22.Text = $"{totalLugarTraslado}";
            label23.Text = $"{totalMantenimiento}";
            label24.Text = $"{totalultimomantenimiento}";


        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            volver();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
