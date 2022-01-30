using AngelModel;
using ModelDB;
using ModelLIB;
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
    public partial class fAngel : Form
    {
        public cAngel oAngel;
        public fSelectActivity formSelectActivity;

        public fAngel()
        {
            InitializeComponent();
            oAngel = new cAngel();

            oAngel.onValueChanged += oAngel_onValueChanged;
            for (int x = 0; x < 5; x++)
                for (int y = 1; y < 8; y++)
                {
                    Panel p = new Panel();
                    p = (Panel)tlpMain.GetControlFromPosition(x, y);
                    p.Visible = false;
                }
        }

        private void oAngel_onValueChanged(object sender, eValueEventArgs e)
        {
            string _max = e.Max.ToString();
            string _val = e.Value.ToString();
            string _sco = cFunc.Sign(e.Score);

            switch (e.ID)
            {
                case 0:
                    pl0.Points = e.Value;
                    pl0.Shift = e.Shift;
                    lbScoreForce.Text = _sco;
                    break;
                case 1:
                    pl1.Points = e.Value;
                    pl1.Shift = e.Shift;
                    lbScorePhysique.Text = _sco;
                    break;
                case 2:
                    pl2.Points = e.Value;
                    pl2.Shift = e.Shift;
                    lbScoreAgility.Text = _sco;
                    break;
                case 3:
                    pl3.Points = e.Value;
                    pl3.Shift = e.Shift;
                    lbScoreWisdom.Text = _sco;
                    break;
                case 4:
                    pl4.Points = e.Value;
                    pl4.Shift = e.Shift;
                    lbScoreMagic.Text = _sco;
                    break;
                case 5:
                    pl5.Points = e.Value;
                    pl5.Shift = e.Shift;
                    break;
                case 6:
                    lbBattleMax.Text = _max;
                    lbBattleCur.Text = _val;
                    break;
                case 7:
                    lbFreePoint.Text = _val;
                    break;
                case 8:
                    lbLifeMax.Text = _max;
                    lbLifeCur.Text = _val;
                    break;
                case 9:
                    lbRiskMax.Text = _max;
                    lbRiskCur.Text = _val;
                    break;
                case 10:
                    lbScienceMax.Text = _max;
                    lbScienceCur.Text = _val;
                    break;
                case 11:
                    lbSpiritMax.Text = _max;
                    lbSpiritCur.Text = _val;
                    break;
            }
            //oAngel.Practice.DaysLeftControl  = btDay;
            //oAngel.Practice.DaysTotalControl = lbDays;
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
                Control_Click(sender, (EventArgs)e);
            }
        }

        private void btDay_Click(object sender, EventArgs e)
        {
            formSelectActivity = new fSelectActivity(oAngel);

            if (formSelectActivity.ShowDialog(this) == DialogResult.OK)
            {
                btDay.Text = (oAngel.Practice.DaysLeft).ToString();
                btDay.Enabled = (oAngel.Practice.DaysLeft > 0);
                if (oAngel.Practice.DaysLeft == 0)
                {
                    btCh0dec.Visible = btCh0inc.Visible =
                    btCh1dec.Visible = btCh1inc.Visible =
                    btCh2dec.Visible = btCh2inc.Visible =
                    btCh3dec.Visible = btCh3inc.Visible =
                    btCh4dec.Visible = btCh4inc.Visible =
                    btCh5dec.Visible = btCh5inc.Visible = true;
                    lbPracticeCode.Text = oAngel.GetPracticeString(); //Руна стажа...
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
            btEnd.Visible = ((Label)sender).Text == "0" && !btDay.Visible;
        }

        private void btCh_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if(btDay.Visible == true) oAngel.SetShift(0);//Обнулить штришки лишь, но лишь при первом нажатии...
                int c = int.Parse(((Button)sender).Tag.ToString()) % 10;
                int s = (int.Parse(((Button)sender).Tag.ToString()) > 129) ? 1 : -1;
                oAngel.Character[c].Value += s;
                oAngel.Character[c].Shift += s;
                oAngel._Bonus.ShiftValue(-s);
                btCh0dec.Enabled = (oAngel._Force.Shift    > 0);
                btCh1dec.Enabled = (oAngel._Physique.Shift > 0);
                btCh2dec.Enabled = (oAngel._Agility.Shift  > 0);
                btCh3dec.Enabled = (oAngel._Wisdom.Shift   > 0);
                btCh4dec.Enabled = (oAngel._Magic.Shift    > 0);
                btCh5dec.Enabled = (oAngel._Luck.Shift     > 0);
                btDay.Visible = false; //Скрыть кнопку обучения...
            }
           
            btCh0inc.Enabled =
            btCh1inc.Enabled =
            btCh2inc.Enabled =
            btCh3inc.Enabled =
            btCh4inc.Enabled =
            btCh5inc.Enabled = (oAngel._Bonus.Value > 0);
            btEnd.Visible = (oAngel._Bonus.Value == 0);

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //Переделать радио на клики!!!
        }

        private void Control_Click(object sender, EventArgs e)
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
                    btNext.Tag = "110";
                    break;
                case "110":
                case "111":
                    //Сохраняем...
                    if (rbSexMale.Checked) oAngel.Sex = 1;
                    if (rbSexFemale.Checked) oAngel.Sex = 2;
                    oAngel.SetStartValues(7, 36);

                    oAngel.SetShift(0);
                    rbLuckRND.Focus();
                    btNext.Tag = "120";
                    //Прячем...
                    rbLuckRND.Enabled = 
                    btNext.Visible =
                    rbSexMale.Visible = rbSexFemale.Visible =
                    rbSexMale.Enabled = rbSexFemale.Enabled = false;
                    //Отображаем...
                    lbSex.Text = cSchool.Sex[oAngel.Sex].Name;
                    lbSex.Visible = 
                    tlpMain.Visible = 
                    pnLuckCaption.Visible = 
                    pnLuckValue.Visible = 
                    btNext.Visible =
                    rbLuckRND.Enabled = 
                    rbLuckRND.Checked = true;
                    break;
                case "120":
                case "121":
                    //Сохраняем...
                    if (rbLuckAVG.Checked) oAngel._Luck.ShiftValue(28);
                    if (rbLuckRND.Checked) oAngel._Luck.ShiftValue(cSchool.RND(56));
                    //Прячем...
                    btNext.Visible =
                    rbLuckAVG.Visible = 
                    rbLuckRND.Visible = false;
                    //Отображаем...
                    for (int x = 0; x < 5; x++)
                        for (int y = 1; y < 8; y++)
                            ((Panel)this.tlpMain.GetControlFromPosition(x, y)).Visible = true;
                    btDay.Focus();
                    break;
                case "150": //"ЗАВЕРШИТЬ"
                    //Сохраняем...
                    oAngel.SetShift(0);
                    //Прячем...
                    btDay.Visible =
                    btCh0dec.Visible = btCh0inc.Visible =
                    btCh1dec.Visible = btCh1inc.Visible =
                    btCh2dec.Visible = btCh2inc.Visible =
                    btCh3dec.Visible = btCh3inc.Visible =
                    btCh4dec.Visible = btCh4inc.Visible =
                    btCh5dec.Visible = btCh5inc.Visible = false;
                    btEnd.Visible = false;
                    //Отображаем...
                    btSave.Visible = true;
                    break;
                case "160"://"СОХРАНИТЬ"
                    //Сохраняем...
                    SaveAngel();
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

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btNext.Visible = (tbName.Text.Length > 0);
        }

        public void SaveAngel()
        {
            DBEntities db = new DBEntities();
            dAngel a = db.dAngel.Where(c => c.IDdAngel == oAngel.ID).FirstOrDefault();
            if(a == null)
            {
                dAngel angel = db.dAngel.Add(new dAngel { IDdAngel = oAngel.ID, Name = oAngel.Name, IDsSex = oAngel.Sex, IDsLoyaltyToLaw = 1 });
                for (int c = 0; c < oAngel.Character.Count; c++)
                {
                    dAngelCharacter character = db.dAngelCharacter.Add(new dAngelCharacter { dAngel = angel, IDsCharacter = c, Val = oAngel.Character[c].Value, Max = oAngel.Character[c].Max });
                }
                for (int d = 0; d < oAngel.Practice.Day.Count; d++)
                {
                    dAngelPracticeDay day = db.dAngelPracticeDay.Add(new dAngelPracticeDay { dAngel = angel, IDdAngel = angel.IDdAngel, IDdPracticeDay = Guid.NewGuid(), DayNumber = d, IDsActivity = oAngel.Practice.Day[d].Activity });
                    for (int c = 0; c < oAngel.Practice.Day[d].Character.Length; c++)
                    {
                        dAngelPracticeDayShift shift = db.dAngelPracticeDayShift.Add(new dAngelPracticeDayShift { dAngelPracticeDay = day, IDdPracticeDay = day.IDdPracticeDay, IDsCharacter = c, Shift = oAngel.Practice.Day[d].Character[c] });
                    }
                }
                db.SaveChanges();
                oAngel.ID = angel.IDdAngel;

            }

        }
    }
}
