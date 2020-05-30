using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project_querimonia
{
    public class Identity
    {
        string _identStr,
            _id_name,
            _nick;
        ulong _secLvl;
        public Identity(string identStr, ulong secLvl)
        {
            _identStr = identStr;
            _id_name = "GENERIC_PQIDENT";
            _nick = "PQ_TBS";
            _secLvl = secLvl;
        }

        public Identity(string id_name, string identStr, string nick)
        {
            _id_name = id_name;
            _identStr = identStr;
            _nick = nick;
        }

        public string IdentityString { get => _identStr; }
        public string IdentityName { get => _id_name; }
        public string Nick { get => _nick; }
        public ulong SecurityLevel { get => _secLvl; }
    }
}
