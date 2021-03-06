﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TicTacToeMVVM.Annotations;

namespace TicTacToeMVVM.Models
{
    public class TicTacToe : INotifyPropertyChanged
    {
        private string _type;

        private string _tile1, _tile2, _tile3, _tile4, _tile5, _tile6, _tile7, _tile8 , _tile9 = String.Empty;

        public TicTacToe(string type)
        {
            Type = type;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value; 
                OnPropertyChanged("Type");
            }
        }

        public string Tile1
        {
            get { return _tile1; }
            set
            {
                _tile1 = value;
                OnPropertyChanged("Tile1");
            }
        }

        public string Tile2
        {
            get { return _tile2; }
            set
            {
                _tile2 = value;
                OnPropertyChanged("Tile2");
            }
        }

        public string Tile3
        {
            get { return _tile3; }
            set
            {
                _tile3 = value;
                OnPropertyChanged("Tile3");
            }
        }

        public string Tile4
        {
            get { return _tile4; }
            set
            {
                _tile4 = value;
                OnPropertyChanged("Tile4");
            }
        }

        public string Tile5
        {
            get { return _tile5; }
            set
            {
                _tile5 = value;
                OnPropertyChanged("Tile5");
            }
        }

        public string Tile6
        {
            get { return _tile6; }
            set
            {
                _tile6 = value;
                OnPropertyChanged("Tile6");
            }
        }

        public string Tile7
        {
            get { return _tile7; }
            set
            {
                _tile7 = value;
                OnPropertyChanged("Tile7");
            }
        }

        public string Tile8
        {
            get { return _tile8; }
            set
            {
                _tile8 = value;
                OnPropertyChanged("Tile8");
            }
        }

        public string Tile9
        {
            get { return _tile9; }
            set
            {
                _tile9 = value;
                OnPropertyChanged("Tile9");
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
