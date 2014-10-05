using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JumbleCoding
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            this.Height = (int)(Window.Height * 0.75);
            this.Width = Window.Width / 2;
            this.FormClosed += LogInForm_FormClosed;

            this.TitleLabel.Width = this.Width;
            this.TitleLabel.Location = new Point(0,(int)(this.Height*0.04));

            DescriptionText.Width = (int)(this.Width*0.8);
            DescriptionText.Left = (int)(this.Width*0.1);
            DescriptionText.Height = (int)(this.Height * 0.5);
            DescriptionText.Top = TitleLabel.Bottom + (int)(Window.Height*0.04);
            DescriptionText.BorderStyle = BorderStyle.Fixed3D;
            DescriptionText.TextAlign = HorizontalAlignment.Center;
            // Edit content for the opening description here.
            DescriptionText.Lines = new string[] {
                                                 "Enter your Registration Number and hit Start to begin. Best of luck!",
                                                 "",
                                                 "Warning: The timer will begin as soon as you press start."
                                                 };

            this.InputHeaderLabel.Left = DescriptionText.Left;
            this.InputHeaderLabel.Top = DescriptionText.Bottom + (int)(Window.Height * 0.03);
            this.InputHeaderLabel.Width = DescriptionText.Width / 2;
            this.InputText.Width = (int)(this.InputHeaderLabel.Width*0.75);
            this.InputText.Left = this.InputHeaderLabel.Right;
            this.InputText.Top = this.InputHeaderLabel.Top;

            this.ErrorMsgLabel.Left = this.InputText.Left;
            this.ErrorMsgLabel.Top = this.InputText.Bottom;
            this.ErrorMsgLabel.Text = "Invalid Registration Number";

            this.StartButton.Top = this.InputText.Bottom + (int)(Window.Height * 0.06);
            this.StartButton.Width = (int)(Window.Width * 0.15);
            this.StartButton.Left = (this.Width - this.StartButton.Width)/2;
        }

        void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Method to verify if input Registration number is valid or not.
        private static bool IsValidRegNo(string s)
        {
            if (s.Length != 9)
                return false;
            // Checking first two digits
            if (!char.IsDigit(s[0]) || !char.IsDigit(s[1]))
                return false;
            // Checking stream code
            if (!char.IsLetter(s[2]) || !char.IsLetter(s[3]) || !char.IsLetter(s[4]))
                return false;
            // Checking last four digits
            try
            {
                int.Parse(s.Substring(5, 4));
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (IsValidRegNo(InputText.Text) != true)
                ErrorMsgLabel.Visible = true;
            else
                Manager.LoadUserInterface(this.InputText.Text);
        }
    }
}
