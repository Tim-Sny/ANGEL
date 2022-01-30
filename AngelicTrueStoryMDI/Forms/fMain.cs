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
using AngelModel;
using AngelicTrueStory;
using ModelDB;
using BonesAndStones;

namespace AngelicTrueStoryMDI
{
    public partial class fMain : Form
    {
        //public static cSchool oSchool;
        public fAngel formAngel;
        public fSchool formSchool;
        public fReferences formReferences;
        public fBonesAndStones formBonesAndStones;
        public static List<fEditCharacteristic> formEditCharacteristics = new List<fEditCharacteristic>();

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            DBEntities db = new DBEntities();

            //oSchool = new cSchool();
            cSchool.Load();
        }

        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (((Form)sender).Tag)
            {
                case "10":
                    formAngel = null;
                    break;
                case "20":
                    formSchool = null;
                    break;
                case "30":
                    formReferences = null;
                    break;
                case "40":
                    formBonesAndStones = null;
                    break;
                default:
                    break;
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "10":
                    formAngel = new fAngel();
                    formAngel.MdiParent = this;
                    formAngel.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Child_FormClosed);
                    formAngel.Show();
                    //if (formAngel == null)
                    //{
                    //formAngel = new fAngel();
                    //    formAngel.MdiParent = this;
                    //    formAngel.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Child_FormClosed);
                    //    formAngel.Show();
                    //}
                    //else
                    //{
                    //    formAngel.Activate();
                    //}
                    break;
                case "20":
                    if (formSchool == null)
                    {
                        formSchool = new fSchool();
                        formSchool.MdiParent = this;
                        formSchool.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Child_FormClosed);
                        formSchool.Show();
                    }
                    else
                    {
                        formSchool.Activate();
                    }
                    break;
                case "30":
                    if (formReferences == null)
                    {
                        formReferences = new fReferences();
                        formReferences.MdiParent = this;
                        formReferences.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Child_FormClosed);
                        formReferences.Show();
                    }
                    else
                    {
                        formReferences.Activate();
                    }
                    break;
                case "40":
                    if (formBonesAndStones == null)
                    {
                        cGame game = new cGame();
                        fBonesAndStones formBonesAndStones = new fBonesAndStones();
                        сMessages messages = new сMessages();
                        cPresenter presenter = new cPresenter(game, formBonesAndStones, messages);

                        formBonesAndStones.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Child_FormClosed);
                        formBonesAndStones.ShowDialog();
                    }
                    else
                    {
                        formBonesAndStones.Activate();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
