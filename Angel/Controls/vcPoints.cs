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
using System.Threading;

namespace Angel
{
    public partial class PointsLabel : UserControl
    {
        private int _points;
        private int _shift;

        public PointsLabel()
        {
            InitializeComponent();
        }

        public int Points
        {
            set
            {
                _points = value;
                int l = (int)((Math.Sqrt(1 + 8 * _points) - 1) / 2);
                int p = (_points - (l * (l + 1)) / 2);

                lbLevel.Text = l.ToString();
                lbPoint.Text = p.ToString();

                #region Для асинхронной анимации...
                //Action action1 = () => lbLevel.Text = l.ToString();
                //Action action2 = () => lbPoint.Text = p.ToString();
                //// Свойство InvokeRequired указывает, нeжно ли обращаться к контролу с помощью Invoke
                //if (InvokeRequired)
                //{
                //    Invoke(action1);
                //    Invoke(action2);
                //}
                //else
                //{
                //    lbLevel.Text = l.ToString();
                //    lbPoint.Text = p.ToString();
                //}
                #endregion Для асинхронной анимации...
            }
            get { return _points; }
        }
        public int Shift
        {
            set
            {
                _shift = value;

                lbShift.Text = ".." + cFunc.Sign(_shift.ToString());
                lbShift.Visible = (_shift != 0);
                lbShift.ForeColor = (_shift < 0) ? Color.Maroon : Color.Green;

                #region Для асинхронной анимации...
                //Action action1 = () => lbShift.Text = ".." + cFunc.Sign(_shift.ToString());
                //Action action2 = () => lbShift.Visible = (_shift != 0);
                //Action action3 = () => lbShift.ForeColor = (_shift < 0) ? Color.Maroon : Color.Green;
                //// Свойство InvokeRequired указывает, нeжно ли обращаться к контролу с помощью Invoke
                //if (InvokeRequired)
                //{
                //    Invoke(action1);
                //    Invoke(action2);
                //    Invoke(action3);
                //}
                //else
                //{
                //    lbShift.Text = ".." + cFunc.Sign(_shift.ToString());
                //    lbShift.Visible = (_shift != 0);
                //    lbShift.ForeColor = (_shift < 0) ? Color.Maroon : Color.Green;
                //}
                //if (backgroundWorker.IsBusy != true)
                //{
                //    backgroundWorker.RunWorkerAsync();
                //}
                #endregion Для асинхронной анимации...
            }
            get { return _shift; }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
            int n = Math.Abs(_shift);
            int s = (_shift > 0) ? 1 : -1;
            for (int i = 0; i < n; i++)
            {
                Shift += -s;
                Points += s;
                Thread.Sleep(50);
            }
        }
    }


}
