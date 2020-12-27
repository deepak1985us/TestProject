using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace rover
{
    public class RoverStateFacingNorth : IRoverState
    {
        public override void ChangeDirection(Rover rover, TurnDirection direction)
        {
            switch (direction)
            {
                case TurnDirection.Left:
                    rover.SetCurrentDirection(RoverDirection.West);
                    break;
                case TurnDirection.Right:
                    rover.SetCurrentDirection(RoverDirection.East); 
                    break;
            }
        }

        public override char GetFacingToDirection()
        {
            return 'N';
        }

        public override void MoveAhead(Rover rover)
        {
            //TODO: Check collision with another Rover
            int yCurrent = rover.GetCurrentLocation().Y;

            if (++yCurrent <= rover.GetMaxLocation().Y)
            {
                rover.SetCurrentLocation(new Point(rover.GetCurrentLocation().X, yCurrent));
            }
            else
            {
                throw new InvalidOperationException("Can't move forward, dead end ahead");
            }
        }
    }
}
