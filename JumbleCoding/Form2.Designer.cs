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
            this.InputHeaderLabel.Location = new System.Drawing.Point(66, 372);
            this.InputHeaderLabel.Name = "InputHeaderLabel";
            this.InputHeaderLabel.Size = new System.Drawing.Size(171, 21);
            this.InputHeaderLabel.TabIndex = 0;
            this.InputHeaderLabel.Text = "Registeration Number: ";
            this.InputHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(43, 42);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(402, 40);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Welcome to Jumble Coding!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.Location = new System.Drawing.Point(264, 367);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(161, 28);
            this.InputText.TabIndex = 2;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionText.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionText.Location = new System.Drawing.Point(28, 110);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionText.ShortcutsEnabled = false;
            this.DescriptionText.Size = new System.Drawing.Size(439, 220);
            this.DescriptionText.TabIndex = 3;
            this.DescriptionText.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(207, 439);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 30);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ErrorMsgLabel
            // 
            this.ErrorMsgLabel.AutoSize = true;
            this.ErrorMsgLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsgLabel.Location = new System.Drawing.Point(261, 398);
            this.ErrorMsgLabel.Name = "ErrorMsgLabel";
            this.ErrorMsgLabel.Size = new System.Drawing.Size(39, 17);
            this.ErrorMsgLabel.TabIndex = 5;
            this.ErrorMsgLabel.Text = "error";
            this.ErrorMsgLabel.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 474);
            this.Controls.Add(this.ErrorMsgLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.InputHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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