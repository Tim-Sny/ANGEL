using AngelModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BonesAndStones
{
    public class cPresenter
    {
        private readonly iGame _game;
        private readonly iView _view;
        private readonly iMessages _mess;

        private cPlayer _CurrentPlayer
        {
            get
            {
                return _game.Player[(int)_game.CurrentPlayerType];
            }
            set
            {
                _game.CurrentPlayerType = value.Type;
            }
        }

        private GameStep _CurrentGameStep
        {
            get { return _game.CurrentGameStep; }
            set { _game.CurrentGameStep = value; }
        }

        private BoneType _currentBoneType = BoneType.White;
        public BoneType _CurrentBoneType
        {
            get { return _currentBoneType; }
            set
            {
                _currentBoneType = value;
                if(_CurrentGameStep == GameStep.MakeMove)
                    _view.SetCursor((int)_currentBoneType);
                else
                    _view.SetCursor(0);
            }
        }

        public cPresenter(iGame game, iView view, iMessages mess)
        {
            _game = game;
            _view = view;
            _mess = mess;

            _view.BeginGame     += _view_BeginGame;
            _view.BoneSelecting += _view_BoneSelecting;
            _view.CellSelected  += _view_CellSelected;
            _view.LineSelecting += _view_LineSelecting;
            _view.LineSelected  += _view_LineSelected;
            _view.UnDo          += _view_UnDo;

            _view.FillMap(_game.Map);
            _view.ShowAllStones(_game.Map, _game.Player);

        }

        private void _view_LineSelected(object sender, EventArgs e)
        {
            _view.ShowDice(_game);
            _CurrentGameStep = GameStep.StoneFalls;
            _GameLoop();
        }

        private void _view_LineSelecting(object sender, EventArgs e)
        {
            _game.First_X_Second_Y = !_game.First_X_Second_Y;
            _view.ShowDice(_game);
        }

        private void _view_UnDo(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _view_CellSelected(object sender, eSelectCellEventArgs e)
        {
            if(_CurrentGameStep == GameStep.MakeMove)
            {
                _game.Move(_CurrentBoneType, _CurrentPlayer, _game.Map.Cells[e.X, e.Y]);
                _view.ShowAllStones(_game.Map, _game.Player);
                _CurrentGameStep = GameStep.SelectLine;
                _GameLoop();
            }
        }

        private void _view_StoneFalls()
        {
            if (_game.First_X_Second_Y)
            {
                _game.Move(BoneType.Stone, _game.Player[(int)PlayerType.Cup], _game.Map.Cells[_game.Player[1].Dice, _game.Player[2].Dice]);
            }
            else
            {
                _game.Move(BoneType.Stone, _game.Player[(int)PlayerType.Cup], _game.Map.Cells[_game.Player[2].Dice, _game.Player[1].Dice]);
            }

            _view.ShowAllStones(_game.Map, _game.Player);
            //_view.ShowScore(_game.Map.GetMaxPoints(BoneType.White), _game.Map.GetMaxPoints(BoneType.Black));
            _CurrentGameStep = GameStep.MakeMove;
            _GameLoop();
        }

        private void _view_BoneSelecting(object sender, eSelectBoneEventArgs e)
        {
            _CurrentBoneType = OppositeBone(_CurrentBoneType);
        }

        private void _view_BeginGame(object sender, eGameBeginsEventArgs e)
        {
            _game.BeginGame(e.N);
            //Thread.Sleep(2000);
            _game.Move(BoneType.White, _game.Player[0], _game.Player[1]);
            _game.Move(BoneType.Black, _game.Player[0], _game.Player[2]);
            _CurrentPlayer = _game.Player[1];
            _GameLoop();
        }

        private BoneType GetCurrentBone(cPlayer _Player)
        {
            PlayerType _PlayerType;
            BoneType _BoneType;

            _PlayerType = _Player.Type;

            _BoneType = ((from x in _Player.Bones where x.Type == (BoneType)(int)_Player.Type select x).First()).Type;

            if (_BoneType == null)
            {
                _BoneType = ((from x in _Player.Bones where x.Type == OppositeBone((BoneType)(int)_Player.Type) select x).First()).Type;
            }

            if (_BoneType == null)
            {
                _mess.ShowMessage("У игрока нет камней!");
            }
            return _BoneType;
        }
        private BoneType OppositeBone(BoneType _BoneType)
        {
            BoneType _res = BoneType.Stone;
            if (_BoneType == BoneType.White) _res = BoneType.Black;
            if (_BoneType == BoneType.Black) _res = BoneType.White;
            return _res; 
        }
        private PlayerType OppositePlayerType(PlayerType _PlayerType)
        {
            PlayerType _res = PlayerType.Cup;
            if (_PlayerType == PlayerType.White) _res = PlayerType.Black;
            if (_PlayerType == PlayerType.Black) _res = PlayerType.White;
            return _res;
        }
        private cPlayer OppositePlayer(cPlayer _Player)
        {
            cPlayer _res = _game.Player[0];
            if (_Player.Type == PlayerType.White) _res = _game.Player[2];
            if (_Player.Type == PlayerType.Black) _res = _game.Player[1];
            return _res;
        }

        private void _GameLoop()
        {
            _view.SetCursor(0);
            switch (_CurrentGameStep)
            {
                case GameStep.MakeMove:
                    if (_CurrentPlayer.Type == PlayerType.White) _view.ShowGameStep("Ход БЕЛОГО игрока...");
                    if (_CurrentPlayer.Type == PlayerType.Black) _view.ShowGameStep("Ход ЧЁРНОГО игрока...");
                    _game.First_X_Second_Y = true;
                    _CurrentBoneType = GetCurrentBone(_CurrentPlayer);
                    _view.ShowScore(_game.Map.GetMaxPoints(BoneType.White), _game.Map.GetMaxPoints(BoneType.Black));
                    break;
                case GameStep.SelectLine:
                    _game.Player[1].Dice = cSchool.RND(6); //Thread.Sleep(123);
                    if (_CurrentPlayer.Type == PlayerType.White) _view.ShowGameStep("БЕЛЫЙ выбирает линию...");
                    if (_CurrentPlayer.Type == PlayerType.Black) _view.ShowGameStep("ЧЁРНЫЙ выбирает линию...");
                    _game.Player[2].Dice = cSchool.RND(6);
                    break;
                case GameStep.StoneFalls:
                    _CurrentPlayer = OppositePlayer(_CurrentPlayer);
                    _CurrentBoneType = GetCurrentBone(_CurrentPlayer);
                    _view_StoneFalls();
                    //_view.ShowScore(_game.Map.GetMaxPoints(BoneType.White), _game.Map.GetMaxPoints(BoneType.Black));
                    break;
                default:
                    break;
            }

            _view.ShowAllStones(_game.Map, _game.Player);
            _view.ShowDice(_game);
        }
    }
}
