using System.Collections.Generic;

namespace FSDProje.Abstract
{
    public abstract class Rover : Compass
    {
        private int x;
        private int y;
        private char direction;
        private List<char> commands;
        private string name;

        public Rover(int x, int y, char direction, List<char> commands, string name)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            this.commands = commands;
            this.name = name;
        }

        internal bool Move()
        {
            foreach (var command in commands)
            {
                if (command.Equals('M'))
                {
                    Forward();
                }
                else if (command.Equals('L') || command.Equals('R'))
                {
                    Rotate(command);
                }
            }
            return true;
        }

        private void Forward()
        {
            switch (direction)
            {
                case 'N': y++; break;
                case 'E': x++; break;
                case 'S': y--; break;
                case 'W': x--; break;
            }

        }

        private void Backward() { }

        private void Rotate(char command)
        {
            direction = FindDirection(direction, command);
        }

        public string GetStatus()
        {
            return name + " X: " + x + " Y: " + y + " Direction: " + direction.ToString();
        }


        public abstract void StartRover();



    }
}
