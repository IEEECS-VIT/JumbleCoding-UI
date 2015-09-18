using JumbleCoding.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JumbleCoding
{

    public partial class LoginWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _regNoInputStatus;
        private string _passwordInputStatus;

        public string RegNo { get; set; }
        public string Password { get; set; }

        public string RegNoInputStatus
        {
            get { return _regNoInputStatus; }
            set
            {
                _regNoInputStatus = value;
                NotifyPropertyChanged();
            }
        }
        public string PasswordInputStatus
        {
            get { return _passwordInputStatus; }
            set
            {
                _passwordInputStatus = value;
                NotifyPropertyChanged();
            }
        }

        public LoginWindow()
        {
            this.Height = SystemParameters.PrimaryScreenHeight / 1.5;
            this.Width = SystemParameters.PrimaryScreenWidth / 2;

            InitializeComponent();
            this.DataContext = this;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            bool regVal = false, passVal = false;
            if (ValidateRegNo() == false)
                RegNoInputStatus = "Invalid registration number";
            else
            {
                RegNoInputStatus = "";
                regVal = true;
            }
            var roundInfo = Manager.GetRoundInfo(Password);
            if (roundInfo == null)
                PasswordInputStatus = "Invalid password";
            else
            {
                passVal = true;
                PasswordInputStatus = "";
            }

            if (regVal != true || passVal != true)
                return;

            Player player = new Player(RegNo.ToUpper());
            GameSession.Initialize(player, roundInfo);
            Manager.PushToLog(LogEvents.Login, player.RegNo);
            (new MainWindow()).Show();
            this.Close();
        }

        public bool ValidateRegNo()
        {
            if (RegNo.Length != 9)
                return false;

            string course = RegNo.Substring(2, 3);
            foreach (char c in course)
                if (!char.IsLetter(c))
                    return false;

            string nums = RegNo.Substring(0, 2) + RegNo.Substring(5, 4);
            int temp;
            if (int.TryParse(nums, out temp) == false)
                return false;

            return true;
        }

        public void NotifyPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
