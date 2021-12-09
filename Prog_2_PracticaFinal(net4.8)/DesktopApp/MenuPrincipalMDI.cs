using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class MenuPrincipalMDI : Form
    {
        public MenuPrincipalMDI()
        {
            InitializeComponent();
        }

        private DateTime _dateSistema;
        private FormAcercaDe acercaDe;

        private void MenuPrincipalMDI_Load(object sender, EventArgs e)
        {
            //Haz esto en el evento Load de tu formulario MDI Para cambiar su Background

            MdiClient oMDI;

            //recorremos todos los controles hijos del formulario
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Intentamos castear el objeto MdiClient
                    oMDI = (MdiClient)ctl;

                    // Cuando sea casteado con éxito, podremos cambiar el color así
                    oMDI.BackColor = Color.FromArgb(21,48,68);
                }
                catch (InvalidCastException exc)
                {
                    // No hacemos nada cuando el control no sea tupo MdiClient
                }

            }

            this._dateSistema = DateTime.UtcNow.Date;
            this.toolStripStatusFechaSistema.Text += this._dateSistema.ToString("d");

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acercaDe == null)
            {
                acercaDe = new FormAcercaDe();
                acercaDe.MdiParent = this;
                acercaDe.FormClosed += new FormClosedEventHandler(CerrarForm); //Delegado
                acercaDe.Show();
            }
            else
            {
                acercaDe.Activate();
            }

        }


        private void CerrarForm(object sender, FormClosedEventArgs e)
        {
            acercaDe = null;
        }

    }
}
