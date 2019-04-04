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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgVec = new System.Windows.Forms.DataGridView();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVec)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVec
            // 
            this.dgVec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plate,
            this.driver,
            this.dateI,
            this.userS,
            this.weight});
            this.dgVec.Location = new System.Drawing.Point(118, 64);
            this.dgVec.Name = "dgVec";
            this.dgVec.RowTemplate.Height = 24;
            this.dgVec.Size = new System.Drawing.Size(543, 590);
            this.dgVec.TabIndex = 5;
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateI.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateI.HeaderText = "Giriş Tarihi";
            this.dateI.Name = "dateI";
            // 
            // userS
            // 
            this.userS.DataPropertyName = "userS";
            this.userS.HeaderText = "Kayıt Eden";
            this.userS.Name = "userS";
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "Ağırlık";
            this.weight.Name = "weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 37);
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
            this.label1.Location = new System.Drawing.Point(667, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "İçeride Bulunan Toplam Araç Sayısı: ";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::Qantar.Properties.Resources.icons8_ratings_55;
            this.btnExport.Location = new System.Drawing.Point(12, 255);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 75);
            this.btnExport.TabIndex = 3;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnOut
            // 
            this.btnOut.Image = global::Qantar.Properties.Resources.icons8_truck_55__2_;
            this.btnOut.Location = new System.Drawing.Point(12, 158);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(100, 75);
            this.btnOut.TabIndex = 2;
            this.btnOut.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Image = global::Qantar.Properties.Resources.icons8_truck_55__1_;
            this.btnIn.Location = new System.Drawing.Point(12, 64);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 75);
            this.btnIn.TabIndex = 1;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Image = global::Qantar.Properties.Resources.icons8_undo_26;
            this.button1.Location = new System.Drawing.Point(1200, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgVec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.button1);
            this.Name = "FmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dgVec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgVec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn userS;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
    }
}