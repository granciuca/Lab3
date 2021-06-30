using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class FilmFlower : IFlower
    {
        public ITulip GetTulip()
        {
            return new FilmTulip();
        }

        public IRose GetRose() {
            return new FilmRose();
        }
    }
}
