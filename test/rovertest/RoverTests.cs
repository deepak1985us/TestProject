using System;
using Xunit;
using rover;

namespace rovertest
{
    public class RoverTests
    {
        [Theory]
        [InlineData(new string[] { "5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM" }, new string[] { "1 3 N", "5 1 E" })]
        public void TestRover1(string[] inputStrings, string[] expectedOutputs)
        {
            string[] maxCoordinate = inputStrings[0].Split(" ");
            int xMax = Int32.Parse(maxCoordinate[0]);
            int yMax = Int32.Parse(maxCoordinate[1]);

            int totRovers = (inputStrings.Length - 1) / 2;
            int passedRovers = 0;

            for(int iRover = 0; iRover < totRovers; iRover++)
            {
                string[] initLocation = inputStrings[(iRover * 2) + 1].Split(" ");
                int xStart = Int32.Parse(initLocation[0]);
                int yStart = Int32.Parse(initLocation[1]);
                Rover rover = new Rover(xMax, yMax, xStart, yStart, initLocation[2]);

                char[] strCommands = inputStrings[(iRover * 2) + 2].ToCharArray();

                foreach(char cmd in strCommands)
                {
                    rover.DoAction(cmd);
                }

                string actualResult = rover.GetCurrentCoordinates();
                if (actualResult.Equals(expectedOutputs[iRover])) passedRovers++;
            }

            Assert.Equal(totRovers, passedRovers);
        }
    }
}
