using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class FlowerClient
    {
        ITulip tulip;
        IRose rose;

        public FlowerClient(IFlower factory) {

            tulip = factory.GetTulip();
            rose = factory.GetRose();
        }

        public string GetRoseProductDetails() {
            return rose.GetProductDetails();
        }

        public string GetTulipProductDetails()
        {
            return tulip.GetProductDetails();
        }

        public ITulip CloneTulip() {
            return tulip.Clone();
        }

        public IRose CloneRose() {
            return rose.Clone();
        }

    }
}
