using System;
using System.Collections.Generic;
using System.Text;

namespace rover
{
    public class RoverActionMoveForward : IRoverAction
    {
        public void DoAction(Rover rover)
        {
            rover.GetCurrentState().MoveAhead(rover);
        }
    }
}
