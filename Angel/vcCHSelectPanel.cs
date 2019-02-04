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
    public partial class CHSelectPanel : UserControl
    {
        //private string[] _sValues;
        //public int[] iValues;

        public event EventHandler PointsChanged;

         public CHSelectPanel()
         {
            InitializeComponent();
            Tag = new int[3] { -1, -1, -1 };

            comboBox.ValueMember = "ID";
            comboBox.DisplayMember = "Name";
            comboBox.DataSource = fMain.oSchool.CharacterInfo;
            comboBox.FormattingEnabled = false;
            comboBox.SelectedIndex = 0;
        }
        
        public int Points
        {
            get { return ((cCharacterInfo)comboBox.SelectedItem).ID; }
            set { comboBox.SelectedValue = value; }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] T = (int[])Tag;
            if (T[0] >= 0 && T[1] >= 0 && T[2] >= 0)
            {
                
                //Обновление массива...
                fMain.oSchool.Activity[T[0]].Growth[T[1]][T[2]] = null;
                int[] i = new int[1];
                i[0] = ((cCharacterInfo)comboBox.SelectedItem).ID;
                fMain.oSchool.Activity[T[0]].Growth[T[1]][T[2]] = i;

                //Обновление базы...
                string _SQL;
                _SQL = @"EXEC sp_xActivityCharacterN_Modify " + (T[0]) + "," + (T[1]) + "," + (T[2]) + ",'" + ((cCharacterInfo)comboBox.SelectedItem).ID.ToString() + "'";
                fMain.SQLChangeQuery(_SQL);
            }

            if (PointsChanged != null) this.PointsChanged(this, e);
        }
    }
}
