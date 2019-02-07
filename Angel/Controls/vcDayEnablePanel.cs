using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angel
{
    public partial class DayEnablePanel : UserControl
    {
        public event EventHandler ActivityChanged;

        public bool CharacterChecked
        {
            get { return cbBox.Checked; }
            set { cbBox.Checked = value; }
        }

        public string LabelTop
        {
            get { return lTop.Text; }
            set { lTop.Text = value; }
        }

        public string LabelBottom
        {
            get { return lBottom.Text; }
            set { lBottom.Text = value; }
        }

        public DayEnablePanel()
        {
            InitializeComponent();
            Tag = new int[2] { -1, -1 };
            lTop.Visible = false;
            lBottom.Visible = false;
        }

        public void StatVisible(bool Value)
        {
            lTop.Visible = (Value && this.Enabled);
            lBottom.Visible = (Value && this.Enabled);
        }

        private void cbBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ActivityChanged != null) this.ActivityChanged(this, e);
        }
    }
}
