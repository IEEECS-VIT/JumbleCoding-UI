namespace JumbleCoding
{
    partial class LogInForm
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
            this.InputHeaderLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InputText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ErrorMsgLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputHeaderLabel
            // 
            this.InputHeaderLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputHeaderLabel.Location = new System.Drawing.Point(50, 302);
            this.InputHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InputHeaderLabel.Name = "InputHeaderLabel";
            this.InputHeaderLabel.Size = new System.Drawing.Size(128, 17);
            this.InputHeaderLabel.TabIndex = 0;
            this.InputHeaderLabel.Text = "Registration Number: ";
            this.InputHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(32, 34);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(302, 32);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Welcome to Jumble Coding!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.Location = new System.Drawing.Point(198, 298);
            this.InputText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(122, 24);
            this.InputText.TabIndex = 2;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionText.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionText.Location = new System.Drawing.Point(21, 89);
            this.DescriptionText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionText.ShortcutsEnabled = false;
            this.DescriptionText.Size = new System.Drawing.Size(330, 180);
            this.DescriptionText.TabIndex = 3;
            this.DescriptionText.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(155, 357);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(56, 24);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ErrorMsgLabel
            // 
            this.ErrorMsgLabel.AutoSize = true;
            this.ErrorMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsgLabel.Location = new System.Drawing.Point(196, 323);
            this.ErrorMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErrorMsgLabel.Name = "ErrorMsgLabel";
            this.ErrorMsgLabel.Size = new System.Drawing.Size(28, 13);
            this.ErrorMsgLabel.TabIndex = 5;
            this.ErrorMsgLabel.Text = "error";
            this.ErrorMsgLabel.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 385);
            this.Controls.Add(this.ErrorMsgLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InputHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputHeaderLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label ErrorMsgLabel;
    }
}