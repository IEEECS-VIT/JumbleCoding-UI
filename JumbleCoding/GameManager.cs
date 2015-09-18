using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace JumbleCoding
{
    public static class GameManager
    {
        public static TimeSpan TimeLimit { get; private set; }
        public static bool IsGameRunning { get; private set; }
        
        private static Player CurrentPlayer { get; set; }
        private static DateTimeOffset StartTimeStamp { get; set; }
        private static DateTimeOffset EndTimeStamp { get; set; }

        public static void Initialize(TimeSpan timeLimit, Player player)
        {
            if (IsGameRunning == true)
                throw new InvalidOperationException();
            
            IsGameRunning = false;
            CurrentPlayer = player;
            TimeLimit = timeLimit;
        }

        public static void Start()
        {
            IsGameRunning = true;
            StartTimeStamp = DateTimeOffset.Now;
        }

        public static void End(string submission)
        {
            if (IsGameRunning == false)
                throw new InvalidOperationException();

            IsGameRunning = false;
            EndTimeStamp = DateTimeOffset.Now;
        }
    }
}   