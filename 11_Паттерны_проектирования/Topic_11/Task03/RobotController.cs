using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    public class RobotController
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}
