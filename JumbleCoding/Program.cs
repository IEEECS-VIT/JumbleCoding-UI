using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JumbleCoding
{

    public static class Util
    {
        // Method to format timespan as a string.
        public static string FormatToString(TimeSpan T)
        {
            return (T.Hours.ToString() + " : " + T.Minutes.ToString() + " : " + T.Seconds.ToString());
        }
    }

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
        private static string submittedText;

        public static void LoadLogInPage()
        {
            Application.Run(logInForm);
        }

        // Method to disable login screen and show UI.
        public static void LoadUserInterface(string regNumber)
        {
            regNo = regNumber;
            logInForm.Hide();
            logInForm.Enabled = false;
            
            // Start the game with the passed value of TimeSpan (hours, minutes, seconds).
            jumbleCodingUI = new JumbleCodingUI(new TimeSpan(1,0,0));
            jumbleCodingUI.ShowDialog();
        }

        // Method to disable UI,
        // create and write to text file,
        // Upload file to FTP server if FTP credentials exist
        // display GameOver dialogue Box.
        public static void CodeSubmitted(string finalText, TimeSpan timeStarted, TimeSpan timeEnded)
        {
            jumbleCodingUI.Enabled = false;
            submittedText = finalText;

            string status = "";
            // Writing time taken details and code to file.
            string filePath = @"C:\Windows\Temp\" + regNo + ".txt";
            if(File.Exists(filePath))
            {
                File.SetAttributes(filePath, FileAttributes.Normal);
                StreamWriter sw = File.AppendText(filePath);
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine("// " + regNo);
                sw.WriteLine("// Second Submission! ");
                sw.WriteLine("// Time Started: " + Util.FormatToString(timeStarted));
                sw.WriteLine("// Time Completed: " + Util.FormatToString(timeEnded));
                sw.WriteLine("// Total Time taken: " + Util.FormatToString(timeEnded.Subtract(timeStarted)));
                sw.WriteLine();
                sw.Write(submittedText);
                sw.Close();
                status = "Appended to local file";
                // Prevent manipulation (to some extent) by making file readonly.
                File.SetAttributes(filePath, FileAttributes.ReadOnly);
            }
            else
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine("// " + regNo);
                sw.WriteLine("// Time Started: " + Util.FormatToString(timeStarted));
                sw.WriteLine("// Time Completed: " + Util.FormatToString(timeEnded));
                sw.WriteLine("// Total Time taken: " + Util.FormatToString(timeEnded.Subtract(timeStarted)));
                sw.WriteLine();
                sw.Write(submittedText);
                sw.Close();
                status = "Saved to local file";
                // Prevent manipulation (to some extent) by making file readonly.
                File.SetAttributes(filePath, FileAttributes.ReadOnly);
            }

            string FtpUrl = "";
            string FtpFolder = "";
            string FtpUsername = "";
            string FtpPassword = "";
            bool credentials = false;
            
            if (File.Exists("credentials.json"))
            {
                string JsonText = System.IO.File.ReadAllText("credentials.json");
                JObject json = JsonConvert.DeserializeObject<JObject>(JsonText);
                FtpUrl = (string)json["FtpUrl"];
                FtpUsername = (string)json["FtpUsername"];
                FtpPassword = (string)json["FtpPassword"];
                credentials = true;
                
            }
            
            if (credentials)
            {
                String uploadUrl = String.Format("{0}/{1}", FtpUrl, regNo + ".txt");
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(uploadUrl));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.UseBinary = true;
                request.Credentials = new NetworkCredential(FtpUsername, FtpPassword);
                StreamReader sourceStream = new StreamReader(filePath);
                byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                sourceStream.Close();
                request.ContentLength = fileContents.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                status = status + " and " + response.StatusDescription;
                response.Close();
            }

            gameOverDialog = new GameOverDialog(status);
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
