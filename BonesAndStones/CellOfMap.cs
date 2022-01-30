using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonesAndStones
{
    public partial class CellOfMap : UserControl
    {
        private CellType _cellType;

        public event EventHandler<eSelectCellEventArgs> CellClick;

        public int N { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public CellOfMap()
        {
            InitializeComponent();
        }

        public CellType CellType
        {
            get
            {
                return _cellType;
            }
            set
            {
                _cellType = value;
                switch (CellType)
                {
                    case CellType.Any:
                        //lbPoints.ForeColor =
                        pnBorder.BackColor =
                        lbSame.ForeColor   =
                        lbOther.ForeColor  = SystemColors.ControlDarkDark;
                        break;
                    case CellType.White:
                        //lbPoints.ForeColor =
                        lbSame.ForeColor   =
                        pnBorder.BackColor = Color.White;
                        lbOther.ForeColor  = Color.Black;
                        break;
                    case CellType.Black:
                        //lbPoints.ForeColor =
                        lbSame.ForeColor   =
                        pnBorder.BackColor = Color.Black;
                        lbOther.ForeColor  = Color.White;
                        break;
                    default:
                        //lbPoints.ForeColor =
                        pnBorder.BackColor =
                        lbSame.ForeColor   =
                        lbOther.ForeColor  = SystemColors.ControlDarkDark;
                        break;
                }
            }
        }

        public int Points
        {
            set { lbPoints.Text = "+" + value.ToString(); }
        }
        public int Same
        {
            set { lbSame.Text = "+" + value.ToString(); }
        }
        public int Other
        {
            set { lbOther.Text = "+" + value.ToString(); }
        }
        public BoneType BoneOwner
        {
            get;set;
        }
        public int Stone
        {
            set { vBoneStone.Count = value; }
            get { return vBoneStone.Count; }
        }

        public int White
        {
            set { vBoneWhite.Count = value; }
            get { return vBoneWhite.Count; }
        }

        public int Black
        {
            set { vBoneBlack.Count = value; }
            get { return vBoneBlack.Count; }
        }

        private void _CellClick(object sender, EventArgs e)
        {
            eSelectCellEventArgs E = new eSelectCellEventArgs();
            E.N = this.N;
            E.X = this.X;
            E.Y = this.Y;
            if (CellClick != null) CellClick(this, E);

        }
    }
}
