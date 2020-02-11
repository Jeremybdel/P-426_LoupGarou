using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsSelection
{
    class Card
    {
        public Program.orientations orientation;

        public Card(Program.orientations orientation)
        {
            this.orientation = orientation;
        }
    }
}
