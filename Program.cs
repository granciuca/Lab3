using System;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            IFlower paperflower = new PaperFlower();
            FlowerClient paperFlowerClient = new FlowerClient(paperflower);

            Console.WriteLine("********* Paper flowers **********");
            Console.WriteLine(" - Tulip -");
            Console.WriteLine(paperFlowerClient.GetTulipProductDetails());
            Console.WriteLine(" - Rose -");
            Console.WriteLine(paperFlowerClient.GetRoseProductDetails());
            
            Console.WriteLine(" --- Cloned Paper Rose ---");
            IRose newPaperRose = paperFlowerClient.CloneRose();
            newPaperRose.Flower = "Rose";
            Console.WriteLine(newPaperRose.GetProductDetails());

            IFlower filmFlower = new FilmFlower();
            FlowerClient filmFlowerClient = new FlowerClient(filmFlower);

            Console.WriteLine("******* Film Flowers **********");
            Console.WriteLine(" - Table -");
            Console.WriteLine(filmFlowerClient.GetTulipProductDetails());

            Console.WriteLine(" --- Cloned Film Tulip ---");
            ITulip newFilmTulip = filmFlowerClient.CloneTulip();
            newFilmTulip.Proportions = "Large";
            Console.WriteLine(newFilmTulip.GetProductDetails());

            Console.WriteLine(" - Tulip -");
            Console.WriteLine(filmFlowerClient.GetTulipProductDetails());

            Console.ReadKey();

        }
    }
}