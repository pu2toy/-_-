using System;
using System.Collections.Generic;
using System.Text;

namespace Task03
{
    public class ReturnToBaseCommand : ICommand
    {
        private RobotVacuum _robot;

        public ReturnToBaseCommand(RobotVacuum robot)
        {
            _robot = robot;
        }

        public void Execute()
        {
            _robot.ReturnToBase();
        }
    }
}
