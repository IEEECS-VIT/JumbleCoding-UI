using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;


namespace JumbleCoding.Managers
{
    public static class GameSession
    {
        public static RoundInfo RoundDetails { get; private set; }
        public static Player CurrentPlayer { get; private set; }

        public static void Initialize(Player player, RoundInfo roundInfo)
        {
            CurrentPlayer = player;
            RoundDetails = roundInfo;
        }

        public static string EndRound(string code, TimeSpan remainingTime)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("// Player: " + CurrentPlayer.RegNo);
            sb.AppendLine("// Time taken: " + (RoundDetails.TimeLimit - remainingTime).ToString() + "\n");
            sb.AppendLine(code);
            sb.AppendLine("\n/*\n" + Manager.ReadFullLog() + "*/");
            return sb.ToString();
        }
    }
}   