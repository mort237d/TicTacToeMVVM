using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TicTacToeMVVM.Commands;
using TicTacToeMVVM.Models;
using TicTacToeMVVM.Properties;

namespace TicTacToeMVVM
{
    public class TicTacToeViewModel
    {
        private string game = "TicTacToe";
        private Bitmap image = new Bitmap(Resources.jpg);

        private TicTacToe _ticTacToe;

        public string Game
        {
            get { return game; }
            set { game = value; }
        }

        public Bitmap Image1
        {
            get { return image; }
            set { image = value; }
        }

        public static IList<string> m_type;
        public TicTacToeViewModel()
        {
            TacToe = new TicTacToe("O");
            UpdateCommand = new TicTacToeUpdateCommand(this);
        }

        public ICommand UpdateCommand
        {
            get;
            private set;
        }

        public TicTacToe TacToe
        {
            get { return _ticTacToe; }
            set { _ticTacToe = value; }
        }

        public void ChangeType()
        {
            if (TacToe.Tile1 == " ")
            {
                TacToe.Tile1 = TacToe.Type;
            }
            if (TacToe.Type == "X")
            {
                TacToe.Type = "O";
            }
            else
            {
                TacToe.Type = "X";
            }
        }
    }
}
