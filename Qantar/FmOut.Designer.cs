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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReport = new System.Windows.Forms.Button();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.labeldt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.labelW = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Image = global::Qantar.Properties.Resources.icons8_ratings_55;
            this.btnReport.Location = new System.Drawing.Point(12, 323);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 75);
            this.btnReport.TabIndex = 6;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnIn.Image = global::Qantar.Properties.Resources.icons8_truck_55__1_;
            this.btnIn.Location = new System.Drawing.Point(12, 161);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(100, 75);
            this.btnIn.TabIndex = 4;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
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
            this.dgVecIN.TabIndex = 7;
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
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.dateI.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateI.HeaderText = "Giriş Tarihi";
            this.dateI.Name = "dateI";
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
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(1150, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightBlue;
            this.btnHome.Image = global::Qantar.Properties.Resources.icons8_home_55;
            this.btnHome.Location = new System.Drawing.Point(1150, 586);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 75);
            this.btnHome.TabIndex = 20;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // labeldt
            // 
            this.labeldt.AutoSize = true;
            this.labeldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldt.Location = new System.Drawing.Point(12, 9);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(184, 20);
            this.labeldt.TabIndex = 21;
            this.labeldt.Text = "MM/dd/yyyy HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(365, 38);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 25;
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Location = new System.Drawing.Point(573, 41);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(64, 17);
            this.labelW.TabIndex = 24;
            this.labelW.Text = "0000000";
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(702, 38);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 23;
            this.btnCon.Text = "Bağlan";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // FmOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.labeldt);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtWo);
            this.Controls.Add(this.txtWi);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgVecIN);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FmOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Çıkış";
            this.Load += new System.EventHandler(this.FmOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVecIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.DataGridView dgVecIN;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate;
        private System.Windows.Forms.DataGridViewTextBoxColumn driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateI;
        private System.Windows.Forms.DataGridViewTextBoxColumn userS;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.Label labeldt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Label labelW;
        private System.Windows.Forms.Button btnCon;
        private System.IO.Ports.SerialPort serialPort1;
    }
}