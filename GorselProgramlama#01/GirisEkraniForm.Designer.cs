﻿namespace GorselProgramlama_01
{
    partial class GirisEkraniForm
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
            UyeEkleBtn = new Button();
            EmanetEkleBtn = new Button();
            KitapEkleBtn = new Button();
            SuspendLayout();
            // 
            // UyeEkleBtn
            // 
            UyeEkleBtn.Location = new Point(51, 65);
            UyeEkleBtn.Name = "UyeEkleBtn";
            UyeEkleBtn.Size = new Size(136, 51);
            UyeEkleBtn.TabIndex = 1;
            UyeEkleBtn.Text = "Uye Ekle";
            UyeEkleBtn.UseVisualStyleBackColor = true;
            UyeEkleBtn.Click += UyeEkle_Click;
            // 
            // EmanetEkleBtn
            // 
            EmanetEkleBtn.Location = new Point(51, 327);
            EmanetEkleBtn.Name = "EmanetEkleBtn";
            EmanetEkleBtn.Size = new Size(136, 51);
            EmanetEkleBtn.TabIndex = 2;
            EmanetEkleBtn.Text = "Emanet Islemleri";
            EmanetEkleBtn.UseVisualStyleBackColor = true;
            EmanetEkleBtn.Click += EmanetEkleBtn_Click;
            // 
            // KitapEkleBtn
            // 
            KitapEkleBtn.Location = new Point(51, 195);
            KitapEkleBtn.Name = "KitapEkleBtn";
            KitapEkleBtn.Size = new Size(136, 51);
            KitapEkleBtn.TabIndex = 3;
            KitapEkleBtn.Text = "Kitap Ekle";
            KitapEkleBtn.UseVisualStyleBackColor = true;
            KitapEkleBtn.Click += KitapEkleBtn_Click;
            // 
            // GirisEkraniForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KitapEkleBtn);
            Controls.Add(EmanetEkleBtn);
            Controls.Add(UyeEkleBtn);
            Name = "GirisEkraniForm";
            Text = "GirisEkraniForm";
            ResumeLayout(false);
        }

        #endregion
        private Button UyeEkleBtn;
        private Button EmanetEkleBtn;
        private Button KitapEkleBtn;
    }
}