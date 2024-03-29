﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf2.Command.Base;

namespace Wpf2.Command
{
    internal class LiambdaCommand : CommandBase
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecut;
        public LiambdaCommand(Action<object> Execute, Func<object,bool> CanExecut = null)
        {
            _Execute = Execute?? throw new ArgumentNullException(nameof(Execute));
            _CanExecut = CanExecut;
        }

        public override bool CanExecute(object parameter) => _CanExecut?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Execute(parameter);

        
    }
}
