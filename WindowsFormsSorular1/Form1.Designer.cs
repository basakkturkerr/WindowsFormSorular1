namespace WindowsFormsSorular1
{
    partial class Form1
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.btnKare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(31, 194);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(150, 22);
            this.txtSayi.TabIndex = 0;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(411, 194);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(150, 22);
            this.txtSonuc.TabIndex = 1;
            // 
            // btnKare
            // 
            this.btnKare.Location = new System.Drawing.Point(261, 156);
            this.btnKare.Name = "btnKare";
            this.btnKare.Size = new System.Drawing.Size(75, 98);
            this.btnKare.TabIndex = 2;
            this.btnKare.Text = "Karesini al";
            this.btnKare.UseVisualStyleBackColor = true;
            this.btnKare.Click += new System.EventHandler(this.btnKare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKare);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button btnKare;
    }
}

