using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSDProje
{
    public class Map
    {
        public Map(int with, int height)
        {
            this.With = with;
            this.Height = height;
        }
        public int With { get; set; }
        public int Height { get; set; }
    }
}
