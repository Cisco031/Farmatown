using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using farmatown.Modelos;

namespace farmatown.Vistas
{
    public partial class FrmPrincipal : Form
    {
        Usuario usuario;
        public FrmPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            confirmarPermisos();
        }

        private void confirmarPermisos()
        {
            switch (usuario.TipoUsuario)
            {
                case 2:
                    // btnReportes.Enabled = false;
                    // btnAltaUsuario.Enabled = false;
                    break;
                case 3:
                    // btnAltaUsuario.Enabled = false;
                    break;
            }

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
