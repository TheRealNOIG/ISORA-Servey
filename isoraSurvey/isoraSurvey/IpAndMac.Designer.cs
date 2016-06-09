namespace isoraSurvey
{
    partial class IpAndMac
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
            this.IpLabel = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.IpText = new System.Windows.Forms.TextBox();
            this.MacText = new System.Windows.Forms.TextBox();
            this.MacLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Location = new System.Drawing.Point(12, 15);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(17, 13);
            this.IpLabel.TabIndex = 0;
            this.IpLabel.Text = "IP";
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(15, 64);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(138, 23);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // IpText
            // 
            this.IpText.Location = new System.Drawing.Point(53, 12);
            this.IpText.Name = "IpText";
            this.IpText.Size = new System.Drawing.Size(100, 20);
            this.IpText.TabIndex = 2;
            // 
            // MacText
            // 
            this.MacText.Location = new System.Drawing.Point(53, 38);
            this.MacText.Name = "MacText";
            this.MacText.Size = new System.Drawing.Size(100, 20);
            this.MacText.TabIndex = 4;
            // 
            // MacLabel
            // 
            this.MacLabel.AutoSize = true;
            this.MacLabel.Location = new System.Drawing.Point(12, 41);
            this.MacLabel.Name = "MacLabel";
            this.MacLabel.Size = new System.Drawing.Size(28, 13);
            this.MacLabel.TabIndex = 3;
            this.MacLabel.Text = "Mac";
            // 
            // IpAndMac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 92);
            this.Controls.Add(this.MacText);
            this.Controls.Add(this.MacLabel);
            this.Controls.Add(this.IpText);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.IpLabel);
            this.Name = "IpAndMac";
            this.Text = "IpAndMac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.TextBox IpText;
        private System.Windows.Forms.TextBox MacText;
        private System.Windows.Forms.Label MacLabel;
    }
}