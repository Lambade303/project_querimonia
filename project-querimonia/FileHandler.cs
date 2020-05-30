using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project_querimonia
{
    public class FileHandler
    {
        string _wd;
        public FileHandler(string absoluteWorkingDir = "%USERPROFILE%\\Documents\\Project-Querimonia\\")
        {
            _wd = absoluteWorkingDir;
            if (!Directory.Exists(_wd)) Directory.CreateDirectory(_wd);
        }

        public static Identity[] parseINIFile(string filepath)
        {
            string[] raw = File.ReadAllLines(filepath);
            List<Identity> returns = new List<Identity>();
            int i = 0;
            while (i < raw.Length)
            {
                string line = raw[i];
                if (line[0] == '[') //BEGIN DATA
                {
                    string id_name = raw[i + 1].Substring(3);
                    string id_str = raw[i + 2].Substring(9).Trim('"');
                    string nick = raw[i + 3].Substring(9);
                    returns.Add(new Identity(id_name, id_str, nick));
                    i += 5;

                }
                else i++;
            }

            return returns.ToArray();
        }

        public Identity[] ReadIdentities()
        {
            string[] raw = File.ReadAllLines(_wd + "ident");
            Identity[] returns = new Identity[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                //returns[i] = new Identity(raw[i]);
            }
            return returns;
        }

        public void WriteIdentities(Identity[] write)
        {
            string[] raw = new string[write.Length];
            for (int i = 0; i < write.Length; i++)
            {
                raw[i] = write[i].IdentityString;
            }

            File.WriteAllLines(_wd + "ident", raw);
        }

        public string[] ReadNicks() => File.ReadAllLines(_wd + "nicks");

        public void WriteNicks(string[] write) => File.WriteAllLines(_wd + "nicks", write);
    }
}
