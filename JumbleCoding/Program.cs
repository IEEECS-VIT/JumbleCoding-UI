using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;

namespace JumbleCoding
{
    // Static class to automatically detect monitor's resolution and set to height and width fields.
    static class Window
    {
        public static readonly int Height;
        public static readonly int Width;
        static Window()
        {
            Height = SystemInformation.PrimaryMonitorSize.Height;
            Width = SystemInformation.PrimaryMonitorSize.Width;
        }
    }

    // Class to monitor and respond to game progressions
    static class Manager
    {
        static LogInForm logInForm = new LogInForm();
        static JumbleCodingUI jumbleCodingUI;
        static GameOverDialog gameOverDialog;

        public static string regNo
        {
            private set;
            get;
        }
        private static string submittedCode;

        public static void LoadLogInPage()
        {
            Application.Run(logInForm);
        }

        // Method to disable login screen and show UI.
        public static void LoadUserInterface(string reg)
        {
            regNo = reg;
            logInForm.Hide();
            logInForm.Enabled = false;

            jumbleCodingUI = new JumbleCodingUI();
            jumbleCodingUI.ShowDialog();
        }

        // Method to disable UI,
        // create and write to text file,
        // display GameOver dialogue Box.
        public static void CodeSubmitted(string finalCode)
        {
            jumbleCodingUI.Enabled = false;
            submittedCode = finalCode;

            string filePath = @"C:\Windows\Temp\" + regNo + ".txt";
            StreamWriter sw = new StreamWriter(filePath);
            sw.Write(submittedCode);
            sw.Close();
            // Prevent manipulation (to some extent) by making file readonly.
            File.SetAttributes(filePath, FileAttributes.ReadOnly);

            gameOverDialog = new GameOverDialog();
            gameOverDialog.Show();
        }

    }

    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the game and let Manager handle future events.
            Manager.LoadLogInPage();
        }
    }
}
