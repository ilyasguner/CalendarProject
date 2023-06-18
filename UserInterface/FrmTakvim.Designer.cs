namespace UserInterface
{
    partial class FrmTakvim
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
            this.BtnOlay = new System.Windows.Forms.GroupBox();
            this.DtgTakvim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MskBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.TxtOlay = new System.Windows.Forms.TextBox();
            this.RchAciklama = new System.Windows.Forms.RichTextBox();
            this.DtpOlusturma = new System.Windows.Forms.DateTimePicker();
            this.DtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.MskOlusturma = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnOlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTakvim)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOlay
            // 
            this.BtnOlay.Controls.Add(this.button1);
            this.BtnOlay.Controls.Add(this.MskOlusturma);
            this.BtnOlay.Controls.Add(this.DtpBaslangic);
            this.BtnOlay.Controls.Add(this.DtpOlusturma);
            this.BtnOlay.Controls.Add(this.RchAciklama);
            this.BtnOlay.Controls.Add(this.TxtOlay);
            this.BtnOlay.Controls.Add(this.MskBaslangic);
            this.BtnOlay.Controls.Add(this.label4);
            this.BtnOlay.Controls.Add(this.label3);
            this.BtnOlay.Controls.Add(this.label2);
            this.BtnOlay.Controls.Add(this.label1);
            this.BtnOlay.Location = new System.Drawing.Point(13, 14);
            this.BtnOlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOlay.Name = "BtnOlay";
            this.BtnOlay.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOlay.Size = new System.Drawing.Size(779, 240);
            this.BtnOlay.TabIndex = 1;
            this.BtnOlay.TabStop = false;
            this.BtnOlay.Text = "Olaylar";
            // 
            // DtgTakvim
            // 
            this.DtgTakvim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgTakvim.Location = new System.Drawing.Point(12, 262);
            this.DtgTakvim.Name = "DtgTakvim";
            this.DtgTakvim.Size = new System.Drawing.Size(779, 213);
            this.DtgTakvim.TabIndex = 2;
            this.DtgTakvim.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgTakvim_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanımlama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oluşturma Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Başlangıç Zamanı:";
            // 
            // MskBaslangic
            // 
            this.MskBaslangic.Location = new System.Drawing.Point(494, 137);
            this.MskBaslangic.Mask = "00:00";
            this.MskBaslangic.Name = "MskBaslangic";
            this.MskBaslangic.Size = new System.Drawing.Size(147, 26);
            this.MskBaslangic.TabIndex = 5;
            this.MskBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // TxtOlay
            // 
            this.TxtOlay.Location = new System.Drawing.Point(120, 43);
            this.TxtOlay.Name = "TxtOlay";
            this.TxtOlay.Size = new System.Drawing.Size(185, 26);
            this.TxtOlay.TabIndex = 6;
            // 
            // RchAciklama
            // 
            this.RchAciklama.Location = new System.Drawing.Point(120, 88);
            this.RchAciklama.Name = "RchAciklama";
            this.RchAciklama.Size = new System.Drawing.Size(185, 96);
            this.RchAciklama.TabIndex = 7;
            this.RchAciklama.Text = "";
            // 
            // DtpOlusturma
            // 
            this.DtpOlusturma.Location = new System.Drawing.Point(494, 27);
            this.DtpOlusturma.Name = "DtpOlusturma";
            this.DtpOlusturma.Size = new System.Drawing.Size(243, 26);
            this.DtpOlusturma.TabIndex = 8;
            // 
            // DtpBaslangic
            // 
            this.DtpBaslangic.Location = new System.Drawing.Point(494, 105);
            this.DtpBaslangic.Name = "DtpBaslangic";
            this.DtpBaslangic.Size = new System.Drawing.Size(243, 26);
            this.DtpBaslangic.TabIndex = 9;
            // 
            // MskOlusturma
            // 
            this.MskOlusturma.Location = new System.Drawing.Point(494, 59);
            this.MskOlusturma.Mask = "00:00";
            this.MskOlusturma.Name = "MskOlusturma";
            this.MskOlusturma.Size = new System.Drawing.Size(147, 26);
            this.MskOlusturma.TabIndex = 10;
            this.MskOlusturma.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Olay Tanımla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 487);
            this.Controls.Add(this.DtgTakvim);
            this.Controls.Add(this.BtnOlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTakvim";
            this.ShowIcon = false;
            this.Text = "Olay Ekranı";
            this.Load += new System.EventHandler(this.FrmTakvim_Load);
            this.BtnOlay.ResumeLayout(false);
            this.BtnOlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTakvim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BtnOlay;
        private System.Windows.Forms.DataGridView DtgTakvim;
        private System.Windows.Forms.RichTextBox RchAciklama;
        private System.Windows.Forms.TextBox TxtOlay;
        private System.Windows.Forms.MaskedTextBox MskBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpOlusturma;
        private System.Windows.Forms.MaskedTextBox MskOlusturma;
        private System.Windows.Forms.DateTimePicker DtpBaslangic;
        private System.Windows.Forms.Button button1;
    }
}