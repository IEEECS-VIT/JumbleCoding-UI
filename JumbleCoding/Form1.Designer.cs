namespace JumbleCoding
{
    partial class JumbleCodingUI
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.TimerHeaderLabel = new System.Windows.Forms.Label();
            this.InfoHeaderLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.TimeDisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(12, 67);
            this.InputBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InputBox.Size = new System.Drawing.Size(448, 456);
            this.InputBox.TabIndex = 0;
            this.InputBox.WordWrap = false;
            // 
            // DisplayBox
            // 
            this.DisplayBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DisplayBox.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBox.Location = new System.Drawing.Point(538, 68);
            this.DisplayBox.Multiline = true;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DisplayBox.ShortcutsEnabled = false;
            this.DisplayBox.Size = new System.Drawing.Size(425, 456);
            this.DisplayBox.TabIndex = 1;
            this.DisplayBox.TabStop = false;
            this.DisplayBox.WordWrap = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(843, 637);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(120, 49);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // TimerHeaderLabel
            // 
            this.TimerHeaderLabel.AutoSize = true;
            this.TimerHeaderLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerHeaderLabel.Location = new System.Drawing.Point(42, 662);
            this.TimerHeaderLabel.Name = "TimerHeaderLabel";
            this.TimerHeaderLabel.Size = new System.Drawing.Size(154, 24);
            this.TimerHeaderLabel.TabIndex = 3;
            this.TimerHeaderLabel.Text = "Time Remaining: ";
            this.TimerHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InfoHeaderLabel
            // 
            this.InfoHeaderLabel.AutoSize = true;
            this.InfoHeaderLabel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoHeaderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoHeaderLabel.Location = new System.Drawing.Point(42, 15);
            this.InfoHeaderLabel.Name = "InfoHeaderLabel";
            this.InfoHeaderLabel.Size = new System.Drawing.Size(100, 21);
            this.InfoHeaderLabel.TabIndex = 4;
            this.InfoHeaderLabel.Text = "Logged in as:";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(43, 36);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(102, 24);
            this.InfoLabel.TabIndex = 5;
            this.InfoLabel.Text = "13BEC0749";
            // 
            // TimeDisplayLabel
            // 
            this.TimeDisplayLabel.AutoSize = true;
            this.TimeDisplayLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDisplayLabel.Location = new System.Drawing.Point(202, 662);
            this.TimeDisplayLabel.Name = "TimeDisplayLabel";
            this.TimeDisplayLabel.Size = new System.Drawing.Size(72, 24);
            this.TimeDisplayLabel.TabIndex = 6;
            this.TimeDisplayLabel.Text = "0 : 0 : 0";
            // 
            // JumbleCodingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.TimeDisplayLabel);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.InfoHeaderLabel);
            this.Controls.Add(this.TimerHeaderLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.InputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JumbleCodingUI";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jumble Coding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label TimerHeaderLabel;
        private System.Windows.Forms.Label InfoHeaderLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label TimeDisplayLabel;
    }
}

