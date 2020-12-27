using System;
using System.Collections.Generic;
using System.Text;

namespace rover
{
    public class RoverStateFactory
    {
        public static IRoverState GetRoverState(RoverDirection direction)
        {
            switch (direction)
            {
                case RoverDirection.North:
                    return new RoverStateFacingNorth();
                case RoverDirection.East:
                    return new RoverStateFacingEast();
                case RoverDirection.West:
                    return new RoverStateFacingWest();
                case RoverDirection.South:
                    return new RoverStateFacingSouth();
                default:
                    return null;
            }
        }
    }
}
