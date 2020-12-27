using System;
using System.Collections.Generic;
using System.Text;

namespace rover
{
    public class RoverActionTurnRight : IRoverAction
    {
        public void DoAction(Rover rover)
        {
            rover.GetCurrentState().ChangeDirection(rover, TurnDirection.Right);
        }
    }
}
