using AngelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngelicTrueStory
{
    public partial class fSelectActivity : Form
    {
        public int NumDay;
        Button[] bnActivity = new Button[12];
        cAngel _Angel;

        public fSelectActivity(cAngel _angel)
        {
            InitializeComponent();

            _Angel = _angel;
            NumDay = _Angel.Practice.DayCurrent % 7;

            bnActivity[ 0] = bt00;
            bnActivity[ 1] = bt01;
            bnActivity[ 2] = bt02;
            bnActivity[ 3] = bt03;
            bnActivity[ 4] = bt04;
            bnActivity[ 5] = bt05;
            bnActivity[ 6] = bt06;
            bnActivity[ 7] = bt07;
            bnActivity[ 8] = bt08;
            bnActivity[ 9] = bt09;
            bnActivity[10] = bt10;
            bnActivity[11] = bt11;

            for(int n = 0; n < 12; n++)
            {
                bool IsAct = cSchool.Activity[n].IsActive(NumDay, _Angel.Practice.OfActivityTotal(n));
                bnActivity[n].Visible = IsAct;
                bnActivity[n].Text = cSchool.Activity[n].Name;
                Tips.IsBalloon = true;
                Tips.SetToolTip(bnActivity[n], cSchool.Activity[n].Descr);
                if (IsAct == false)
                {
                    tlpButtons.RowStyles[n].SizeType = SizeType.Absolute;
                    tlpButtons.RowStyles[n].Height = 0;
                }
            }
            this.Text = "День " + (_Angel.Practice.DayCurrent + 1).ToString() + "...";
        }

        private void bt_Click(object sender, EventArgs e)
        {
            int NumActivity = int.Parse(((Button)sender).Tag.ToString());

            _Angel.EngadeInActivity(NumActivity);
        }

        private void bt_MouseHover(object sender, EventArgs e)
        {
            int n = int.Parse(((Button)sender).Tag.ToString());
            tbDescr.Text = cSchool.Activity[n].Descr;
        }
    }
}
