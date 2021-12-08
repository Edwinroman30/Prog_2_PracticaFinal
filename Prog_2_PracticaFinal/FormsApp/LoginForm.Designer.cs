
namespace FormsApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.llblSignup = new System.Windows.Forms.LinkLabel();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // llblSignup
            // 
            this.llblSignup.AutoSize = true;
            this.llblSignup.Location = new System.Drawing.Point(186, 233);
            this.llblSignup.Name = "llblSignup";
            this.llblSignup.Size = new System.Drawing.Size(88, 15);
            this.llblSignup.TabIndex = 0;
            this.llblSignup.TabStop = true;
            this.llblSignup.Text = "Sign up for free";
            this.llblSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignup_LinkClicked);
            // 
            // tboxUserName
            // 
            this.tboxUserName.Location = new System.Drawing.Point(73, 90);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(293, 23);
            this.tboxUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name:";
            // 
            // tboxPass
            // 
            this.tboxPass.Location = new System.Drawing.Point(73, 148);
            this.tboxPass.Name = "tboxPass";
            this.tboxPass.PasswordChar = '*';
            this.tboxPass.Size = new System.Drawing.Size(293, 23);
            this.tboxPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btnSign
            // 
            this.btnSign.Location = new System.Drawing.Point(163, 194);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(136, 27);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "Sign in";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 296);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxPass);
            this.Controls.Add(this.tboxUserName);
            this.Controls.Add(this.llblSignup);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblSignup;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSign;
    }
}

