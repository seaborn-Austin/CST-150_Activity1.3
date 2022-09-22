namespace CST_150_Activity1._3
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
            this.christmasAnswerBtn = new System.Windows.Forms.Button();
            this.christmasDayLbl = new System.Windows.Forms.Label();
            this.christmasAnswerTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // christmasAnswerBtn
            // 
            this.christmasAnswerBtn.Location = new System.Drawing.Point(117, 128);
            this.christmasAnswerBtn.Name = "christmasAnswerBtn";
            this.christmasAnswerBtn.Size = new System.Drawing.Size(75, 23);
            this.christmasAnswerBtn.TabIndex = 0;
            this.christmasAnswerBtn.Text = "Answer";
            this.christmasAnswerBtn.UseVisualStyleBackColor = true;
            this.christmasAnswerBtn.Click += new System.EventHandler(this.christmasAnswerBtn_Click);
            // 
            // christmasDayLbl
            // 
            this.christmasDayLbl.AutoSize = true;
            this.christmasDayLbl.Location = new System.Drawing.Point(69, 38);
            this.christmasDayLbl.Name = "christmasDayLbl";
            this.christmasDayLbl.Size = new System.Drawing.Size(139, 13);
            this.christmasDayLbl.TabIndex = 1;
            this.christmasDayLbl.Text = "What day is Christmas Day?";
            // 
            // christmasAnswerTxt
            // 
            this.christmasAnswerTxt.Location = new System.Drawing.Point(54, 73);
            this.christmasAnswerTxt.Name = "christmasAnswerTxt";
            this.christmasAnswerTxt.Size = new System.Drawing.Size(214, 20);
            this.christmasAnswerTxt.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 206);
            this.Controls.Add(this.christmasAnswerTxt);
            this.Controls.Add(this.christmasDayLbl);
            this.Controls.Add(this.christmasAnswerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button christmasAnswerBtn;
        private System.Windows.Forms.Label christmasDayLbl;
        private System.Windows.Forms.TextBox christmasAnswerTxt;
    }
}

