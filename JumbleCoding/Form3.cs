using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JumbleCoding
{
    public partial class GameOverDialog : Form
    {
        public GameOverDialog()
        {
            InitializeComponent();

            this.Height = Window.Height / 3;
            this.Width = Window.Width / 3;
            this.FormClosed += GameOverDialog_FormClosed;

            FinalText.Width = (int)(this.Width*0.95);
            FinalText.Height = (int)(this.Height*0.95);
            FinalText.Location = new Point(0, 0);
            // Edit content for the closing statement here.
            FinalText.Lines = new string[] {
                                            "",
                                            "Code successfully submitted.",
                                            "",
                                            "Thank you for taking part! Results will be announced soon."
                                            };
        }

        void GameOverDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
