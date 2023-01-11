using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Loops
{
    public class PrintProducts
    {
        private static List<Product> products = new List<Product>();

        public static void CreatiListProduct()
        {
            var potatoes = new Products();
            potatoes.Id = 1;
            potatoes.Name = "Patatas";
            potatoes.Price = 26.56f;
            products.Add(potatoes);

            var oil = new Products();
            oil.Id = 2;
            oil.Name = "Aceite";
            oil.Price = 35.27f;
            products.Add(oil);

            var game = new Products();
            game.Id = 3;
            game.Name = "Juego";
            game.Price = 39.99f;
            products.Add(game);
        }
    }
}
