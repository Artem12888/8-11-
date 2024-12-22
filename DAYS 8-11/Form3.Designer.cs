namespace DAYS_8_11
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
            this.btnReverse = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(52, 168);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(76, 26);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "Выполнить";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(52, 94);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(157, 20);
            this.txtInput.TabIndex = 7;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(52, 133);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(157, 20);
            this.text1.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(276, 250);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox text1;
    }
}