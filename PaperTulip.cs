using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class PaperTulip : ITulip
    {
        public string Flower { get; set; }
        public string Proportions { get; set; }
        public string Colour { get; set; }

        public PaperTulip()
        {
            Flower = "Tulip";
            Proportions = "Small";
            Colour = "Yellow";
        }
        public ITulip Clone()
        {
            return (ITulip)MemberwiseClone();
        }

        public string GetProductDetails()
        {
            return string.Format("Flower: {0}\nProportions: {1}\nColour: {2}\n", Flower, Proportions, Colour);
        }
    }
}
