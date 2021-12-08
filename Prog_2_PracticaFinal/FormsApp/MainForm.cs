using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class MainForm : Form
    {
        private int __idUser;
        public MainForm(int idUser)
        {
            InitializeComponent();
            this.__idUser = idUser;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text += this.__idUser.ToString();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
