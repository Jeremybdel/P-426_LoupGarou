using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Werewolf.Resources;

namespace chat
{
    public class Message
    {
        public string Msg { get; set; }
        public Player Sender { get; set; }

        public Message(string msg, Player sender)
        {
            Msg = msg;
            Sender = sender;
        }
    }
}
