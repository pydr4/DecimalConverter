namespace DecToOctBinConverter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvertToBinary = new System.Windows.Forms.Button();
            this.btnConvertToOctal = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Base10 Number";
            // 
            // btnConvertToBinary
            // 
            this.btnConvertToBinary.Location = new System.Drawing.Point(197, 132);
            this.btnConvertToBinary.Name = "btnConvertToBinary";
            this.btnConvertToBinary.Size = new System.Drawing.Size(75, 23);
            this.btnConvertToBinary.TabIndex = 2;
            this.btnConvertToBinary.Text = "Binary";
            this.btnConvertToBinary.UseVisualStyleBackColor = true;
            this.btnConvertToBinary.Click += new System.EventHandler(this.btnConvertToBinary_Click);
            // 
            // btnConvertToOctal
            // 
            this.btnConvertToOctal.Location = new System.Drawing.Point(116, 132);
            this.btnConvertToOctal.Name = "btnConvertToOctal";
            this.btnConvertToOctal.Size = new System.Drawing.Size(75, 23);
            this.btnConvertToOctal.TabIndex = 3;
            this.btnConvertToOctal.Text = "Octal";
            this.btnConvertToOctal.UseVisualStyleBackColor = true;
            this.btnConvertToOctal.Click += new System.EventHandler(this.btnConvertToOctal_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(37, 177);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnConvertToOctal);
            this.Controls.Add(this.btnConvertToBinary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Decimal Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvertToBinary;
        private System.Windows.Forms.Button btnConvertToOctal;
        private System.Windows.Forms.Label labelResult;
    }
}

