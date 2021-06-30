using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    interface ITulip
    {
        string Flower { get; set; }
        string Proportions { get; set; }
        string Colour { get; set; }
        string GetProductDetails();
        ITulip Clone();

    }
}
