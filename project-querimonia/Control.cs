using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace project_querimonia
{
    class Control
    {
        GUI _ui;
        FileHandler _fHdl;
        TS3ClientBase[] _bot;
        public Control(GUI pGui)
        {
            _ui = pGui;
            _fHdl = new FileHandler();
            _bot = new TS3ClientBase[10];

            InitializeTest();
        }

        private void InitializeTest()
        {
            string test_id = "22847668VBMXjaiuiFC7TPhw6idvFTFr/lOFkI3hTXVUvclR7Ak9OfXcABWNYOAZ2MSFyEmJJJFkBcABcVDAkQHkie3BAVlNCH0piFUwAAjJ+KTISDg9kUl9jMFYEMHoHZl1zTBxDHxtgWHhRVGVBaUEwYjNvRGdiTmxLdE43ZWpESHRTbEtkMFc0UkJIdjFFa2Q4RXBpci9wV2NBPT0=";
            Identity test = new Identity(test_id, 26);
            _bot[0] = new TS3ClientBase(test);
            _bot[0].Connect();
            string clients = _bot[0].getConnectedClients();
            MessageBox.Show(clients);
        }
    }
}
