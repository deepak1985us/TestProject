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

        public Rover(int xMax, int yMax, int xPosition, int yPosition, string direction)
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
        private void SetCurrentDirection(string direction)
        {
            switch (direction)
            {
                case "N":
                    this.SetCurrentDirection(RoverDirection.North);
                    break;
                case "E":
                    this.SetCurrentDirection(RoverDirection.East);
                    break;
                case "W":
                    this.SetCurrentDirection(RoverDirection.West);
                    break;
                case "S":
                    this.SetCurrentDirection(RoverDirection.South);
                    break;
                default:
                    throw new InvalidCastException();
            }
        }

        public IRoverState GetCurrentState()
        {
            return this.state;
        }

        public IRoverAction GetActionToDo()
        {
            return this.actionToDo;
        }

        public void DoAction(char actionToDo)
        {
            this.actionToDo = RoverActionFactory.GetRoverAction(actionToDo);
            state.DoAction(this);
        }

        public string GetCurrentCoordinates()
        {
            return currentLocation.X.ToString() + " " + currentLocation.Y.ToString() + " " + state.GetFacingToDirection();
        }
    }
}
