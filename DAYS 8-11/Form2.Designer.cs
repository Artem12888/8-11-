namespace DAYS_8_11
{
    partial class Form2
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
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textrezet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // numLength
            // 
            this.numLength.BackColor = System.Drawing.Color.White;
            this.numLength.ForeColor = System.Drawing.Color.Black;
            this.numLength.Location = new System.Drawing.Point(114, 45);
            this.numLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(90, 20);
            this.numLength.TabIndex = 0;
            // 
            // txtC1
            // 
            this.txtC1.BackColor = System.Drawing.Color.White;
            this.txtC1.ForeColor = System.Drawing.Color.Black;
            this.txtC1.Location = new System.Drawing.Point(113, 81);
            this.txtC1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(91, 20);
            this.txtC1.TabIndex = 1;
            // 
            // txtC2
            // 
            this.txtC2.BackColor = System.Drawing.Color.White;
            this.txtC2.ForeColor = System.Drawing.Color.Black;
            this.txtC2.Location = new System.Drawing.Point(113, 118);
            this.txtC2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(91, 20);
            this.txtC2.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(137, 203);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(76, 26);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Выполнить";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(91, 108);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 5;
            // 
            // textrezet
            // 
            this.textrezet.Location = new System.Drawing.Point(113, 152);
            this.textrezet.Name = "textrezet";
            this.textrezet.Size = new System.Drawing.Size(100, 20);
            this.textrezet.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 487);
            this.Controls.Add(this.textrezet);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.numLength);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox textrezet;
    }
}