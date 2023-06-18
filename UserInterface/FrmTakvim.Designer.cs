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
            this.components = new System.ComponentModel.Container();
            this.BtnOlay = new System.Windows.Forms.GroupBox();
            this.BtnOlayTanımla = new System.Windows.Forms.Button();
            this.MskOlusturma = new System.Windows.Forms.MaskedTextBox();
            this.DtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.DtpOlusturma = new System.Windows.Forms.DateTimePicker();
            this.RchAciklama = new System.Windows.Forms.RichTextBox();
            this.TxtOlay = new System.Windows.Forms.TextBox();
            this.MskBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtgTakvim = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnOlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgTakvim)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOlay
            // 
            this.BtnOlay.Controls.Add(this.BtnOlayTanımla);
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
            // BtnOlayTanımla
            // 
            this.BtnOlayTanımla.Location = new System.Drawing.Point(514, 183);
            this.BtnOlayTanımla.Name = "BtnOlayTanımla";
            this.BtnOlayTanımla.Size = new System.Drawing.Size(189, 49);
            this.BtnOlayTanımla.TabIndex = 11;
            this.BtnOlayTanımla.Text = "Olay Tanımla";
            this.BtnOlayTanımla.UseVisualStyleBackColor = true;
            this.BtnOlayTanımla.Click += new System.EventHandler(this.BtnOlayTanımla_Click);
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
            // DtpBaslangic
            // 
            this.DtpBaslangic.Location = new System.Drawing.Point(494, 105);
            this.DtpBaslangic.Name = "DtpBaslangic";
            this.DtpBaslangic.Size = new System.Drawing.Size(243, 26);
            this.DtpBaslangic.TabIndex = 9;
            this.DtpBaslangic.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // DtpOlusturma
            // 
            this.DtpOlusturma.Location = new System.Drawing.Point(494, 27);
            this.DtpOlusturma.Name = "DtpOlusturma";
            this.DtpOlusturma.Size = new System.Drawing.Size(243, 26);
            this.DtpOlusturma.TabIndex = 8;
            this.DtpOlusturma.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // RchAciklama
            // 
            this.RchAciklama.Location = new System.Drawing.Point(120, 88);
            this.RchAciklama.Name = "RchAciklama";
            this.RchAciklama.Size = new System.Drawing.Size(185, 96);
            this.RchAciklama.TabIndex = 7;
            this.RchAciklama.Text = "";
            // 
            // TxtOlay
            // 
            this.TxtOlay.Location = new System.Drawing.Point(120, 43);
            this.TxtOlay.Name = "TxtOlay";
            this.TxtOlay.Size = new System.Drawing.Size(185, 26);
            this.TxtOlay.TabIndex = 6;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Başlangıç Zamanı:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama:";
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
            // DtgTakvim
            // 
            this.DtgTakvim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgTakvim.Location = new System.Drawing.Point(12, 262);
            this.DtgTakvim.Name = "DtgTakvim";
            this.DtgTakvim.Size = new System.Drawing.Size(779, 213);
            this.DtgTakvim.TabIndex = 2;
            this.DtgTakvim.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgTakvim_CellMouseClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
        private System.Windows.Forms.Button BtnOlayTanımla;
        private System.Windows.Forms.Timer timer1;
    }
}