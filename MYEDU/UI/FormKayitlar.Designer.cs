﻿namespace MYEDU.UI
{
    partial class FormKayitlar
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
            this.components = new System.ComponentModel.Container();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.Kimlik = new System.Windows.Forms.Label();
            this.errorProviderKayitler = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtOgrenciKimlik = new System.Windows.Forms.TextBox();
            this.OgrenciKimlik = new System.Windows.Forms.Label();
            this.KursKimlik = new System.Windows.Forms.Label();
            this.txtKursKimlik = new System.Windows.Forms.TextBox();
            this.Tarih = new System.Windows.Forms.Label();
            this.dateKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnKursSec = new System.Windows.Forms.Button();
            this.btnOgrenciSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKayitler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(170, 12);
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.ReadOnly = true;
            this.txtKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtKimlik.TabIndex = 0;
            this.txtKimlik.TabStop = false;
            // 
            // Kimlik
            // 
            this.Kimlik.AutoSize = true;
            this.Kimlik.Location = new System.Drawing.Point(22, 15);
            this.Kimlik.Name = "Kimlik";
            this.Kimlik.Size = new System.Drawing.Size(78, 16);
            this.Kimlik.TabIndex = 33;
            this.Kimlik.Text = "Kıyat Kimliği";
            // 
            // errorProviderKayitler
            // 
            this.errorProviderKayitler.ContainerControl = this;
            // 
            // txtOgrenciKimlik
            // 
            this.txtOgrenciKimlik.Location = new System.Drawing.Point(170, 40);
            this.txtOgrenciKimlik.Name = "txtOgrenciKimlik";
            this.txtOgrenciKimlik.ReadOnly = true;
            this.txtOgrenciKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtOgrenciKimlik.TabIndex = 1;
            this.txtOgrenciKimlik.TabStop = false;
            // 
            // OgrenciKimlik
            // 
            this.OgrenciKimlik.AutoSize = true;
            this.OgrenciKimlik.Location = new System.Drawing.Point(22, 43);
            this.OgrenciKimlik.Name = "OgrenciKimlik";
            this.OgrenciKimlik.Size = new System.Drawing.Size(96, 16);
            this.OgrenciKimlik.TabIndex = 34;
            this.OgrenciKimlik.Text = "Öğrenci Kimliği";
            // 
            // KursKimlik
            // 
            this.KursKimlik.AutoSize = true;
            this.KursKimlik.Location = new System.Drawing.Point(22, 71);
            this.KursKimlik.Name = "KursKimlik";
            this.KursKimlik.Size = new System.Drawing.Size(75, 16);
            this.KursKimlik.TabIndex = 34;
            this.KursKimlik.Text = "Kurs Kimliği";
            // 
            // txtKursKimlik
            // 
            this.txtKursKimlik.Location = new System.Drawing.Point(170, 68);
            this.txtKursKimlik.Name = "txtKursKimlik";
            this.txtKursKimlik.ReadOnly = true;
            this.txtKursKimlik.Size = new System.Drawing.Size(300, 22);
            this.txtKursKimlik.TabIndex = 2;
            this.txtKursKimlik.TabStop = false;
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.Location = new System.Drawing.Point(22, 99);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(73, 16);
            this.Tarih.TabIndex = 31;
            this.Tarih.Text = "Kayıt Tarihi";
            // 
            // dateKayitTarihi
            // 
            this.dateKayitTarihi.Location = new System.Drawing.Point(170, 97);
            this.dateKayitTarihi.Name = "dateKayitTarihi";
            this.dateKayitTarihi.Size = new System.Drawing.Size(300, 22);
            this.dateKayitTarihi.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Image = global::MYEDU.Properties.Resources.button_ok;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.Location = new System.Drawing.Point(404, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 35);
            this.btnOk.TabIndex = 52;
            this.btnOk.Text = "Tamam";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::MYEDU.Properties.Resources.button_cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(515, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "İptal";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnKursSec
            // 
            this.btnKursSec.Image = global::MYEDU.Properties.Resources.book;
            this.btnKursSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKursSec.Location = new System.Drawing.Point(495, 64);
            this.btnKursSec.Name = "btnKursSec";
            this.btnKursSec.Size = new System.Drawing.Size(125, 30);
            this.btnKursSec.TabIndex = 55;
            this.btnKursSec.Text = "Kurs Seç";
            this.btnKursSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKursSec.UseVisualStyleBackColor = true;
            this.btnKursSec.Click += new System.EventHandler(this.btnKursSec_Click);
            // 
            // btnOgrenciSec
            // 
            this.btnOgrenciSec.Image = global::MYEDU.Properties.Resources.database_user;
            this.btnOgrenciSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOgrenciSec.Location = new System.Drawing.Point(495, 36);
            this.btnOgrenciSec.Name = "btnOgrenciSec";
            this.btnOgrenciSec.Size = new System.Drawing.Size(125, 30);
            this.btnOgrenciSec.TabIndex = 54;
            this.btnOgrenciSec.Text = "Oğrenci Seç";
            this.btnOgrenciSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciSec.UseVisualStyleBackColor = true;
            this.btnOgrenciSec.Click += new System.EventHandler(this.btnOgrenciSec_Click);
            // 
            // FormKayitlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 303);
            this.Controls.Add(this.btnKursSec);
            this.Controls.Add(this.btnOgrenciSec);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dateKayitTarihi);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.txtKimlik);
            this.Controls.Add(this.Kimlik);
            this.Controls.Add(this.txtKursKimlik);
            this.Controls.Add(this.KursKimlik);
            this.Controls.Add(this.txtOgrenciKimlik);
            this.Controls.Add(this.OgrenciKimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormKayitlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kayıtler Formu";
            this.Load += new System.EventHandler(this.FormKayitlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKayitler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label Kimlik;
        private System.Windows.Forms.ErrorProvider errorProviderKayitler;
        private System.Windows.Forms.TextBox txtOgrenciKimlik;
        private System.Windows.Forms.Label OgrenciKimlik;
        private System.Windows.Forms.TextBox txtKursKimlik;
        private System.Windows.Forms.Label KursKimlik;
        private System.Windows.Forms.DateTimePicker dateKayitTarihi;
        private System.Windows.Forms.Label Tarih;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnKursSec;
        private System.Windows.Forms.Button btnOgrenciSec;
    }
}