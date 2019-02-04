﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Angel
{
    public partial class fMain : Form
    {
        public static cSchool oSchool;
        public fAngel formAngel;
        public fSchool formSchool;
        public fReferences formReferences;
        public static List<fEditCharacteristic> formEditCharacteristics = new List<fEditCharacteristic>();

        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Shown(object sender, EventArgs e)
        {
            oSchool = new cSchool();
            oSchool.Load();
        }

        public static void SQLChangeQuery(string sql)//Запрос к SQL на изменение данных
        {
            string ConnectionString = @"user id=sa;password=24572457;server=(local);Trusted_Connection=yes;database=Hell;connection timeout=30";

            SqlConnection Connection = new SqlConnection(ConnectionString);

            try
            {
                Connection.Open();
            }
            catch (SqlException se)
            {
                //Console.WriteLine("Ошибка :{0}", se.Message);
            }

            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.ExecuteNonQuery();

            Connection.Close();
            Connection.Dispose();
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
                default:
                    break;
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag)
            {
                case "10":
                    if (formAngel == null)
                    {
                        formAngel = new fAngel();
                        formAngel.MdiParent = this;
                        formAngel.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Child_FormClosed);
                        formAngel.Show();
                    }
                    else
                    {
                        formSchool.Activate();
                    }
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
                default:
                    break;
            }
        }
    }
}
