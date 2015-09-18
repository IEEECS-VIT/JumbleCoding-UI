using JumbleCoding.Managers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace JumbleCoding
{

    public partial class MainWindow : Window
    {
        private DispatcherTimer Timer { get; set; }
        private TimeSpan RemainingTime { get; set; }
        private double _increment;

        public string CurrentPlayerId { get; private set; }

        public MainWindow()
        {
            InitializeComponent();

            CurrentPlayerId = GameSession.CurrentPlayer.RegNo;
            Timer = new DispatcherTimer();
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            RemainingTime = GameSession.RoundDetails.TimeLimit;

            _increment = 100 / RemainingTime.TotalSeconds;
            timeDisplayBlock.Text = RemainingTime.ToString();
            Timer.Start();

            this.DataContext = this;
            Manager.PushToLog(LogEvents.GameStart, GameSession.RoundDetails.RoundNo.ToString());
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            RemainingTime = RemainingTime.Subtract(new TimeSpan(0, 0, 1));
            timeDisplayBlock.Text = RemainingTime.ToString();
            DoubleAnimation progressAnimation = new DoubleAnimation(progressBar.Value + _increment, new Duration(new TimeSpan(0, 0, 1)));
            progressBar.BeginAnimation(ProgressBar.ValueProperty, progressAnimation);

            if (RemainingTime.TotalSeconds == 30)
            {
                timeDisplayBlock.Foreground = progressBar.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (RemainingTime == TimeSpan.Zero)
            {
                SubmitButton_Click(null, null);
            }
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (sender == inputScrollViewer)
                displayScrollViewer.ScrollToVerticalOffset(inputScrollViewer.ContentVerticalOffset);
            else if (sender == displayScrollViewer)
                inputScrollViewer.ScrollToVerticalOffset(displayScrollViewer.ContentVerticalOffset);
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            displayTextBox.Text = GameSession.RoundDetails.Jumbler(inputTextBox.Text);
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            Timer.Tick -= Timer_Tick;
            Timer.Stop();
            submitButton.IsEnabled = false;
            inputTextBox.IsEnabled = false;

            if (RemainingTime == TimeSpan.Zero)
                finalStatusBlock.Text = "Time's Up!";
            else
                finalStatusBlock.Text = "Thank you!";
            submissionGrid.Visibility = System.Windows.Visibility.Visible;

            try
            {
                Manager.PushToLog(LogEvents.Submit, displayTextBox.Text);
                string submission = GameSession.EndRound(displayTextBox.Text, RemainingTime);
                // Upload submission via FTP.
                submitStatusBlock.Foreground = new SolidColorBrush(Colors.LightGreen);
                submitStatusBlock.Text = "Submission successful.";
            }
            catch
            {
                submitStatusBlock.Foreground = new SolidColorBrush(Colors.Red);
                submitStatusBlock.Text = "Submission failed.";
            }
            finally
            {
                submissionProgressBar.Visibility = Visibility.Hidden;
            }
        }

    }
}