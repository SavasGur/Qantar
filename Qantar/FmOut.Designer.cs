namespace Qantar
{
    partial class FmOut
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
            this.btnExport = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.dgVecIN = new System.Windows.Forms.DataGridView();
            this.plate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtWi = new System.Windows.Forms.TextBox();
            this.txtWo = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Image = global::Qantar.Properties.Resources.icons8_ratings_55;
            this.btnExport.Location = new System.Drawing.Point(12, 323);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 75);
            this.btnExport.TabIndex = 6;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Image = global::Qantar.Properties.Resources.icons8_truck_55__1_;
            this.btnIn.Location = new System.Drawing.Point(12, 161);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 75);
            this.btnIn.TabIndex = 4;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // dgVecIN
            // 
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
            this.dgVecIN.Size = new System.Drawing.Size(760, 500);
            this.dgVecIN.TabIndex = 7;
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
            this.label2.Location = new System.Drawing.Point(288, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "İçerideki Araçlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPlate
            // 
            this.txtPlate.Location = new System.Drawing.Point(1063, 161);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(187, 22);
            this.txtPlate.TabIndex = 9;
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(1063, 205);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(187, 22);
            this.txtDriver.TabIndex = 10;
            // 
            // txtWi
            // 
            this.txtWi.Location = new System.Drawing.Point(1063, 250);
            this.txtWi.Name = "txtWi";
            this.txtWi.Size = new System.Drawing.Size(187, 22);
            this.txtWi.TabIndex = 11;
            // 
            // txtWo
            // 
            this.txtWo.Location = new System.Drawing.Point(1063, 298);
            this.txtWo.Name = "txtWo";
            this.txtWo.Size = new System.Drawing.Size(187, 22);
            this.txtWo.TabIndex = 12;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(1063, 349);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(187, 22);
            this.txtPw.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(978, 157);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plaka: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(980, 201);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Şoför: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(916, 246);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Giriş Ağırlığı: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(912, 294);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Çıkış Ağırlığı: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(914, 345);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(143, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ürün Ağırlığı: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(1150, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Turquoise;
            this.btnHome.Image = global::Qantar.Properties.Resources.icons8_home_55;
            this.btnHome.Location = new System.Drawing.Point(1150, 586);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 75);
            this.btnHome.TabIndex = 20;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FmOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtWo);
            this.Controls.Add(this.txtWi);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgVecIN);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FmOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Çıkış";
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dgVecIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn userS;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtWi;
        private System.Windows.Forms.TextBox txtWo;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
    }
}