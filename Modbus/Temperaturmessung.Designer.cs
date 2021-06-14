namespace Modbus
{
    partial class Temperaturmessung
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.btnMessung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(136, 51);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(86, 32);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Verbinden";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(410, 51);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(100, 22);
            this.tbTemp.TabIndex = 1;
            // 
            // btnMessung
            // 
            this.btnMessung.Location = new System.Drawing.Point(241, 51);
            this.btnMessung.Name = "btnMessung";
            this.btnMessung.Size = new System.Drawing.Size(95, 32);
            this.btnMessung.TabIndex = 2;
            this.btnMessung.Text = "Messen";
            this.btnMessung.UseVisualStyleBackColor = true;
            this.btnMessung.Click += new System.EventHandler(this.btnMessung_Click);
            // 
            // Temperaturmessung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMessung);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.btnConnection);
            this.Name = "Temperaturmessung";
            this.Text = "Temperaturmessung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Button btnMessung;
    }
}