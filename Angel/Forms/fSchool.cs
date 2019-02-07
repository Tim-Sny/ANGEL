using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Angel.Models;

namespace Angel
{
    public partial class fSchool : Form
    {
        public fSchool()
        {
            InitializeComponent();

            //Таблица тренировок по дням недели...
            for (int i = 0; i < fMain.oSchool.Activity.Count(); i++)
            {
                Button TB = (Button)this.lpActivityDayEnabled.GetControlFromPosition(1, i + 1);
                TB.Text = fMain.oSchool.Activity[i].Name;
                for (int j = 0; j < fMain.oSchool.Activity[i].WeekDayEnable.Count(); j++)
                {
                    DayEnablePanel DEP = (DayEnablePanel)this.lpActivityDayEnabled.GetControlFromPosition(j + 2, i + 1);
                    DEP.CharacterChecked = (fMain.oSchool.Activity[i].WeekDayEnable[j] == 1);
                }
            }
            for (int n = 0; n < cFunc.WeekDay.Length; n++)
            {
                ((Label)this.lpActivityDayEnabled.GetControlFromPosition(n + 2, 0)).Text = cFunc.WeekDay[n].Substring(0, 4).ToUpper();
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(((Button)sender).Tag);
            bool Ex = false;
            fEditCharacteristic formEditCharacteristic;

            foreach (fEditCharacteristic f in fMain.formEditCharacteristics)
            {
                if(Convert.ToInt32(f.Tag) == n)
                {
                    Ex = true;
                    formEditCharacteristic = f;
                    formEditCharacteristic.Activate();
                    break;
                }
            }

            if(!Ex)
            {
                fMain.formEditCharacteristics.Add(formEditCharacteristic = new fEditCharacteristic(((Button)sender).Tag));
                formEditCharacteristic.Tag = ((Button)sender).Tag;
                formEditCharacteristic.MdiParent = this.MdiParent;
                formEditCharacteristic.FormClosed += new System.Windows.Forms.FormClosedEventHandler(formEditCharacteristic_FormClosed);
                formEditCharacteristic.Show();
            }
        }

        public void formEditCharacteristic_FormClosed(object sender, FormClosedEventArgs e)
        {
            int n = Convert.ToInt32(((fEditCharacteristic)sender).Tag);
            fEditCharacteristic formEditCharacteristic;

            foreach (fEditCharacteristic f in fMain.formEditCharacteristics)
            {
                if (Convert.ToInt32(f.Tag) == n)
                {
                    formEditCharacteristic = f;
                    formEditCharacteristic = null;
                    fMain.formEditCharacteristics.Remove(f);
                    break;
                }
            }
        }

        private void dayEnablePanel_ActivityChanged(object sender, EventArgs e)
        {
            int _IDActivity = this.lpActivityDayEnabled.GetRow((DayEnablePanel)sender) - 1;
            int _IDsDay = this.lpActivityDayEnabled.GetColumn((DayEnablePanel)sender) - 2;
            int _Enable = ((((DayEnablePanel)sender).CharacterChecked) ? 1 : 0);

            fMain.oSchool.Activity[_IDActivity].WeekDayEnable[_IDsDay] = _Enable;
            
            DBEntities db = new DBEntities();
            db.sp_xActivityDay_Modify(_IDActivity,_IDsDay,_Enable);
        }

        private void cbShowStat_CheckedChanged(object sender, EventArgs e)
        {
            for (int l = 0; l < fMain.oSchool.Activity.Count(); l++)
            {
                for (int d = 0; d < fMain.oSchool.Activity[l].WeekDayEnable.Count(); d++)
                {
                    bool _ShowStat = false;
                    DayEnablePanel D = ((DayEnablePanel)this.lpActivityDayEnabled.GetControlFromPosition(d + 2, l + 1));
                    D.LabelTop = "";
                    D.LabelBottom = "";
                    if (fMain.oSchool.Activity[l].WeekDayEnable[d] == 1)
                    {
                        int _Max = -10000;
                        int _CharacterID = -1;
                        for (int c = 0; c < fMain.oSchool.Activity[l].Growth.Length; c++)
                        {
                            for (int p = 0; p < fMain.oSchool.Activity[l].Growth[c][d].Length; p++)
                            {
                                if (fMain.oSchool.Activity[l].Growth[c][d][p] > _Max)
                                {
                                    _Max = fMain.oSchool.Activity[l].Growth[c][d][p];
                                    _CharacterID = c;
                                    _ShowStat = (_Max > 0);
                                }
                            }
                        }
                        D.LabelTop = cFunc.Sign(_Max);
                        D.LabelBottom = fMain.oSchool.CharacterInfo[_CharacterID].Name;
                    }

                    D.StatVisible( ((CheckBox)sender).Checked && _ShowStat);
                }
            }
        }
    }
}
