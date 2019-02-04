using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angel
{
    public partial class fReferences : Form
    {
        public fReferences()
        {
            InitializeComponent();
        }

        private void fReferences_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHell.sActivityType' table. You can move, or remove it, as needed.
            this.sActivityTypeTableAdapter.Fill(this.dsHell.sActivityType);
            // TODO: This line of code loads data into the 'dsHell.sActivity' table. You can move, or remove it, as needed.
            this.sActivityTableAdapter.Fill(this.dsHell.sActivity);
        }
    }
}
