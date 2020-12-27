using System;
using System.Collections.Generic;
using System.Text;

namespace rover
{
    public class RoverActionFactory
    {
        public static IRoverAction GetRoverAction(string actionToDo)
        {
            switch (actionToDo)
            {
                case "M":
                    {
                        return new RoverActionMoveForward();
                    }
                case "R":
                    {
                        return new RoverActionTurnRight();
                    }
                case "L":
                    {
                        return new RoverActionTurnLeft();
                    }
                default:
                    {
                        return null;
                    }
            }
        }
    }
}
