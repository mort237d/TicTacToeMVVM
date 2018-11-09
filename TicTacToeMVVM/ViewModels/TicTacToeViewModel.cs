using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
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
            TacToe = new TicTacToe("X");
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

        public void ChangeType(object param)
        {
            if (param.Equals("Tile1") && TacToe.Tile1 != "X" && TacToe.Tile1 != "O")
            {
                TacToe.Tile1 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile2") && TacToe.Tile2 != "X" && TacToe.Tile2 != "O")
            {
                TacToe.Tile2 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile3") && TacToe.Tile3 != "X" && TacToe.Tile3 != "O")
            {
                TacToe.Tile3 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile4") && TacToe.Tile4 != "X" && TacToe.Tile4 != "O")
            {
                TacToe.Tile4 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile5") && TacToe.Tile5 != "X" && TacToe.Tile5 != "O")
            {
                TacToe.Tile5 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile6") && TacToe.Tile6 != "X" && TacToe.Tile6 != "O")
            {
                TacToe.Tile6 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile7") && TacToe.Tile7 != "X" && TacToe.Tile7 != "O")
            {
                TacToe.Tile7 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile8") && TacToe.Tile8 != "X" && TacToe.Tile8 != "O")
            {
                TacToe.Tile8 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            else if (param.Equals("Tile9") && TacToe.Tile9 != "X" && TacToe.Tile9 != "O")
            {
                TacToe.Tile9 = TacToe.Type;
                if (TacToe.Type == "X") TacToe.Type = "O";
                else TacToe.Type = "X";
            }
            CheckForWinner();
        }

        public void CheckForWinner()
        {
            if (TacToe.Tile1 != null && TacToe.Tile1 == TacToe.Tile2 && TacToe.Tile2 == TacToe.Tile3) ResetGame();
            else if (TacToe.Tile4 != null && TacToe.Tile4 == TacToe.Tile5 && TacToe.Tile5 == TacToe.Tile6) ResetGame();
            else if (TacToe.Tile7 != null && TacToe.Tile7 == TacToe.Tile8 && TacToe.Tile8 == TacToe.Tile9) ResetGame();

            if (TacToe.Tile1 != null && TacToe.Tile1 == TacToe.Tile4 && TacToe.Tile4 == TacToe.Tile7) ResetGame();
            else if (TacToe.Tile2 != null && TacToe.Tile2 == TacToe.Tile5 && TacToe.Tile5 == TacToe.Tile8) ResetGame();
            else if (TacToe.Tile3 != null && TacToe.Tile3 == TacToe.Tile6 && TacToe.Tile6 == TacToe.Tile9) ResetGame();

            if (TacToe.Tile1 != null && TacToe.Tile1 == TacToe.Tile5 && TacToe.Tile5 == TacToe.Tile9) ResetGame();
            else if (TacToe.Tile7 != null && TacToe.Tile7 == TacToe.Tile5 && TacToe.Tile5 == TacToe.Tile3) ResetGame();
        }

        public void ResetGame()
        {
            MessageBox.Show("Game over\nNew Game begins");
            TacToe.Tile1 = TacToe.Tile2 = TacToe.Tile3 = TacToe.Tile4 = TacToe.Tile5 = TacToe.Tile6 = TacToe.Tile7 = TacToe.Tile8 = TacToe.Tile9 = null;
            TacToe.Type = "X";
        }

    }
}
