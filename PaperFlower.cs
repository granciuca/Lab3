using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class PaperFlower : IFlower
    {
        public ITulip GetTulip()
        {
            return new PaperTulip();
        }

        public IRose GetRose()
        {
            return new PaperRose();
        }

    }
}
