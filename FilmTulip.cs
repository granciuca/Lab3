using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class FilmTulip : ITulip
    {
        public string Flower { get; set; }
        public string Proportions { get; set; }
        public string Colour { get; set; }

        public FilmTulip()
        {
            Flower = "Tulip";
            Proportions = "Big";
            Colour = "Red";
        }
        public ITulip Clone()
        {
            return (ITulip)MemberwiseClone();
        }

        public string GetDetails() {
            return string.Format("{0} - {1} - {2}wpm", Flower, Proportions, Colour);
        }

        public string GetProductDetails()
        {
            return string.Format("Flower: {0}\nProportions: {1}\nColour: {2}\n", Flower, Proportions, Colour);
        }
    }
}
