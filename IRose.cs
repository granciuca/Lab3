using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    interface IRose
    {
        string Flower { get; set; }
        string Proportions { get; set; }
        string Colour { get; set; }
        IRose Clone();
        string GetProductDetails();
    }
}
