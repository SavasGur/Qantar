namespace Qantar
{
    partial class FmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAdd));
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.labeldt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelW = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlate
            // 
            this.txtPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlate.Location = new System.Drawing.Point(509, 174);
            this.txtPlate.Name = "txtPlate";
            this.txtPlate.Size = new System.Drawing.Size(268, 38);
            this.txtPlate.TabIndex = 10;
            // 
            // txtDriver
            // 
            this.txtDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDriver.Location = new System.Drawing.Point(509, 255);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(268, 38);
            this.txtDriver.TabIndex = 11;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(509, 336);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(268, 38);
            this.txtWeight.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plaka: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Şoför: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ağırlık: ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(677, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labeldt
            // 
            this.labeldt.AutoSize = true;
            this.labeldt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldt.Location = new System.Drawing.Point(1066, 9);
            this.labeldt.Name = "labeldt";
            this.labeldt.Size = new System.Drawing.Size(184, 20);
            this.labeldt.TabIndex = 19;
            this.labeldt.Text = "MM/dd/yyyy HH:mm:ss";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelW
            // 
            this.labelW.AutoSize = true;
            this.labelW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelW.Location = new System.Drawing.Point(570, 38);
            this.labelW.Name = "labelW";
            this.labelW.Size = new System.Drawing.Size(83, 20);
            this.labelW.TabIndex = 21;
            this.labelW.Text = "- - - - Kg";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(365, 38);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Qantar.Properties.Resources.icons8_usb_connector_26;
            this.pictureBox2.Location = new System.Drawing.Point(328, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCon.Image = global::Qantar.Properties.Resources.icons8_weight_26;
            this.btnCon.Location = new System.Drawing.Point(702, 24);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(50, 50);
            this.btnCon.TabIndex = 20;
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightBlue;
            this.btnHome.Image = global::Qantar.Properties.Resources.icons8_home_55;
            this.btnHome.Location = new System.Drawing.Point(1150, 586);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 75);
            this.btnHome.TabIndex = 18;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.Image = global::Qantar.Properties.Resources.icons8_ratings_55;
            this.btnReport.Location = new System.Drawing.Point(12, 323);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 75);
            this.btnReport.TabIndex = 9;
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
            this.btnOut.TabIndex = 8;
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // FmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelW);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.labeldt);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtDriver);
            this.Controls.Add(this.txtPlate);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Giriş";
            this.Load += new System.EventHandler(this.FmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtPlate;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label labeldt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label labelW;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}