using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BonesAndStones
{
    public partial class vBone : UserControl
    {
        private BoneType _bonetype;
        private int _count;

        //public event EventHandler<eSelectBoneEventArgs> BoneClick;

        public BoneControl boneControl;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                this.Visible = !(_count == 0);
                lbBone.Text = (_count > 1) ? _count.ToString() : "";
            }
        }

        public vBone()
        {
            InitializeComponent();
            Count = 5;
            boneControl = new BoneControl();
            boneControl.Color = Color.DarkGray;
            BoneType = BoneType.Stone;
            Controls.Add(boneControl);
        }

        public vBone(BoneType bonetype)
        {
            InitializeComponent();
            Count = 1;
            boneControl = new BoneControl();
            boneControl.Color = Color.DarkGray; 
            BoneType = bonetype;
            Controls.Add(boneControl);
        }

        public BoneType BoneType
        {
            set
            {
                _bonetype = value;
                switch (_bonetype)
                {
                    case BoneType.Stone:
                        boneControl.Color = Color.DimGray;
                        lbBone.BackColor = Color.DimGray;
                        lbBone.ForeColor = Color.DarkGray;
                                    break;
                                case BoneType.White:
                                    boneControl.Color = Color.White;
                        lbBone.BackColor = Color.White;
                        lbBone.ForeColor = Color.Black;
                        break;
                    case BoneType.Black:
                        boneControl.Color = Color.Black;
                        lbBone.BackColor = Color.Black;
                        lbBone.ForeColor = Color.White;
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return _bonetype;
            }
        }

        //private void _Click(object sender, EventArgs e)
        //{
        //    eSelectBoneEventArgs E = new eSelectBoneEventArgs();
        //    E.Bone = this._bonetype;
        //    if (BoneClick != null) BoneClick(this, E);
        //}
    }

    public sealed class BoneControl : Control
    {
        public BoneControl()
        {
            Height = Width = 24;
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var grfx = e.Graphics;
            grfx.SmoothingMode = SmoothingMode.AntiAlias;
            grfx.FillEllipse(new SolidBrush(_color), 0, 0, Width - 1, Height - 1);
        }

        private Color _color = Color.Black;

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                Invalidate();
            }
        }
    }

}
