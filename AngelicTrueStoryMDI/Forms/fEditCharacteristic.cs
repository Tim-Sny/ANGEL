using AngelicTrueStoryMDI.Controls;
using AngelModel;
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
    public partial class fEditCharacteristic : Form
    {
        private int _Number;
        private int _DisabledColumnWidth = 50; //Ширина неактивных столбцов...
        private int _NumCharacter = 7;

        public fEditCharacteristic(object NumberCharacter)
        {
           InitializeComponent();

            chSelectPanel1.DataSource = cSchool.CharacterInfo;

            Control[,] PP = new Control[_NumCharacter, 7];

            this.Tag = NumberCharacter;
            _Number = int.Parse(this.Tag.ToString()) - 1;

            lName.Text = cSchool.Activity[_Number].Name;

            for (int c = 0; c < _NumCharacter; c++)
            {
                ((Label)tlTrainPanel.GetControlFromPosition(0, c + 1)).Text = cSchool.CharacterInfo[c].Name + " (" + cSchool.CharacterInfo[c].NameAlt + ")";
                if (c == 6 && cSchool.Activity[_Number].Type != 0)  //Если это БП, то показывать только для тренировок...
                    ((Label)tlTrainPanel.GetControlFromPosition(0, c + 1)).Enabled = false;
                for (int d = 0; d < 7; d++)
                {
                    PP[c, d] = ((Control)tlTrainPanel.GetControlFromPosition(d + 1, c + 1));
                    PP[c, d].Tag = new int[3] { _Number, c, d };
                    PP[c, d].Enabled = (cSchool.Activity[_Number].Type == 0) ? (d < 3) : ((cSchool.Activity[_Number].WeekDayEnable[d] == 1) && c != 6);
                    if (tlTrainPanel.GetControlFromPosition(d + 1, c + 1) is PointsPanel)
                    {
                        ((PointsPanel)PP[c, d]).Points = cFunc.ArrToStr(cSchool.Activity[_Number].Growth[c][d]);
                    }
                    else if (tlTrainPanel.GetControlFromPosition(d + 1, c + 1) is CHSelectPanel)
                    {
                        ((CHSelectPanel)PP[c, d]).Points = int.Parse((cFunc.ArrToStr(cSchool.Activity[_Number].Growth[c][d])));
                    }

                }
            }

            for (int d = 0; d < 7; d++)
            {
                cbShowStat.Checked = false;
                Label L = ((Label)tlTrainPanel.GetControlFromPosition(d + 1, 0));
                L.Text    = (cSchool.Activity[_Number].Type == 0) ? cFunc.ToRoman(d + 1) : cFunc.WeekDay[d].Substring(0, 4).ToUpper();
                L.Enabled = (cSchool.Activity[_Number].Type == 0) ? (d < 3) : (cSchool.Activity[_Number].WeekDayEnable[d] == 1);
                if (cSchool.Activity[_Number].Type == 0)
                {
                    if (!(d < 3))
                    {
                        tlTrainPanel.ColumnStyles[d + 1].SizeType = SizeType.Absolute;
                        tlTrainPanel.ColumnStyles[d + 1].Width = _DisabledColumnWidth;
                    }
                }
                else
                {
                    if (!(cSchool.Activity[_Number].WeekDayEnable[d] == 1))
                    {
                        tlTrainPanel.ColumnStyles[d + 1].SizeType = SizeType.Absolute;
                        tlTrainPanel.ColumnStyles[d + 1].Width = _DisabledColumnWidth;
                    }
                }
            }
        }

        private void fEditCharacteristic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsHell.xActivityTrain' table. You can move, or remove it, as needed.
            //this.xActivityTrainTableAdapter.Fill(this.dsHell.xActivityTrain);
            //chSelectPanel1.DataSource = cSchool.CharacterInfo;
            //chSelectPanel1.
        }

        private void cbShowStat_CheckedChanged(object sender, EventArgs e)
        {
            for (int c = 0; c < _NumCharacter; c++)
                for (int d = 0; d < 7; d++)
                    if (tlTrainPanel.GetControlFromPosition(d + 1, c + 1) is PointsPanel)
                        ((PointsPanel)tlTrainPanel.GetControlFromPosition(d + 1, c + 1)).StatVisible(((CheckBox)sender).Checked);
        }

        private void fEditCharacteristic_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
            //base.OnResizeBegin(e);
        }

        private void fEditCharacteristic_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout();
           // base.OnResizeEnd(e);
        }
    }
}
