namespace DAYS_8_11
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
            this.btnCodes = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCodes
            // 
            this.btnCodes.Location = new System.Drawing.Point(42, 93);
            this.btnCodes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCodes.Name = "btnCodes";
            this.btnCodes.Size = new System.Drawing.Size(76, 26);
            this.btnCodes.TabIndex = 13;
            this.btnCodes.Text = "Выполнить";
            this.btnCodes.UseVisualStyleBackColor = true;
            this.btnCodes.Click += new System.EventHandler(this.btnCodes_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(42, 32);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(194, 20);
            this.txtInput.TabIndex = 12;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(42, 68);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(194, 20);
            this.text1.TabIndex = 14;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 202);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btnCodes);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Задание 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCodes;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox text1;
    }
}