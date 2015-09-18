using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbleCoding
{
    public struct Player
    {
        private string _regNo;

        public string RegNo
        {
            get { return _regNo; }
            private set { _regNo = value; }
        }

        public Player(string regNo)
        {
            _regNo = regNo;
        }
    }
}
