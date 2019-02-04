using Angel.Models;
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
    public partial class fAngel : Form
    {
        public cAngel oAngel;
        public fSelectActivity formSelectActivity;

        public fAngel()
        {
            InitializeComponent();
            oAngel = new cAngel();

            oAngel._Force.ValueControl    = pl0;
            oAngel._Physique.ValueControl = pl1;
            oAngel._Agility.ValueControl  = pl2;
            oAngel._Wisdom.ValueControl   = pl3;
            oAngel._Magic.ValueControl    = pl4;
            oAngel._Luck.ValueControl     = pl5;
            oAngel._Battle.MaxControl     = lbBattleMax;
            oAngel._Battle.ValueControl   = lbBattleCur;
            oAngel._Life.MaxControl       = lbLifeMax;
            oAngel._Life.ValueControl     = lbLifeCur;
            oAngel._Bonus.ValueControl    = lbFreePoint;
            oAngel.Practice.DaysLeftControl  = btDay;
            oAngel.Practice.DaysTotalControl = lbDays;

            oAngel._Risk.MaxControl      = lbRiskMax;
            oAngel._Risk.ValueControl    = lbRiskCur;
            oAngel._Science.MaxControl   = lbScienceMax;
            oAngel._Science.ValueControl = lbScienceCur;
            oAngel._Spirit.MaxControl    = lbSpiritMax;
            oAngel._Spirit.ValueControl  = lbSpiritCur;

            oAngel._Force.ScoreControl    = lb00;
            oAngel._Physique.ScoreControl = lb01;
            oAngel._Agility.ScoreControl  = lb02;
            oAngel._Wisdom.ScoreControl   = lb03;
            oAngel._Magic.ScoreControl    = lb04;

            for (int x = 0; x < 5; x++)
                for (int y = 1; y < 8; y++)
                {
                    Panel p = new Panel();
                    p = (Panel)tlpMain.GetControlFromPosition(x, y);
                    p.Visible = false;
                }
        }

        private void fAngel_Load(object sender, EventArgs e)
        {
            lbDays.Text = oAngel.Practice.DaysOfActivity.ToString();
            btDay.Text = oAngel.Practice.DaysOfActivity.ToString();
        }

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (((Control)sender).Tag)
                {
                    case "100":
                        //Сохраняем...
                        oAngel.Name = tbName.Text;
                        //Прячем...
                        lbNameEnter.Visible = tbName.Visible = 
                        lbNameEnter.Enabled = tbName.Enabled = false;
                        //Отображаем...
                        lbName.Text = tbName.Text;
                        lbName.Dock = DockStyle.Fill;
                        lbName.Visible = true;
                        rbSexMale.Visible = rbSexFemale.Visible = 
                        rbSexMale.Enabled = rbSexFemale.Enabled = true;
                        rbSexMale.Focus();
                        break;
                    case "110":
                    case "111":
                        //Сохраняем...
                        if (rbSexMale.Checked)   oAngel.Sex = 1;
                        if (rbSexFemale.Checked) oAngel.Sex = 2;
                        //Прячем...
                        rbSexMale.Visible = rbSexFemale.Visible = 
                        rbSexMale.Enabled = rbSexFemale.Enabled = false;
                        //Отображаем...
                        lbSex.Visible = true;
                        lbSex.Text = fMain.oSchool.Sex[oAngel.Sex].Name;
                        tlpMain.Visible = true;
                        pnLuckCaption.Visible = true;
                        pnLuckValue.Visible = true;

                        oAngel.SetStartValues(7, 36);
                        rbLuckRND.Focus();
                        break;
                    case "120":
                    case "121":
                        //Сохраняем...
                        if (rbLuckAVG.Checked) oAngel._Luck.Value += 28;
                        if (rbLuckRND.Checked) oAngel._Luck.Value += fMain.oSchool.RND(56);
                        //Прячем...
                        rbLuckAVG.Visible = rbLuckRND.Visible = false;
                        //Отображаем...
                        for (int x = 0; x < 5; x++)
                            for (int y = 1; y < 8; y++)
                                ((Panel)this.tlpMain.GetControlFromPosition(x, y)).Visible = true;
                        btDay.Focus();
                        break;
                    case "1101":
                        //Сохраняем...
                        //Прячем...
                        //Отображаем...
                        break;
                    case "1110":
                        //Сохраняем...
                        //Прячем...
                        //Отображаем...
                        break;
                    case "1111":
                        //Сохраняем...
                        //Прячем...
                        //Отображаем...
                        break;
                    case "1011":
                        //Сохраняем...
                        //Прячем...
                        //Отображаем...
                        break;


                }
            }
        }

        private void btDay_Click(object sender, EventArgs e)
        {
            formSelectActivity = new fSelectActivity(oAngel);

            if (formSelectActivity.ShowDialog(this) == DialogResult.OK)
            {
                btDay.Text = (oAngel.Practice.DaysLeft).ToString();
                btDay.Enabled = btDay.Visible = (oAngel.Practice.DaysLeft > 0);
                if (oAngel.Practice.DaysLeft == 0)
                {
                    btCh0dec.Visible = btCh0inc.Visible =
                    btCh1dec.Visible = btCh1inc.Visible =
                    btCh2dec.Visible = btCh2inc.Visible =
                    btCh3dec.Visible = btCh3inc.Visible =
                    btCh4dec.Visible = btCh4inc.Visible =
                    btCh5dec.Visible = btCh5inc.Visible = true;
                    btCh_Click(null, null);
                }
            }

            formSelectActivity.Dispose();
        }

        private void fAngel_Activated(object sender, EventArgs e)
        {
            btDay.Text = (oAngel.Practice.DaysOfActivity - oAngel.Practice.DayCurrent).ToString();
        }

        private void fAngel_Enter(object sender, EventArgs e)
        {
            btDay.Text = (oAngel.Practice.DaysOfActivity - oAngel.Practice.DayCurrent).ToString();
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            ((Label)sender).Visible = ((Label)sender).Text != "0";
        }

        private void Control_Changed(object sender, EventArgs e)
        {
            //switch (((Control)sender).Tag)
            //{
            //    case "100":
            //        //lbName.Text = tbName.Text;
            //        //lbName.Dock = DockStyle.Fill;
            //        //lbName.Visible = true;
            //        //lbNameEnter.Visible = false;
            //        //tbName.Visible = false;
            //        //oAngel.Name = tbName.Text;
            //        break;
            //    case "110":
            //    case "111":
            //        //if (rbSexMale.Checked)   oAngel.Sex = 1;
            //        //if (rbSexFemale.Checked) oAngel.Sex = 2;
            //        //lbSex.Text = fMain.oSchool.Sex[oAngel.Sex].Name;
            //        ////lbSex.Dock = DockStyle.Fill;
            //        //rbSexMale.Visible = rbSexFemale.Visible = false;
            //        //tlpMain.Visible = true;
            //        //lbSex.Visible = true;
            //        ////cbSex.Visible = false;
            //        ////oAngel.SetStartValues(9, 36);
            //        //break;
            //}
        }

        private void btCh_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                int c = int.Parse(((Button)sender).Tag.ToString()) % 10;
                int s = (int.Parse(((Button)sender).Tag.ToString()) > 129) ? 1 : -1;
                oAngel.Character[c].ShiftValue(s);
                oAngel._Bonus.ShiftValue(-s);
            }

            btCh0dec.Enabled = 
            btCh1dec.Enabled = 
            btCh2dec.Enabled = 
            btCh3dec.Enabled = 
            btCh4dec.Enabled = 
            btCh5dec.Enabled = (oAngel._Bonus.Value < oAngel._Bonus.Max);
            btCh0inc.Enabled =
            btCh1inc.Enabled =
            btCh2inc.Enabled =
            btCh3inc.Enabled =
            btCh4inc.Enabled =
            btCh5inc.Enabled = (oAngel._Bonus.Value > 0);
        }
    }
}
