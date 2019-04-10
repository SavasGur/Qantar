namespace Qantar
{
    partial class FmDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmDel));
            this.label2 = new System.Windows.Forms.Label();
            this.dgVecIN = new System.Windows.Forms.DataGridView();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHome = new System.Windows.Forms.Button();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "İçerideki Araçlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgVecIN
            // 
            this.dgVecIN.AllowUserToAddRows = false;
            this.dgVecIN.AllowUserToDeleteRows = false;
            this.dgVecIN.BackgroundColor = System.Drawing.Color.White;
            this.dgVecIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVecIN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plate,
            this.driver,
            this.dateI,
            this.userS,
            this.weight});
            this.dgVecIN.Location = new System.Drawing.Point(118, 161);
            this.dgVecIN.Name = "dgVecIN";
            this.dgVecIN.ReadOnly = true;
            this.dgVecIN.RowTemplate.Height = 24;
            this.dgVecIN.Size = new System.Drawing.Size(775, 500);
            this.dgVecIN.TabIndex = 9;
            // 
            // plate
            // 
            this.plate.DataPropertyName = "plate";
            this.plate.HeaderText = "Plaka";
            this.plate.Name = "plate";
            this.plate.ReadOnly = true;
            // 
            // driver
            // 
            this.driver.DataPropertyName = "driver";
            this.driver.HeaderText = "Şöför";
            this.driver.Name = "driver";
            this.driver.ReadOnly = true;
            // 
            // dateI
            // 
            this.dateI.DataPropertyName = "dateI";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.dateI.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateI.HeaderText = "Giriş Tarihi";
            this.dateI.Name = "dateI";
            this.dateI.ReadOnly = true;
            this.dateI.Width = 125;
            // 
            // userS
            // 
            this.userS.DataPropertyName = "userS";
            this.userS.HeaderText = "Kayıt Eden";
            this.userS.Name = "userS";
            this.userS.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weightI";
            this.weight.HeaderText = "Ağırlık";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
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
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(996, 197);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(187, 22);
            this.txtPlate.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(911, 193);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Plaka: ";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Crimson;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(1083, 225);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 50);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "SİL";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1032, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Silinecek Aracın:";
            // 
            // FmDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgVecIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Araç Sil";
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgVecIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn userS;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label3;
    }
}