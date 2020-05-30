using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS3Client;
using TS3Client.Commands;
using TS3Client.Messages;
using TS3Client.Query;
using TS3Client.Full;

namespace project_querimonia
{
    public class TS3ClientBase
    {
        ConnectionDataFull _conn;
        Ts3FullClient _ts;

        Identity _id;

        public TS3ClientBase(Identity ident)
        {
            _id = ident;
            _ts = new Ts3FullClient(EventDispatchType.AutoThreadPooled);
        }

        public void Connect()
        {
            _conn = new ConnectionDataFull()
            {
                Hostname = "almanalex.de",
                Port = 9987,
                Username = "PQ-TEST",
                Identity = Ts3Crypt.GenerateNewIdentity(15),
            };
            _ts.Connect(_conn);
        }

        public string getConnectedClients()
        {
            string returns = "";
            ClientData[] clients = _ts.ClientList().ToArray();
            int count = clients.Length;
            for (int i = 0; i < count; i++)
            {
                string nick = clients[i].NickName;
                ulong channel_id = clients[i].ChannelId;
                returns += i + ". " + nick + " in Channel with id: " + channel_id + "\n";
            }
            return returns;
        }
    }
}
