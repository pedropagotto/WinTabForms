namespace WindowsFormsApp1
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
            this.txtdados = new System.Windows.Forms.TextBox();
            this.form2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdados
            // 
            this.txtdados.Location = new System.Drawing.Point(86, 75);
            this.txtdados.Name = "txtdados";
            this.txtdados.Size = new System.Drawing.Size(100, 20);
            this.txtdados.TabIndex = 0;
            // 
            // form2
            // 
            this.form2.Location = new System.Drawing.Point(51, 182);
            this.form2.Name = "form2";
            this.form2.Size = new System.Drawing.Size(75, 23);
            this.form2.TabIndex = 1;
            this.form2.Text = "form2";
            this.form2.UseVisualStyleBackColor = true;
            this.form2.Click += new System.EventHandler(this.form2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.form2);
            this.Controls.Add(this.txtdados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdados;
        private System.Windows.Forms.Button form2;
    }
}

