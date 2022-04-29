using System.Collections.Generic;

namespace FSDProje.Abstract
{
    public abstract class Compass
    {
        private readonly List<char> directions = new List<char> { 'N', 'E', 'S', 'W' };

        public char FindDirection(char lastDirection, char movement)
        {
            char newDirection;
            int index = directions.IndexOf(lastDirection);
            switch (movement)
            {
                case 'L':
                    index--;
                    if (index == -1) { index = 3; }
                    break;
                case 'R':
                    index++;
                    if (index == 4) { index = 0; }
                    break;
            }
            newDirection = directions[index];
            return newDirection;
        }
    }
}
