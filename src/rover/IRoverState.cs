using System;
using System.Collections.Generic;
using System.Text;

namespace rover
{
    public abstract class IRoverState
    {
        public abstract void MoveAhead(Rover rover);
        public abstract void ChangeDirection(Rover rover, TurnDirection direction);

        public void DoAction(Rover rover)
        {
            rover.GetActionToDo().DoAction(rover);
        }
    }
}
