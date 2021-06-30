using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class FilmRose : IRose
    {
        public string Flower { get; set; }
        public string Proportions { get; set; }
        public string Colour { get; set; }
        public FilmRose() {
            Flower = "Rose";
            Proportions = "Big";
            Colour = "White";
        }

        public IRose Clone() {
            return (IRose)MemberwiseClone();
        }
        public string GetProductDetails() {
            return string.Format("Flower: {0}\nProportions: {1}\nColour: {2}\n", Flower, Proportions, Colour);
        }

    }
}
