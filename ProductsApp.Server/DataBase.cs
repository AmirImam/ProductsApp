using ProductsApp.Models;

namespace ProductsApp.Server
{
    public class DataBase
    {
        public List<Product> Products { get; } = new()
        {
            new()
            {
                //Id = 1,
                Name = "Samsung Galaxy A23 SM-A235F/DSN, Dual SIM Blue 4GB RAM 128GB 4G - Blue",
                Price =200,
                PhotoUrl="https://m.media-amazon.com/images/I/61mOx8va+LL._AC_SX679_.jpg"
            },
            new()
            {
                //Id = 2,
                Name = "Apple iPhone 14 Pro Max (256 GB) - Gold",
                Price =500,
                PhotoUrl="https://m.media-amazon.com/images/I/71T5NVOgbpL._AC_SX679_.jpg"
            },
            new()
            {
                //Id = 3,
                Name = "HP Laptop 15s-fq5009ne (6G3H3EA)",
                Price =10000,
                PhotoUrl="https://m.media-amazon.com/images/I/41dlVqqF07L._AC_SX679_.jpg"
            },
            new()
            {
                //Id = 4,
                Name = "HP Pavilion x360 Convertible 2n1 14-dy0142ne",
                Price =20000,
                PhotoUrl="https://m.media-amazon.com/images/I/61ggOLMkuYL._AC_SX679_.jpg"
            },
            new()
            {
                //Id = 5,
                Name = "Eau de Toilette - 55ml",
                Price =100,
                PhotoUrl="https://m.media-amazon.com/images/I/517SRdmmInL._AC_SX679_.jpg"
            }
        };

        public List<Order> Orders { get; } = new();

    }
}