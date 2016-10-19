namespace Pixels_in_Window
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
            this.pixelsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pixelsLabel
            // 
            this.pixelsLabel.AutoSize = true;
            this.pixelsLabel.Location = new System.Drawing.Point(13, 13);
            this.pixelsLabel.Name = "pixelsLabel";
            this.pixelsLabel.Size = new System.Drawing.Size(96, 13);
            this.pixelsLabel.TabIndex = 0;
            this.pixelsLabel.Text = "Pixels in Window =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 142);
            this.Controls.Add(this.pixelsLabel);
            this.Name = "Form1";
            this.Text = "Pixel Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pixelsLabel;
    }
}

