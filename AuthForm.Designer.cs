namespace PR3
{
    partial class AuthForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            loginInput = new TextBox();
            passInput = new TextBox();
            authBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // loginInput
            // 
            loginInput.BackColor = Color.FromArgb(251, 205, 203);
            loginInput.Font = new Font("Times New Roman", 10.2F);
            loginInput.Location = new Point(12, 28);
            loginInput.Name = "loginInput";
            loginInput.Size = new Size(115, 23);
            loginInput.TabIndex = 0;
            // 
            // passInput
            // 
            passInput.BackColor = Color.FromArgb(251, 205, 203);
            passInput.Font = new Font("Times New Roman", 10.2F);
            passInput.Location = new Point(12, 73);
            passInput.Name = "passInput";
            passInput.PasswordChar = '●';
            passInput.Size = new Size(247, 23);
            passInput.TabIndex = 1;
            // 
            // authBtn
            // 
            authBtn.BackColor = Color.FromArgb(2, 27, 178);
            authBtn.Font = new Font("Times New Roman", 10.2F);
            authBtn.ForeColor = Color.White;
            authBtn.Location = new Point(14, 102);
            authBtn.Name = "authBtn";
            authBtn.Size = new Size(245, 35);
            authBtn.TabIndex = 2;
            authBtn.Text = "Войти";
            authBtn.UseVisualStyleBackColor = false;
            authBtn.Click += AuthBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(14, 54);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(133, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(126, 55);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 5;
            pictureBoxLogo.TabStop = false;
            // 
            // AuthForm
            // 
            AcceptButton = authBtn;
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(274, 147);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(authBtn);
            Controls.Add(passInput);
            Controls.Add(loginInput);
            Font = new Font("Times New Roman", 10.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox loginInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button authBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}
