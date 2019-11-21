using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador_BD_JTM
{
    public partial class cambiarNombre : Form
    {
        public delegate void pasar(string dato);
        public event pasar ePasar;

        public cambiarNombre()
        {
            InitializeComponent();
        }

        private void CambiarNombre_Load(object sender, EventArgs e)
        {

        }

        private void BtRenombrar_Click(object sender, EventArgs e)
        {
            ePasar(tbNombreNuevo.Text);
            this.Close();
            
        }
    }
}
