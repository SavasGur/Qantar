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
            this.btnReport = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.txtPlate = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Turquoise;
            this.btnHome.Image = global::Qantar.Properties.Resources.icons8_home_55;
            this.btnHome.Location = new System.Drawing.Point(1150, 586);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(100, 75);
            this.btnHome.TabIndex = 18;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
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
            this.Name = "FmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qantar - Giriş";
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
    }
}