using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormsApp.Model;

namespace FormsApp
{
    public partial class RegistrationForm : Form
    {
        LoginForm login;
        CDataAcessLayer acessLayer;
        public RegistrationForm(LoginForm loginForm)
        {
            InitializeComponent();
            login = loginForm;
            acessLayer = new CDataAcessLayer();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //login.Activate();
            login.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            cboxUserRol.DataSource = acessLayer.GetRolUsers();
            cboxUserRol.DisplayMember = "RolName";
            cboxUserRol.ValueMember = "IdRolUser";
            cboxUserRol.SelectedIndex = 2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (CheckValuesBox())
            {
                if (acessLayer.RegisterUser(tboxUsername.Text, tboxPassword.Text, Convert.ToByte(cboxUserRol.SelectedValue)))
                {
                    MessageBox.Show("Usuario Registrado Sactisfactorimente!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(this, "Asegurece de que todos los campos esten correctos.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool CheckValuesBox()
        {
            bool isValid = false;

            if (!string.IsNullOrEmpty(tboxUsername.Text) || !string.IsNullOrWhiteSpace(tboxUsername.Text))
            {
                if(!string.IsNullOrEmpty(tboxUsername.Text) || !string.IsNullOrWhiteSpace(tboxUsername.Text))
                {
                    if (tboxPassword.Text.Equals(tboxConfirPass.Text))
                    {
                        isValid = true;
                    }
                    else
                    {
                        MessageBox.Show(this, "El password de confirmacion no coinside con el password suplido", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Debe de indicar un password valido.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this,"Debe de indicar un userName valido.","Invalid UserName",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return isValid;
        }


    }
}
