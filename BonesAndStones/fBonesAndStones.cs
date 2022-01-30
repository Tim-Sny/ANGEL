using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonesAndStones
{
    public interface iView
    {
        int _CurrentPlayerID { get; set; }
        BoneType _CurrentBoneType { get; set; }
        //void Move(PlayerType player, BoneType bone, List<Bone> from, List<Bone> to);
        void FillMap(cMap map);
        void ShowAllStones(cMap map, cPlayer[] player);
        void ShowDice(iGame _game);
        void ShowGameStep(string _step);
        void ShowScore(int WhiteScore, int BlackScore);

        void SetCursor(int type);

        event EventHandler<eGameBeginsEventArgs> BeginGame;
        event EventHandler<eSelectBoneEventArgs> BoneSelecting;
        event EventHandler<eSelectCellEventArgs> CellSelected;
        event EventHandler LineSelecting;
        event EventHandler LineSelected;
        event EventHandler UnDo;

    }

    public partial class fBonesAndStones : Form, iView
    {
        CellOfMap[,] CellsOfMap = new CellOfMap[6, 6];

        private int _currentPlayerID;
        private BoneType _currentBoneType;

        private Cursor BlackBone = FromByteArray(Properties.Resources.CursorBlack);
        private Cursor WhiteBone = FromByteArray(Properties.Resources.CursorWhite);

        public static Cursor FromByteArray(byte[] array)
        {
            using (MemoryStream memoryStream = new MemoryStream(array))
            {
                return new Cursor(memoryStream);
            }
        }

        public void SetCursor(int type)
        {
            switch (type)   
            {
                case 0:
                    Cursor = Cursors.Default;
                    break;
                case 1:
                    Cursor = WhiteBone;
                    break;
                case 2:
                    Cursor = BlackBone;
                    break;
                default:
                    Cursor = Cursors.Default;
                    break;
            }
        }

        public fBonesAndStones()
        {
            InitializeComponent();

            MenuItem13.Click += MenuItem13_Click;
            MenuItem26.Click += MenuItem26_Click;
            MenuItem39.Click += MenuItem39_Click;
            
            for (int x = 0; x < 6; x++)
                for (int y = 0; y < 6; y++)
                {
                    CellsOfMap[x, y] = new CellOfMap();
                    //TableLayoutPanelCellPosition position = new TableLayoutPanelCellPosition(x, y);
                    //tlpMap.SetCellPosition(CellsOfMap[x, y], position);
                    CellsOfMap[x, y].X = x;
                    CellsOfMap[x, y].Y = y;
                    CellsOfMap[x, y].N = x * 6 + y;
                    CellsOfMap[x, y].Dock = DockStyle.Fill;
                    CellsOfMap[x, y].CellClick += BonesAndStones_CellClick;         
                    tlpMap.Controls.Add(CellsOfMap[x, y], x, y);
                }
        }

        private void BonesAndStones_CellClick(object sender, eSelectCellEventArgs e)
        {
            if (CellSelected != null)
                CellSelected(this, e);
        }

        private void MenuItem13_Click(object sender, EventArgs e)
        {
            eGameBeginsEventArgs E = new eGameBeginsEventArgs();
            //E = (e as eBeginGameEventArgs);
            E.N = 13;
            if (BeginGame != null) BeginGame(this, E);
        }
        private void MenuItem26_Click(object sender, EventArgs e)
        {
            eGameBeginsEventArgs E = new eGameBeginsEventArgs();
            //E = (e as eBeginGameEventArgs);
            E.N = 26;
            if (BeginGame != null) BeginGame(this, E);
        }
        private void MenuItem39_Click(object sender, EventArgs e)
        {
            eGameBeginsEventArgs E = new eGameBeginsEventArgs();
            //E = (e as eBeginGameEventArgs);
            E.N = 39;
            if (BeginGame != null) BeginGame(this, E);
        }

        public void FillMap(cMap map)
        {
            for (int x = 0; x < 6; x++)
                for (int y = 0; y < 6; y++)
                {
                    CellsOfMap[x, y].Same = map.Cells[x, y].Same;
                    CellsOfMap[x, y].Other = map.Cells[x, y].Other;
                    CellsOfMap[x, y].Points = map.Cells[x, y].Points;
                    CellsOfMap[x, y].CellType = map.Cells[x, y].Type;
                }
        }

        public void ShowAllStones(cMap map, cPlayer[] player)
        {
            for (int x = 0; x < 6; x++)
                for (int y = 0; y < 6; y++)
                {
                    CellsOfMap[x, y].Stone = map.Cells[x, y].Stone;
                    CellsOfMap[x, y].White = map.Cells[x, y].White;
                    CellsOfMap[x, y].Black = map.Cells[x, y].Black;
                }

            vCupStone.Count         = player[0].Stone;
            vCupWhite.Count         = player[0].White;
            vCupBlack.Count         = player[0].Black;
            vWhitePlayerStone.Count = player[1].Stone;
            vWhitePlayerWhite.Count = player[1].White;
            vWhitePlayerBlack.Count = player[1].Black;
            vBlackPlayerStone.Count = player[2].Stone;
            vBlackPlayerWhite.Count = player[2].White;
            vBlackPlayerBlack.Count = player[2].Black;
        }

        public int _CurrentPlayerID { get { return _currentPlayerID; } set { _currentPlayerID = value; }  }
        public BoneType _CurrentBoneType { get { return _currentBoneType; } set { _currentBoneType = value; } }

        public event EventHandler<eGameBeginsEventArgs> BeginGame;
        public event EventHandler<eSelectBoneEventArgs> BoneSelecting;
        public event EventHandler<eSelectCellEventArgs> CellSelected;
        public event EventHandler LineSelecting;
        public event EventHandler LineSelected;
        public event EventHandler UnDo;

        private void _BoneClick(object sender, EventArgs e)
        {
            eSelectBoneEventArgs E = new eSelectBoneEventArgs();
            E.Bone = (sender as vBone).BoneType;
            BoneSelecting(this, E);
        }

        public void ShowDice(iGame _game)
        {
            lbWhiteDice.Text = (_game.Player[1].Dice + 1).ToString() + " " + (_game.First_X_Second_Y ? "|" : "-");
            lbBlackDice.Text = (_game.First_X_Second_Y ? "-" : "|") + " " + (_game.Player[2].Dice + 1).ToString();
            lbWhiteDice.Visible = 
            lbBlackDice.Visible = (_game.CurrentGameStep == GameStep.SelectLine);
            lbWhiteDice.Enabled = (_game.CurrentPlayerType == PlayerType.White);
            lbBlackDice.Enabled = (_game.CurrentPlayerType == PlayerType.Black);

        }

        private void _MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    LineSelecting(this, EventArgs.Empty);
                    break;
                case MouseButtons.None:
                    break;
                case MouseButtons.Right:
                    LineSelected(this, EventArgs.Empty);
                    break;
                case MouseButtons.Middle:
                    break;
                case MouseButtons.XButton1:
                    break;
                case MouseButtons.XButton2:
                    break;
                default:
                    break;
            }
        }

        public void ShowGameStep(string _step)
        {
            tsGameStep.Text = _step;
        }

        public void ShowScore(int WhiteScore, int BlackScore)
        {
            lbWhitePoints.Text = WhiteScore.ToString();
            lbBlackPoints.Text = BlackScore.ToString();
        }
    }
}
