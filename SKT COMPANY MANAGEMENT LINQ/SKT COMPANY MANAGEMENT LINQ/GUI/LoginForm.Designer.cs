namespace SKT_COMPANY_MANAGEMENT_LINQ
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exitButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.hidePassBox = new System.Windows.Forms.PictureBox();
            this.showPassBox = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernamLabel = new System.Windows.Forms.Label();
            this.AccountLoginLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Navy;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(590, 346);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(181, 57);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Navy;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerButton.Location = new System.Drawing.Point(320, 342);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(206, 57);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            // 
            // hidePassBox
            // 
            this.hidePassBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidePassBox.BackgroundImage")));
            this.hidePassBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidePassBox.Location = new System.Drawing.Point(494, 238);
            this.hidePassBox.Name = "hidePassBox";
            this.hidePassBox.Size = new System.Drawing.Size(47, 50);
            this.hidePassBox.TabIndex = 17;
            this.hidePassBox.TabStop = false;
            // 
            // showPassBox
            // 
            this.showPassBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPassBox.BackgroundImage")));
            this.showPassBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPassBox.Location = new System.Drawing.Point(494, 238);
            this.showPassBox.Name = "showPassBox";
            this.showPassBox.Size = new System.Drawing.Size(48, 50);
            this.showPassBox.TabIndex = 16;
            this.showPassBox.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Navy;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginButton.Location = new System.Drawing.Point(65, 342);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(205, 57);
            this.loginButton.TabIndex = 15;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(164, 254);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(294, 34);
            this.passwordBox.TabIndex = 14;
            // 
            // usernameBox
            // 
            this.usernameBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(164, 181);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(294, 34);
            this.usernameBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Navy;
            this.passwordLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Azure;
            this.passwordLabel.Location = new System.Drawing.Point(31, 262);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(108, 26);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password:";
            // 
            // usernamLabel
            // 
            this.usernamLabel.AutoSize = true;
            this.usernamLabel.BackColor = System.Drawing.Color.Navy;
            this.usernamLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamLabel.ForeColor = System.Drawing.Color.Azure;
            this.usernamLabel.Location = new System.Drawing.Point(29, 181);
            this.usernamLabel.Name = "usernamLabel";
            this.usernamLabel.Size = new System.Drawing.Size(110, 26);
            this.usernamLabel.TabIndex = 11;
            this.usernamLabel.Text = "Username:";
            // 
            // AccountLoginLabel
            // 
            this.AccountLoginLabel.AutoSize = true;
            this.AccountLoginLabel.BackColor = System.Drawing.Color.Navy;
            this.AccountLoginLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLoginLabel.ForeColor = System.Drawing.Color.White;
            this.AccountLoginLabel.Location = new System.Drawing.Point(230, 34);
            this.AccountLoginLabel.Name = "AccountLoginLabel";
            this.AccountLoginLabel.Size = new System.Drawing.Size(344, 46);
            this.AccountLoginLabel.TabIndex = 10;
            this.AccountLoginLabel.Text = "ACCOUNT LOGIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = global::SKT_COMPANY_MANAGEMENT_LINQ.Properties.Resources.loginImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.hidePassBox);
            this.Controls.Add(this.showPassBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernamLabel);
            this.Controls.Add(this.AccountLoginLabel);
            this.Name = "Form1";
            this.Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)(this.hidePassBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPassBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox hidePassBox;
        private System.Windows.Forms.PictureBox showPassBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernamLabel;
        private System.Windows.Forms.Label AccountLoginLabel;
    }
}

