using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_querimonia
{
    public partial class GUI : Form
    {
        Control _ctrl;
        public GUI()
        {
            InitializeComponent();
            _ctrl = new Control(this);
        }
    }
}
