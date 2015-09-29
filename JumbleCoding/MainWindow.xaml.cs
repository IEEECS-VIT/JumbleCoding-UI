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
        private string lastText = "";

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

            CommandManager.AddPreviewExecutedHandler(inputTextBox, HandleCommandExecution);
            lastText = inputTextBox.Text;
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

        private void HandleCommandExecution(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Cut || e.Command == ApplicationCommands.Copy || e.Command == ApplicationCommands.Paste)
                e.Handled = true;
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
                Manager.PushToLog(LogEvents.Submit, inputTextBox.Text);
                string submission = GameSession.EndRound(inputTextBox.Text, RemainingTime);
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

        private void inputTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.A) || (e.Key == Key.B) || (e.Key == Key.C) || (e.Key == Key.D) || (e.Key == Key.E) || (e.Key == Key.F) || (e.Key == Key.G) || (e.Key == Key.H) || (e.Key == Key.I) || (e.Key == Key.J) || (e.Key == Key.K) || (e.Key == Key.L) || (e.Key == Key.M) || (e.Key == Key.N) || (e.Key == Key.O) || (e.Key == Key.P) || (e.Key == Key.Q) || (e.Key == Key.R) || (e.Key == Key.S) || (e.Key == Key.T) || (e.Key == Key.U) || (e.Key == Key.V) || (e.Key == Key.W) || (e.Key == Key.X) || (e.Key == Key.Y) || (e.Key == Key.Z))
            {
                bool isCaps = false;
                if ((Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.RightShift)) ^ Keyboard.IsKeyToggled(Key.CapsLock))
                {
                    isCaps = true;
                }
                char x = '\0';
                switch (e.Key)
                {
                    case Key.A: x = 'A'; break;
                    case Key.B: x = 'B'; break;
                    case Key.C: x = 'C'; break;
                    case Key.D: x = 'D'; break;
                    case Key.E: x = 'E'; break;
                    case Key.F: x = 'F'; break;
                    case Key.G: x = 'G'; break;
                    case Key.H: x = 'H'; break;
                    case Key.I: x = 'I'; break;
                    case Key.J: x = 'J'; break;
                    case Key.K: x = 'K'; break;
                    case Key.L: x = 'L'; break;
                    case Key.M: x = 'M'; break;
                    case Key.N: x = 'N'; break;
                    case Key.O: x = 'O'; break;
                    case Key.P: x = 'P'; break;
                    case Key.Q: x = 'Q'; break;
                    case Key.R: x = 'R'; break;
                    case Key.S: x = 'S'; break;
                    case Key.T: x = 'T'; break;
                    case Key.U: x = 'U'; break;
                    case Key.V: x = 'V'; break;
                    case Key.W: x = 'W'; break;
                    case Key.X: x = 'X'; break;
                    case Key.Y: x = 'Y'; break;
                    case Key.Z: x = 'Z'; break;
                }

                char output = GameSession.RoundDetails.Jumble(x);
                if (isCaps == false)
                    output = char.ToLower(output);
                else
                    output = char.ToUpper(output);
                var text = new string(new char[] { output });
                var target = Keyboard.FocusedElement;
                var routedEvent = TextCompositionManager.TextInputEvent;
                target.RaiseEvent(new TextCompositionEventArgs(InputManager.Current.PrimaryKeyboardDevice, new TextComposition(InputManager.Current, target, text)) { RoutedEvent = routedEvent });
                e.Handled = true;
            }
        }

    }
}