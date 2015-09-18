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
        private DispatcherTimer Timer;
        private TimeSpan RemainingTime;

        public MainWindow()
        {
            InitializeComponent();

            Timer = new DispatcherTimer();
            Timer.Tick += Timer_Tick;
            Timer.Interval = new TimeSpan(0, 0, 1);
            RemainingTime = GameManager.TimeLimit;

            DoubleAnimation progressAnimation = new DoubleAnimation(100, new Duration(RemainingTime));
            timeDisplayBlock.Text = RemainingTime.ToString();

            Timer.Start();
            progressBar.BeginAnimation(ProgressBar.ValueProperty, progressAnimation);
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            RemainingTime = RemainingTime.Subtract(new TimeSpan(0, 0, 1));
            timeDisplayBlock.Text = RemainingTime.ToString();
            if (RemainingTime.TotalSeconds == 30)
            {
                timeDisplayBlock.Foreground = progressBar.Foreground = new SolidColorBrush(Colors.Red);
            }
            if (RemainingTime == TimeSpan.Zero)
            {
                Timer.Tick -= Timer_Tick;
                Timer.Stop();
                submitButton.IsEnabled = false;
                MessageBox.Show("Well, you've timed out! Your code will be now be submitted.", "Time Up!");
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
            displayTextBox.Text = inputTextBox.Text;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            submitButton.IsEnabled = false;
        }

    }
}