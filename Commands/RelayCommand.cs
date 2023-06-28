using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrencyWPFApp.Commands
{
	public class RelayCommand<T> : ICommand
	{
		private readonly Action<T> _execute;
		private readonly Func<T, bool> _canExecute;
		public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
		{
			_execute = execute;
			_canExecute = canExecute;
		}
		public bool CanExecute(object parameter)
		{
			if (parameter is T castParameter)
			{
				return _canExecute == null || _canExecute(castParameter);
			}

			return false;
		}
		public void Execute(object parameter)
		{
			if (parameter is T castParameter)
			{
				_execute(castParameter);
			}
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
	}
}
