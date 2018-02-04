namespace CodingProblems
{
    partial class StringToNumber
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
            this.btnConvertToNumber = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConvertToNumber
            // 
            this.btnConvertToNumber.Location = new System.Drawing.Point(12, 74);
            this.btnConvertToNumber.Name = "btnConvertToNumber";
            this.btnConvertToNumber.Size = new System.Drawing.Size(75, 45);
            this.btnConvertToNumber.TabIndex = 0;
            this.btnConvertToNumber.Text = "Convert To Number";
            this.btnConvertToNumber.UseVisualStyleBackColor = true;
            this.btnConvertToNumber.Click += new System.EventHandler(this.btnConvertToNumber_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 1;
            // 
            // StringToNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConvertToNumber);
            this.Name = "StringToNumber";
            this.Text = "StringToNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertToNumber;
        private System.Windows.Forms.TextBox textBox1;
    }
}