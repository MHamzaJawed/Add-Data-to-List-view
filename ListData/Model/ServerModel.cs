using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASVPN.Model
{
    public class ServerModel
    {
        public string error { get; set; }
        public string message { get; set; }
        public Server[] servers { get; set; }
    }

    public class Server
    {
        public string sid { get; set; }
        public string country { get; set; }
        public string dns { get; set; }
        public string port { get; set; }
        public string psk { get; set; }
        public string pptp { get; set; }
        public string l2tp { get; set; }
        public string tcp { get; set; }
        public string udp { get; set; }
        public string openconnect { get; set; }
        public string ikev2 { get; set; }
        public string sstp { get; set; }
        public string p2p { get; set; }
        public string videostreaming { get; set; }
        public string security { get; set; }
        public string voip { get; set; }
        public string enable { get; set; }
        public string maintmode { get; set; }
        public string iso { get; set; }
        public string free { get; set; }
        public string recent { get; set; }
        public string time { get; set; }
        public string fav { get; set; }
        public int Pingrate { get; set; }
        public string IsFavorite { get; set; }

        public string FavProtocol { get; set; }
    }
}
