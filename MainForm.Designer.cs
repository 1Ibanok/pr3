﻿using System.Drawing;

namespace PR3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            saveBtn = new Button();
            pictureBoxLogo = new PictureBox();
            clients = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(251, 205, 203);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Font = new Font("Segoe UI", 9F);
            dataGridView1.Location = new Point(10, 11);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(919, 334);
            dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(251, 205, 203);
            comboBox1.Font = new Font("Times New Roman", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "заявки", "клиенты", "расписание", "сотрудники", "тип_услуги", "услуги" });
            comboBox1.Location = new Point(944, 29);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 24);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(944, 11);
            label1.Name = "label1";
            label1.Size = new Size(115, 16);
            label1.TabIndex = 2;
            label1.Text = "Выберите таблицу:";
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(2, 27, 178);
            saveBtn.Font = new Font("Times New Roman", 10.2F);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(944, 57);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(141, 24);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(1091, 59);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(66, 50);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 5;
            pictureBoxLogo.TabStop = false;
            // 
            // clients
            // 
            clients.BackColor = Color.FromArgb(2, 27, 178);
            clients.Font = new Font("Times New Roman", 10.2F);
            clients.ForeColor = Color.White;
            clients.Location = new Point(944, 85);
            clients.Margin = new Padding(3, 2, 3, 2);
            clients.Name = "clients";
            clients.Size = new Size(140, 24);
            clients.TabIndex = 6;
            clients.Text = "Клиенты";
            clients.UseVisualStyleBackColor = false;
            clients.Click += clients_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1172, 354);
            Controls.Add(clients);
            Controls.Add(pictureBoxLogo);
            Controls.Add(saveBtn);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Button clients;
    }
}
