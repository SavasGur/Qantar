namespace Qantar
{
    partial class FmReport
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
            this.btnExc = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.girisRadio = new System.Windows.Forms.RadioButton();
            this.cikisRadio = new System.Windows.Forms.RadioButton();
            this.plateFilter = new System.Windows.Forms.CheckBox();
            this.driverFilter = new System.Windows.Forms.CheckBox();
            this.girisAgirlik = new System.Windows.Forms.CheckBox();
            this.Filtre = new System.Windows.Forms.GroupBox();
            this.tarihFilter = new System.Windows.Forms.CheckBox();
            this.girisagirlkFilterTextbox = new System.Windows.Forms.TextBox();
            this.driverTextbox = new System.Windows.Forms.TextBox();
            this.plateTextbox = new System.Windows.Forms.TextBox();
            this.reportGridview = new System.Windows.Forms.DataGridView();
            this.tarihPicker = new System.Windows.Forms.DateTimePicker();
            this.tarihFiltreBox = new System.Windows.Forms.GroupBox();
            this.tarihgeriButton = new System.Windows.Forms.Button();
            this.tarihsearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tarihPicker2 = new System.Windows.Forms.DateTimePicker();
            this.timerLabel = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.Filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridview)).BeginInit();
            this.tarihFiltreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExc
            // 
            this.btnExc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExc.Image = global::Qantar.Properties.Resources.icons8_microsoft_excel_55__1_;
            this.btnExc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExc.Location = new System.Drawing.Point(899, 241);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(300, 75);
            this.btnExc.TabIndex = 22;
            this.btnExc.Text = "Excel Dosyasına Çevir";
            this.btnExc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExc.UseVisualStyleBackColor = false;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightBlue;
            this.btnHome.Image = global::Qantar.Properties.Resources.icons8_home_55;
            this.btnHome.Location = new System.Drawing.Point(1150, 586);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 75);
            this.btnHome.TabIndex = 21;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // girisRadio
            // 
            this.girisRadio.AutoSize = true;
            this.girisRadio.Location = new System.Drawing.Point(19, 27);
            this.girisRadio.Name = "girisRadio";
            this.girisRadio.Size = new System.Drawing.Size(113, 22);
            this.girisRadio.TabIndex = 23;
            this.girisRadio.TabStop = true;
            this.girisRadio.Text = "GirişTablosu";
            this.girisRadio.UseVisualStyleBackColor = true;
            this.girisRadio.CheckedChanged += new System.EventHandler(this.girisRadio_CheckedChanged);
            // 
            // cikisRadio
            // 
            this.cikisRadio.AutoSize = true;
            this.cikisRadio.Location = new System.Drawing.Point(157, 27);
            this.cikisRadio.Name = "cikisRadio";
            this.cikisRadio.Size = new System.Drawing.Size(115, 22);
            this.cikisRadio.TabIndex = 23;
            this.cikisRadio.TabStop = true;
            this.cikisRadio.Text = "ÇıkışTablosu";
            this.cikisRadio.UseVisualStyleBackColor = true;
            this.cikisRadio.CheckedChanged += new System.EventHandler(this.cikisRadio_CheckedChanged);
            // 
            // plateFilter
            // 
            this.plateFilter.AutoSize = true;
            this.plateFilter.Location = new System.Drawing.Point(19, 60);
            this.plateFilter.Name = "plateFilter";
            this.plateFilter.Size = new System.Drawing.Size(67, 22);
            this.plateFilter.TabIndex = 25;
            this.plateFilter.Text = "Plaka";
            this.plateFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.plateFilter.UseVisualStyleBackColor = true;
            this.plateFilter.CheckedChanged += new System.EventHandler(this.plateFilter_CheckedChanged);
            // 
            // driverFilter
            // 
            this.driverFilter.AutoSize = true;
            this.driverFilter.Location = new System.Drawing.Point(19, 93);
            this.driverFilter.Name = "driverFilter";
            this.driverFilter.Size = new System.Drawing.Size(67, 22);
            this.driverFilter.TabIndex = 26;
            this.driverFilter.Text = "Sofor";
            this.driverFilter.UseVisualStyleBackColor = true;
            this.driverFilter.CheckedChanged += new System.EventHandler(this.driverFilter_CheckedChanged);
            // 
            // girisAgirlik
            // 
            this.girisAgirlik.AutoSize = true;
            this.girisAgirlik.Location = new System.Drawing.Point(19, 123);
            this.girisAgirlik.Name = "girisAgirlik";
            this.girisAgirlik.Size = new System.Drawing.Size(100, 22);
            this.girisAgirlik.TabIndex = 27;
            this.girisAgirlik.Text = "GirisAgirlik";
            this.girisAgirlik.UseVisualStyleBackColor = true;
            this.girisAgirlik.CheckedChanged += new System.EventHandler(this.girisAgirlik_CheckedChanged);
            // 
            // Filtre
            // 
            this.Filtre.Controls.Add(this.tarihFilter);
            this.Filtre.Controls.Add(this.girisagirlkFilterTextbox);
            this.Filtre.Controls.Add(this.driverTextbox);
            this.Filtre.Controls.Add(this.plateTextbox);
            this.Filtre.Controls.Add(this.girisRadio);
            this.Filtre.Controls.Add(this.girisAgirlik);
            this.Filtre.Controls.Add(this.cikisRadio);
            this.Filtre.Controls.Add(this.driverFilter);
            this.Filtre.Controls.Add(this.plateFilter);
            this.Filtre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtre.Location = new System.Drawing.Point(121, 39);
            this.Filtre.Name = "Filtre";
            this.Filtre.Size = new System.Drawing.Size(377, 194);
            this.Filtre.TabIndex = 28;
            this.Filtre.TabStop = false;
            this.Filtre.Text = "Filtre";
            // 
            // tarihFilter
            // 
            this.tarihFilter.AutoSize = true;
            this.tarihFilter.Location = new System.Drawing.Point(19, 153);
            this.tarihFilter.Name = "tarihFilter";
            this.tarihFilter.Size = new System.Drawing.Size(94, 22);
            this.tarihFilter.TabIndex = 30;
            this.tarihFilter.Text = "GirişTarih";
            this.tarihFilter.UseVisualStyleBackColor = true;
            this.tarihFilter.CheckedChanged += new System.EventHandler(this.tarihFilter_CheckedChanged);
            // 
            // girisagirlkFilterTextbox
            // 
            this.girisagirlkFilterTextbox.Location = new System.Drawing.Point(157, 120);
            this.girisagirlkFilterTextbox.Name = "girisagirlkFilterTextbox";
            this.girisagirlkFilterTextbox.Size = new System.Drawing.Size(100, 24);
            this.girisagirlkFilterTextbox.TabIndex = 29;
            this.girisagirlkFilterTextbox.TextChanged += new System.EventHandler(this.girisagirlkFilterTextbox_TextChanged);
            // 
            // driverTextbox
            // 
            this.driverTextbox.Location = new System.Drawing.Point(157, 90);
            this.driverTextbox.Name = "driverTextbox";
            this.driverTextbox.Size = new System.Drawing.Size(100, 24);
            this.driverTextbox.TabIndex = 29;
            this.driverTextbox.TextChanged += new System.EventHandler(this.driverTextbox_TextChanged);
            // 
            // plateTextbox
            // 
            this.plateTextbox.Location = new System.Drawing.Point(157, 60);
            this.plateTextbox.Name = "plateTextbox";
            this.plateTextbox.Size = new System.Drawing.Size(100, 24);
            this.plateTextbox.TabIndex = 29;
            this.plateTextbox.TextChanged += new System.EventHandler(this.plateTextbox_TextChanged);
            // 
            // reportGridview
            // 
            this.reportGridview.AllowUserToAddRows = false;
            this.reportGridview.AllowUserToDeleteRows = false;
            this.reportGridview.BackgroundColor = System.Drawing.Color.White;
            this.reportGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridview.Location = new System.Drawing.Point(118, 242);
            this.reportGridview.Name = "reportGridview";
            this.reportGridview.ReadOnly = true;
            this.reportGridview.RowTemplate.Height = 24;
            this.reportGridview.Size = new System.Drawing.Size(775, 419);
            this.reportGridview.TabIndex = 29;
            // 
            // tarihPicker
            // 
            this.tarihPicker.CustomFormat = "MM-dd-yyyy";
            this.tarihPicker.Location = new System.Drawing.Point(22, 41);
            this.tarihPicker.Name = "tarihPicker";
            this.tarihPicker.Size = new System.Drawing.Size(250, 22);
            this.tarihPicker.TabIndex = 30;
            // 
            // tarihFiltreBox
            // 
            this.tarihFiltreBox.Controls.Add(this.tarihgeriButton);
            this.tarihFiltreBox.Controls.Add(this.tarihsearchButton);
            this.tarihFiltreBox.Controls.Add(this.label2);
            this.tarihFiltreBox.Controls.Add(this.tarihPicker2);
            this.tarihFiltreBox.Controls.Add(this.tarihPicker);
            this.tarihFiltreBox.Location = new System.Drawing.Point(118, 39);
            this.tarihFiltreBox.Name = "tarihFiltreBox";
            this.tarihFiltreBox.Size = new System.Drawing.Size(380, 197);
            this.tarihFiltreBox.TabIndex = 31;
            this.tarihFiltreBox.TabStop = false;
            this.tarihFiltreBox.Text = "Tarih Aralığı";
            // 
            // tarihgeriButton
            // 
            this.tarihgeriButton.Location = new System.Drawing.Point(124, 152);
            this.tarihgeriButton.Name = "tarihgeriButton";
            this.tarihgeriButton.Size = new System.Drawing.Size(102, 23);
            this.tarihgeriButton.TabIndex = 32;
            this.tarihgeriButton.Text = "Geri";
            this.tarihgeriButton.UseVisualStyleBackColor = true;
            this.tarihgeriButton.Click += new System.EventHandler(this.tarihgeriButton_Click);
            // 
            // tarihsearchButton
            // 
            this.tarihsearchButton.Location = new System.Drawing.Point(257, 152);
            this.tarihsearchButton.Name = "tarihsearchButton";
            this.tarihsearchButton.Size = new System.Drawing.Size(102, 23);
            this.tarihsearchButton.TabIndex = 32;
            this.tarihsearchButton.Text = "Ara";
            this.tarihsearchButton.UseVisualStyleBackColor = true;
            this.tarihsearchButton.Click += new System.EventHandler(this.tarihsearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "-";
            // 
            // tarihPicker2
            // 
            this.tarihPicker2.CustomFormat = "MM-dd-yyyy";
            this.tarihPicker2.Location = new System.Drawing.Point(22, 87);
            this.tarihPicker2.Name = "tarihPicker2";
            this.tarihPicker2.Size = new System.Drawing.Size(250, 22);
            this.tarihPicker2.TabIndex = 30;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(1066, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(184, 20);
            this.timerLabel.TabIndex = 32;
            this.timerLabel.Text = "MM/dd/yyyy HH:mm:ss";
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOut.Image = global::Qantar.Properties.Resources.icons8_truck_55__2_;
            this.btnOut.Location = new System.Drawing.Point(12, 242);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(100, 75);
            this.btnOut.TabIndex = 34;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIn.Image = global::Qantar.Properties.Resources.icons8_truck_55__1_;
            this.btnIn.Location = new System.Drawing.Point(12, 161);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 75);
            this.btnIn.TabIndex = 33;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.tarihFiltreBox);
            this.Controls.Add(this.reportGridview);
            this.Controls.Add(this.Filtre);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.btnHome);
            this.Name = "FmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Rapor";
            this.Load += new System.EventHandler(this.FmReport_Load);
            this.Filtre.ResumeLayout(false);
            this.Filtre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridview)).EndInit();
            this.tarihFiltreBox.ResumeLayout(false);
            this.tarihFiltreBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.RadioButton girisRadio;
        private System.Windows.Forms.RadioButton cikisRadio;
        private System.Windows.Forms.CheckBox plateFilter;
        private System.Windows.Forms.CheckBox driverFilter;
        private System.Windows.Forms.CheckBox girisAgirlik;
        private System.Windows.Forms.GroupBox Filtre;
        private System.Windows.Forms.TextBox girisagirlkFilterTextbox;
        private System.Windows.Forms.TextBox driverTextbox;
        private System.Windows.Forms.TextBox plateTextbox;
        private System.Windows.Forms.DataGridView reportGridview;
        private System.Windows.Forms.DateTimePicker tarihPicker;
        private System.Windows.Forms.CheckBox tarihFilter;
        private System.Windows.Forms.GroupBox tarihFiltreBox;
        private System.Windows.Forms.Button tarihsearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tarihPicker2;
        private System.Windows.Forms.Button tarihgeriButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnIn;
    }
}