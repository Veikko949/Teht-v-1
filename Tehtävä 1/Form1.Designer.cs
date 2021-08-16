namespace Tehtävä_1
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
            this.Vaihda_button1 = new System.Windows.Forms.Button();
            this.Testi_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Vaihda_button1
            // 
            this.Vaihda_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaihda_button1.Location = new System.Drawing.Point(120, 154);
            this.Vaihda_button1.Name = "Vaihda_button1";
            this.Vaihda_button1.Size = new System.Drawing.Size(107, 69);
            this.Vaihda_button1.TabIndex = 0;
            this.Vaihda_button1.Text = "Muuta teksti";
            this.Vaihda_button1.UseVisualStyleBackColor = true;
            this.Vaihda_button1.Click += new System.EventHandler(this.Vaihda_button1_Click);
            // 
            // Testi_label
            // 
            this.Testi_label.AutoSize = true;
            this.Testi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Testi_label.Location = new System.Drawing.Point(117, 122);
            this.Testi_label.Name = "Testi_label";
            this.Testi_label.Size = new System.Drawing.Size(91, 16);
            this.Testi_label.TabIndex = 1;
            this.Testi_label.Text = "Terve mailma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Testi_label);
            this.Controls.Add(this.Vaihda_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vaihda_button1;
        private System.Windows.Forms.Label Testi_label;
    }
}

