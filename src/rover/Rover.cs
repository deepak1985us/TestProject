using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace rover
{
    public class Rover
    {
        private Point currentLocation = new Point(0, 0);
        private Point maxLocation = new Point(0, 0);
        private IRoverState state;
        private IRoverAction actionToDo;

        public Rover(int xMax, int yMax, int xPosition, int yPosition, RoverDirection direction)
        {
            this.currentLocation = new Point(xPosition, yPosition);
            this.maxLocation = new Point(xMax, yMax);
            SetCurrentDirection(direction);
        }

        public Point GetCurrentLocation()
        {
            return this.currentLocation;
        }

        public Point GetMaxLocation()
        {
            return this.maxLocation;
        }

        public void SetCurrentLocation(Point newLocation)
        {
            this.currentLocation = newLocation;
        }

        public void SetCurrentDirection(RoverDirection newDirection)
        {
            this.state = RoverStateFactory.GetRoverState(newDirection);
        }

        public IRoverState GetCurrentState()
        {
            return this.state;
        }

        public IRoverAction GetActionToDo()
        {
            return this.actionToDo;
        }

        public void DoAction(string actionToDo)
        {
            this.actionToDo = RoverActionFactory.GetRoverAction(actionToDo);
            state.DoAction(this);
        }
    }
}
