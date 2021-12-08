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
    public partial class LoginForm : Form
    {
        CDataAcessLayer acessLayer;
        MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void llblSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            RegistrationForm registrationForm = new RegistrationForm(this);
            this.Hide();
            registrationForm.ShowDialog();
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            acessLayer = new CDataAcessLayer();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            int result = acessLayer.VerifyLogin(tboxUserName.Text, tboxPass.Text);

            if(result != 0)
            {
                this.Hide();
                mainForm = new MainForm(result);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show(this,"Usuario o Contrana incorrecta","Aviso:");
            }

        }
    }
}
