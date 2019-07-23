namespace WindowsFormsSorular1
{
    partial class Form3
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
            this.btnButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnButon
            // 
            this.btnButon.Location = new System.Drawing.Point(37, 12);
            this.btnButon.Name = "btnButon";
            this.btnButon.Size = new System.Drawing.Size(75, 210);
            this.btnButon.TabIndex = 0;
            this.btnButon.Text = "Buton";
            this.btnButon.UseVisualStyleBackColor = true;
            this.btnButon.Click += new System.EventHandler(this.btnButon_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnButon);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButon;
    }
}