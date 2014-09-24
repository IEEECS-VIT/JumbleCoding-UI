using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JumbleCoding
{
    public partial class JumbleCodingUI : Form
    {

        private Timer countDown = new Timer();
        private TimeSpan TimeRemaining;
        private TimeSpan timeStarted, timeEnded;

        public JumbleCodingUI(TimeSpan maxTime)
        {
            InitializeComponent();
            this.DesktopBounds = new Rectangle(new Point(0, 0), new Size(Window.Width, Window.Height));
            this.Load += JumbleCodingUI_Load;
            this.FormClosed += JumbleCodingUI_FormClosed;

            timeStarted = (DateTime.Now).TimeOfDay;
            this.TimeRemaining = maxTime;

            this.InputBox.Width = (int)(Window.Width * 0.45);
            this.InputBox.Height = (int)(Window.Height * 0.6);
            this.InputBox.Location = new Point((int)(Window.Width * 0.025), (int)(Window.Height * 0.2));
            this.InputBox.TextChanged += InputBox_TextChanged;

            this.DisplayBox.Width = (int)(Window.Width * 0.45);
            this.DisplayBox.Height = (int)(Window.Height * 0.6);
            this.DisplayBox.Location = new Point((int)(Window.Width * 0.505), (int)(Window.Height * 0.2));
            this.DisplayBox.GotFocus += DisplayBox_GotFocus;
            
            this.SubmitButton.Size = new Size((int)(Window.Width * 0.1), (int)(Window.Height * 0.05));
            this.SubmitButton.Top = (int)(Window.Height * 0.85);
            this.SubmitButton.Left = (int)(Window.Width * 0.83);

            this.InfoHeaderLabel.Top = (int)(Window.Width * 0.05);
            this.InfoHeaderLabel.Left = (int)(Window.Width * 0.05);
            
            this.InfoLabel.Top = this.InfoHeaderLabel.Bottom;
            this.InfoLabel.Left = this.InfoHeaderLabel.Left;
            this.InfoLabel.Text = Manager.regNo;

            this.TimerHeaderLabel.Size = new Size((int)(Window.Width * 0.1), (int)(Window.Height * 0.05));
            this.TimerHeaderLabel.Top = (int)(Window.Height * 0.865);
            this.TimerHeaderLabel.Left = (int)(Window.Width * 0.05);

            TimeDisplayLabel.Left = this.TimerHeaderLabel.Right;
            TimeDisplayLabel.Top = this.TimerHeaderLabel.Top;
            TimeDisplayLabel.Text = Util.FormatToString(TimeRemaining);

        }

        // To prevent user from even selecting text in the Display Box.
        void DisplayBox_GotFocus(object sender, EventArgs e)
        {
            this.InputBox.Focus();
        }

        private void JumbleCodingUI_Load(object sender, EventArgs e)
        {
            countDown.Interval = (1000); // 1 second
            countDown.Tick += new EventHandler(countDown_Tick);
            countDown.Start();
        }

        private void countDown_Tick(object sender, EventArgs e)
        {
            TimeRemaining = TimeRemaining.Subtract(new TimeSpan(0, 0, 1));
            this.TimeDisplayLabel.Text = Util.FormatToString(TimeRemaining);
            if (TimeRemaining.CompareTo(new TimeSpan(0)) == 0)
                    SubmitButton.PerformClick();
        }

        void JumbleCodingUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Update DisplayBox by jumbling input
        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            // Replace this line with a function call:
            // DisplayBox.Text = JumbleCodingAlgorithm.GameAlgorithm.Jumble(InputBox.Text);
            DisplayBox.Text = InputBox.Text;
        }
        
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            countDown.Stop();
            timeEnded = (DateTime.Now).TimeOfDay;
            Manager.CodeSubmitted(DisplayBox.Text, timeStarted, timeEnded);
        }

    }
}
