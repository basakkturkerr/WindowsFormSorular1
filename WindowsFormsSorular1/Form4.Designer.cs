namespace WindowsFormsSorular1
{
    partial class Form4
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
            this.btnButon1 = new System.Windows.Forms.Button();
            this.btnButon2 = new System.Windows.Forms.Button();
            this.btnButon3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButon1
            // 
            this.btnButon1.Location = new System.Drawing.Point(38, 24);
            this.btnButon1.Name = "btnButon1";
            this.btnButon1.Size = new System.Drawing.Size(75, 94);
            this.btnButon1.TabIndex = 0;
            this.btnButon1.Text = "Buton1";
            this.btnButon1.UseVisualStyleBackColor = true;
            this.btnButon1.Click += new System.EventHandler(this.btnButon1_Click);
            // 
            // btnButon2
            // 
            this.btnButon2.Location = new System.Drawing.Point(38, 140);
            this.btnButon2.Name = "btnButon2";
            this.btnButon2.Size = new System.Drawing.Size(75, 94);
            this.btnButon2.TabIndex = 1;
            this.btnButon2.Text = "Buton2";
            this.btnButon2.UseVisualStyleBackColor = true;
            this.btnButon2.Click += new System.EventHandler(this.btnButon2_Click);
            // 
            // btnButon3
            // 
            this.btnButon3.Location = new System.Drawing.Point(38, 259);
            this.btnButon3.Name = "btnButon3";
            this.btnButon3.Size = new System.Drawing.Size(75, 94);
            this.btnButon3.TabIndex = 2;
            this.btnButon3.Text = "Buton3";
            this.btnButon3.UseVisualStyleBackColor = true;
            this.btnButon3.Click += new System.EventHandler(this.btnButon3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnButon3);
            this.Controls.Add(this.btnButon2);
            this.Controls.Add(this.btnButon1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButon1;
        private System.Windows.Forms.Button btnButon2;
        private System.Windows.Forms.Button btnButon3;
    }
}