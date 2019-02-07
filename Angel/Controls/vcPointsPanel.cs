using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Angel.Models;

namespace Angel
{
    public partial class PointsPanel : UserControl
    {
        private string[] _sValues;
        public int[] iValues;

        public event EventHandler PointsChanged;

         public PointsPanel()
         {
            InitializeComponent();
            Tag = new int[3] { -1, -1, -1 };
         }
        
        public string Points
        {
            get { return  textBox.Text; }
            set { textBox.Text = value; }
        }

        public void StatVisible(bool Value)
        {
            //tlPanelTop.Visible = (Value && Enabled);
            lTC.Visible = (Value && Enabled);
            lTL.Visible = (Value && Enabled);
            tlPanelBottom.Visible = (Value && Enabled);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int[] T = (int[])Tag;
            if (T[0] >= 0 && T[1] >= 0 && T[2] >= 0)
            {
                int _Max = -1000;
                int _Min = 1000;
                int _Sum = 0;

                _sValues = null; 
                _sValues = textBox.Text.Split(';');
                iValues = null; iValues = new int[_sValues.Length];

                for (int n = 0; n < iValues.Length; n++)
                {
                    if (!int.TryParse(_sValues[n], out iValues[n])) iValues[n] = 0;
                    _Max = (iValues[n] > _Max) ? iValues[n] : _Max;
                    _Min = (iValues[n] < _Min) ? iValues[n] : _Min;
                    _Sum += iValues[n];
                }

                //Обновление массива...
                fMain.oSchool.Activity[T[0]].Growth[T[1]][T[2]] = null;
                fMain.oSchool.Activity[T[0]].Growth[T[1]][T[2]] = iValues;

                //Обновление базы...
                var db = new DBEntities();
                db.sp_xActivityCharacterN_Modify(T[0], T[1], T[2], cFunc.ArrToStr(fMain.oSchool.Activity[T[0]].Growth[T[1]][T[2]]));

                float _StatAvgSum = fMain.oSchool.Activity[T[0]].GetGrowthAvgSum(T[1], T[2]);
                float _StatMinSum = fMain.oSchool.Activity[T[0]].GetGrowthMinSum(T[1], T[2]);
                float _StatMaxSum = fMain.oSchool.Activity[T[0]].GetGrowthMaxSum(T[1], T[2]);

                float _StatAvg = fMain.oSchool.Activity[T[0]].GetGrowthAvg(T[1], T[2]);
                lTL.Text = (iValues.Length == 1) ? "" : "" + iValues.Length;
                lTR.Text = "..." + cFunc.Sign(Math.Round(_StatAvgSum, 2));
                lTC.Text = (iValues.Length == 1) ? "" : "" + cFunc.Sign(Math.Round(_StatAvg, 2)); ;
                lBL.Text = (iValues.Length == 1) ? "" : "" + cFunc.Sign(_Min) + ".." + cFunc.Sign(_Max);
                lBR.Text = (iValues.Length == 1) ? "" : "..." + cFunc.Sign(_StatMinSum) + "..." + cFunc.Sign(_StatMaxSum);
            }

            if (PointsChanged != null) this.PointsChanged(this, e);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' && e.KeyChar == '1' && e.KeyChar == '2' && e.KeyChar == '3'
             && e.KeyChar == '4' && e.KeyChar == '5' && e.KeyChar == '6' && e.KeyChar == '7'
             && e.KeyChar == '8' && e.KeyChar == '9' && e.KeyChar == ' ' && e.KeyChar == ';'
             && e.KeyChar == '-' && e.KeyChar == '+')
                e.Handled = true;
        }

        private void lTR_MouseClick(object sender, MouseEventArgs e)//Тест генерации "накидок" (для тренировок - уровень 0)
        {
            //int[] T = (int[])Tag;
            //lTR.Text = cFunc.ArrToStr(fMain.oSchool.EngadeInActivity(T[2], T[0], null));
        }
    }
}
