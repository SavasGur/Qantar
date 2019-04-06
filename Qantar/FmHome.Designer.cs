namespace Qantar
{
    partial class FmHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgVecIN = new System.Windows.Forms.DataGridView();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labeldt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVecIN
            // 
            this.dgVecIN.AllowUserToAddRows = false;
            this.dgVecIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVecIN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plate,
            this.driver,
            this.dateI,
            this.userS,
            this.weight});
            this.dgVecIN.Location = new System.Drawing.Point(118, 161);
            this.dgVecIN.Name = "dgVecIN";
            this.dgVecIN.RowTemplate.Height = 24;
            this.dgVecIN.Size = new System.Drawing.Size(775, 500);
            this.dgVecIN.TabIndex = 5;
            // 
            // plate
            // 
            this.plate.DataPropertyName = "plate";
            this.plate.HeaderText = "Plaka";
            this.plate.Name = "plate";
            // 
            // driver
            // 
            this.driver.DataPropertyName = "driver";
            this.driver.HeaderText = "Şöför";
            this.driver.Name = "driver";
            // 
            // dateI
            // 
            this.dateI.DataPropertyName = "dateI";
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.dateI.DefaultCellStyle = dataGridViewCellStyle7;
            this.dateI.HeaderText = "Giriş Tarihi";
            this.dateI.Name = "dateI";
            this.dateI.Width = 125;
            // 
            // userS
            // 
            this.userS.DataPropertyName = "userS";
            this.userS.HeaderText = "Kayıt Eden";
            this.userS.Name = "userS";
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weightI";
            this.weight.HeaderText = "Ağırlık";
            this.weight.Name = "weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "İçerideki Araçlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(899, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "İçeride Bulunan Toplam Araç Sayısı: ";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Image = global::Qantar.Properties.Resources.icons8_ratings_55;
            this.btnReport.Location = new System.Drawing.Point(12, 323);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 75);
            this.btnReport.TabIndex = 3;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOut.Image = global::Qantar.Properties.Resources.icons8_truck_55__2_;
            this.btnOut.Location = new System.Drawing.Point(12, 242);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(100, 75);
            this.btnOut.TabIndex = 2;
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
            this.btnIn.TabIndex = 1;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLogout.Image = global::Qantar.Properties.Resources.icons8_shutdown_26;
            this.btnLogout.Location = new System.Drawing.Point(1200, 611);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labeldt
            // 
            this.labeldt.AutoSize = true;
            this.labeldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldt.Location = new System.Drawing.Point(12, 9);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(184, 20);
            this.labeldt.TabIndex = 7;
            this.labeldt.Text = "MM/dd/yyyy HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.labeldt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgVecIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnLogout);
            this.Name = "FmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVecIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn userS;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.Label labeldt;
        private System.Windows.Forms.Timer timer1;
    }
}