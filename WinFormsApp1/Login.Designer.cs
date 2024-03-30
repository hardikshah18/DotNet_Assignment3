namespace WinFormsApp1
{
    partial class Login
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
            lblUser = new Label();
            lblPass = new Label();
            txtBoxUser = new TextBox();
            txtBoxPass = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(116, 99);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(82, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "Username :";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(121, 161);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(77, 20);
            lblPass.TabIndex = 1;
            lblPass.Text = "Password :";
            // 
            // txtBoxUser
            // 
            txtBoxUser.Location = new Point(243, 92);
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(125, 27);
            txtBoxUser.TabIndex = 2;
            // 
            // txtBoxPass
            // 
            txtBoxPass.Location = new Point(243, 154);
            txtBoxPass.Name = "txtBoxPass";
            txtBoxPass.Size = new Size(125, 27);
            txtBoxPass.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(185, 228);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 421);
            Controls.Add(btnLogin);
            Controls.Add(txtBoxPass);
            Controls.Add(txtBoxUser);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblPass;
        private TextBox txtBoxUser;
        private TextBox txtBoxPass;
        private Button btnLogin;
    }
}
