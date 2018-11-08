using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TicTacToeMVVM.Commands
{
    internal class TicTacToeUpdateCommand : ICommand
    {
        private TicTacToeViewModel _tac;
        public TicTacToeUpdateCommand(TicTacToeViewModel Tac)
        {
            this._tac = Tac;
        }
            
        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        public void Execute(object parameter)
        {
            _tac.ChangeType();
        }

        #endregion
    }
}
