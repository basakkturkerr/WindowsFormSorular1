namespace WindowsFormsSorular1
{
    partial class Form5
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
            this.btnGenislet = new System.Windows.Forms.Button();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenislet
            // 
            this.btnGenislet.Location = new System.Drawing.Point(69, 128);
            this.btnGenislet.Name = "btnGenislet";
            this.btnGenislet.Size = new System.Drawing.Size(100, 85);
            this.btnGenislet.TabIndex = 0;
            this.btnGenislet.Text = "Genişlet";
            this.btnGenislet.UseVisualStyleBackColor = true;
            this.btnGenislet.Click += new System.EventHandler(this.btnGenislet_Click);
            // 
            // txtBoy
            // 
            this.txtBoy.Location = new System.Drawing.Point(69, 66);
            this.txtBoy.Name = "txtBoy";
            this.txtBoy.Size = new System.Drawing.Size(100, 22);
            this.txtBoy.TabIndex = 1;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoy);
            this.Controls.Add(this.btnGenislet);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenislet;
        private System.Windows.Forms.TextBox txtBoy;
    }
}