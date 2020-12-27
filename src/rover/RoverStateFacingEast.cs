using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace rover
{
    public class RoverStateFacingEast : IRoverState
    {
        public override void ChangeDirection(Rover rover, TurnDirection direction)
        {
            switch (direction)
            {
                case TurnDirection.Left:
                    rover.SetCurrentDirection(RoverDirection.North);
                    break;
                case TurnDirection.Right:
                    rover.SetCurrentDirection(RoverDirection.South); 
                    break;
            }
        }

        public override char GetFacingToDirection()
        {
            return 'E';
        }

        public override void MoveAhead(Rover rover)
        {
            //TODO: Check collision with another Rover
            int xCurrent = rover.GetCurrentLocation().X;

            if (++xCurrent <= rover.GetMaxLocation().X)
            {
                rover.SetCurrentLocation(new Point(xCurrent, rover.GetCurrentLocation().Y));
            }
            else
            {
                throw new InvalidOperationException("Can't move forward, dead end ahead");
            }
        }
    }
}
