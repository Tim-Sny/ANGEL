using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BonesAndStones
{
    public interface iGame
    {
        cMap Map { get; }
        cPlayer[] Player { get; }

        PlayerType CurrentPlayerType { get; set; }
        PlayerType OppositePlayerType(PlayerType _playerType);
        GameStep CurrentGameStep { get; set; }

        bool First_X_Second_Y { get; set; }

        void BeginGame(int N);
        void Move(BoneType _bone, cPlayer _from, cCell   _to);
        void Move(BoneType _bone, cPlayer _from, cPlayer _to);

        //Надо ли в интерфейс?
        //bool Move(BoneType _bone, List<Bone> _from, List<Bone> _to);
        //bool MoveAll(BoneType? _bone, List<Bone> _from, List<Bone> _to);
        //bool MoveAll(List<Bone> _from, List<Bone> _to);

        event EventHandler<eMoveEventArgs> MoveDone;
    }

    public enum CellType : int
    {
        Any   = 0,
        White = 1,
        Black = 2
    }
    public enum BoneType : int
    {
        Stone = 0,
        White = 1,
        Black = 2
    }
    public enum PlayerType : int
    {
        Cup   = 0,
        White = 1,
        Black = 2
    }

    public class Bone
    {
        public BoneType Type;
    }

    public enum GameStep : int
    {
        MakeMove    = 0,
        SelectLine  = 1,
        StoneFalls  = 2
    }

    //public class cCup
    //{
    //    public List<Bone> Bones;
    //    public int White
    //    {
    //        get { return (from x in Bones where x.Type == BoneType.White select x).Count(); }
    //    }
    //    public int Black
    //    {
    //        get { return (from x in Bones where x.Type == BoneType.Black select x).Count(); }
    //    }
    //}

    public class cCell
    {
        public int X, Y, N;
        public CellType Type;
        public int Points;
        public int Same;
        public int Other;
        public List<Bone> Bones = new List<Bone>();
        public int White
        {
            get { return (from x in this.Bones where x.Type == BoneType.White select x).Count(); }
        }
        public int Black
        {
            get { return (from x in this.Bones where x.Type == BoneType.Black select x).Count(); }
        }
        public int Stone
        {
            get { return (from x in this.Bones where x.Type == BoneType.Stone select x).Count(); }
        }
        public cCell(CellType _type, int _points, int _same, int _other) 
        {
            Type   = _type;
            Points = _points;;
            Same = _same; ;
            Other = _other; ;
        }
        public cCell(int _x, int _y, int _n, CellType _type, int _points, int _same, int _other)
        {
            X = _x;
            Y = _y;
            N = _n;
            Type = _type;
            Points = _points; ;
            Same = _same; ;
            Other = _other; ;
        }
        public int GetPoints(BoneType _boneType)
        {
            int _res = 0;
            _res = Points * (from x in Bones where x.Type == _boneType select x).Count();
            return _res;
        }
        public int GetBones(BoneType _boneType, PlayerType _playerType)
        {
            int _res = 0;
            if (Type == CellType.Any)
                _res = ((int)_playerType == (int)_boneType) ? Same : Other;
            else
                _res = ((int)_playerType == (int)Type) ? Same : Other;

            return _res;
        }
        public BoneType? GetOwnerBoneType()
        {
            BoneType? res;
            try
            {
                res = ((from x in Bones select x).First()).Type;
            }
            catch (Exception)
            {
                res = null;
            }
            return res;
        }
        public PlayerType? GetOwnerPlayerType()
        {
            PlayerType? res;
            try
            {
                res = (PlayerType)((int)(from x in Bones select x).First().Type);
            }
            catch (Exception)
            {
                res = null;
            }
            return res;
        }

    }

    public class cMap
    {
        public cCell[,] Cells;
        public List<Bone> Bones;
        public cMap()
        {
            Cells = new cCell[6, 6] {
            {new cCell(0, 0,  0, CellType.White, 7, 4, 3), new cCell(1, 0,  1, CellType.Any  , 1, 1, 0), new cCell(2, 0,  2, CellType.Black, 3, 3, 2), new cCell(3, 0,  3, CellType.Black, 3, 3, 2), new cCell(4, 0,  4, CellType.Any  , 1, 1, 0), new cCell(5, 0,  5, CellType.White, 7, 4, 3)},
            {new cCell(0, 1,  6, CellType.Any  , 1, 1, 0), new cCell(1, 1,  7, CellType.White, 5, 3, 2), new cCell(2, 1,  8, CellType.Any  , 1, 1, 0), new cCell(3, 1,  9, CellType.Any  , 1, 1, 0), new cCell(4, 1, 10, CellType.White, 5, 3, 2), new cCell(5, 1, 11, CellType.Any  , 1, 1, 0)},
            {new cCell(0, 2, 12, CellType.Any  , 1, 1, 0), new cCell(1, 2, 13, CellType.Any  , 1, 1, 0), new cCell(2, 2, 14, CellType.Any  , 3, 2, 1), new cCell(3, 2, 15, CellType.Any  , 3, 2, 1), new cCell(4, 2, 16, CellType.Any  , 1, 1, 0), new cCell(5, 2, 17, CellType.White, 5, 3, 2)},
            {new cCell(0, 3, 18, CellType.Black, 5, 3, 2), new cCell(1, 3, 19, CellType.Any  , 1, 1, 0), new cCell(2, 3, 20, CellType.Any  , 3, 2, 1), new cCell(3, 3, 21, CellType.Any  , 3, 2, 1), new cCell(4, 3, 22, CellType.Any  , 1, 1, 0), new cCell(5, 3, 23, CellType.Any  , 1, 1, 0)},
            {new cCell(0, 4, 24, CellType.Any  , 1, 1, 0), new cCell(1, 4, 25, CellType.Black, 5, 3, 2), new cCell(2, 4, 26, CellType.Any  , 1, 1, 0), new cCell(3, 4, 27, CellType.Any  , 1, 1, 0), new cCell(4, 4, 28, CellType.Black, 5, 3, 2), new cCell(5, 4, 29, CellType.Any  , 1, 1, 0)},
            {new cCell(0, 5, 30, CellType.Black, 7, 4, 3), new cCell(1, 5, 31, CellType.Any  , 1, 1, 0), new cCell(2, 5, 32, CellType.White, 3, 3, 2), new cCell(3, 5, 33, CellType.White, 3, 3, 2), new cCell(4, 5, 34, CellType.Any  , 1, 1, 0), new cCell(5, 5, 35, CellType.Black, 7, 4, 3)}};

            int x, y; 
            for (int i = 0; i < 36; i++)
            {
                x = i % 6;
                y = i / 6;
                Cells[x, y].X = x;
                Cells[x, y].Y = y;
                Cells[x, y].N = i;
            }
        }

        public void Clear()
        {
            for (int x = 0; x < 6; x++)
                for (int y = 0; y < 6; y++)
                    Cells[x, y].Bones.Clear();
        }

        public int GetMaxPoints(BoneType _BoneType)
        {
            int res = 0;
            int sum = 0;
            int _x, _y;

            for (int x = 0; x < 6; x++)
                for (int y = 0; y < 6; y++)
                {
                    _x = x;
                    _y = y;
                    sum = 0;
                    if (Cells[_x, _y].GetOwnerBoneType() == _BoneType)
                        for (int t = 0; t < 2; t++)
                        {
                            while ((_x < 6) && (_y < 6) && (Cells[_x, _y].GetOwnerBoneType() == _BoneType))
                            {
                                sum += Cells[_x, _y].GetPoints(_BoneType);
                                if (t == 0) _x++;
                                else _y++;
                            }

                        }
                    res = (sum > res) ? sum : res;
                }

            return res;
        }

    }

    public class cPlayer
    {
        public PlayerType Type;
        public int Points;
        public int Dice;
        public List<Bone> Bones = new List<Bone>();

        public int White
        {
            get { return (from x in this.Bones where x.Type == BoneType.White select x).Count(); }
        }
        public int Black
        {
            get { return (from x in this.Bones where x.Type == BoneType.Black select x).Count(); }
        }
        public int Stone
        {
            get { return (from x in this.Bones where x.Type == BoneType.Stone select x).Count(); }
        }

    }

    public class cGame : iGame
    {
        public cMap Map { get; set; }
        public cPlayer[] Player { get; set; }

        public PlayerType CurrentPlayerType { get; set; }
        public GameStep CurrentGameStep { get; set; }

        public bool First_X_Second_Y { get; set; } = true;

        public cGame()
        {
            Map = new cMap();
            //Cup = new cCup();

            Player = new cPlayer[3] { new cPlayer(), new cPlayer(), new cPlayer() };
            Player[0].Type = PlayerType.Cup;
            Player[1].Type = PlayerType.White;
            Player[2].Type = PlayerType.Black;
        }

        public event EventHandler<eMoveEventArgs> MoveDone;

        public void BeginGame(int N)
        {
            Player[0].Bones.Clear();
            Player[1].Bones.Clear();
            Player[2].Bones.Clear();
            Map.Clear();

            //Наполнение чаши камнями... 
            for (int i = 0; i < N; i++)
            {
                Player[0].Bones.Add(new Bone() { Type = BoneType.White });
                Player[0].Bones.Add(new Bone() { Type = BoneType.Black });
                Player[0].Bones.Add(new Bone() { Type = BoneType.Stone });
            }
        }

        public void Move(BoneType _bone, cPlayer _from, cCell _to)
        {
            switch (_to.GetOwnerBoneType())     
            {
                case BoneType.Black:
                case BoneType.White:
                case null:
                default:
                    if (_bone == BoneType.Stone)
                    {
                        MoveAll(_to.Bones, Player[(int)OppositePlayerType(CurrentPlayerType)].Bones);
                        Move(_bone, _from.Bones, _to.Bones);
                    }
                    else
                    {
                        Move(_bone, _from.Bones, _to.Bones);
                        int bonus = _to.GetBones(_bone, _from.Type);
                        int i = 0;
                        while (i < bonus && Player[0].Stone > 0 && Move(_bone, Player[0].Bones, _from.Bones)) i++; 
                        //{
                        //    );
                        //    i++;
                        //}
                    }

                    break;
                case BoneType.Stone:
                    if (_bone == BoneType.Stone)
                    {
                        while (_to.Bones.Count > 0 && Move(BoneType.Stone, _to.Bones, Player[0].Bones));
                        //{
                        //    ;
                        //}
                    }
                    break;
            }
        }

        public void Move(BoneType _bone, cPlayer _from, cPlayer _to)
        {
            Move(_bone, _from.Bones, _to.Bones);
        }

        public bool Move(BoneType _bone, List<Bone> _from, List<Bone> _to)
        {
            var _currentBone = (from x in _from where x.Type == _bone select x).FirstOrDefault();

            if (_currentBone != null)
            {
                _from.Remove((Bone)_currentBone);
                _to.Add((Bone)_currentBone);
                return true;
            }
            else
            {
                //MessageBox.Show("Нет камней указанного типа!");
                return false;
            }
        }
        public bool MoveAll(BoneType? _bone, List<Bone> _from, List<Bone> _to)
        {
            List<Bone> _currentBones;
            if (_bone == null)
            {
                if(_from.Count > 0)
                {
                    _to.AddRange(_from);
                    _from.Clear();
                    return true;
                }
                else
                {
                    //MessageBox.Show("Нет камней указанного типа!");
                    return false;
                }
            }
            else
            {
                _currentBones = (from x in _from where x.Type == _bone select x).ToList();
                if (_currentBones.Count > 0)
                {
                    _to.AddRange(_currentBones);
                    _from.RemoveAll(Bone => Bone.Type == _bone);
                    return true;
                }
                else
                {
                    //MessageBox.Show("Нет камней указанного типа!");
                    return false;
                }
            }
        }
        public bool MoveAll(List<Bone> _from, List<Bone> _to)
        {
            if (_from.Count > 0)
            {
                _to.AddRange(_from);
                _from.Clear();
                return true;
            }
            else
            {
                //MessageBox.Show("Нет камней указанного типа!");
                return false;
            }
        }

        public PlayerType OppositePlayerType(PlayerType _playerType)
        {
            PlayerType _res = PlayerType.Cup;
            if (_playerType == PlayerType.White) _res = PlayerType.Black;
            if (_playerType == PlayerType.Black) _res = PlayerType.White;
            return _res;
        }
    }

    public class eMoveEventArgs : EventArgs
    {
        public cPlayer player { get; set; }
        public Bone bone { get; set; }
        public cCell cell { get; set; }
    }

    public class eSelectBoneEventArgs : EventArgs
    {
        public BoneType Bone { get; set; }
    }

    public class eSelectCellEventArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int N { get; set; }
    }
    
    public class eGameBeginsEventArgs : EventArgs
    {
        public int N { get; set; }
    }

    public class eSelectLineEventArgs : EventArgs
    {
        public bool First_X_Second_Y { get; set; }
    }
    
}
