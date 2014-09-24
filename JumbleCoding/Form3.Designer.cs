namespace JumbleCoding
{
    partial class GameOverDialog
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
            this.FinalText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FinalText
            // 
            this.FinalText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FinalText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FinalText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FinalText.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalText.Location = new System.Drawing.Point(25, 41);
            this.FinalText.Margin = new System.Windows.Forms.Padding(0);
            this.FinalText.Multiline = true;
            this.FinalText.Name = "FinalText";
            this.FinalText.ReadOnly = true;
            this.FinalText.ShortcutsEnabled = false;
            this.FinalText.Size = new System.Drawing.Size(233, 161);
            this.FinalText.TabIndex = 0;
            this.FinalText.TabStop = false;
            this.FinalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameOverDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.FinalText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOverDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Congratulations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FinalText;

    }
}