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
                    {
                        return new RoverStateFacingNorth();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
