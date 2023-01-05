using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
   internal class DAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{Id=1,Name="Kalem",Price=100,Stock=50},
                new Product{Id=2,Name="Kalem 1",Price=100,Stock=50},
                new Product{Id=3,Name="Kalem 2",Price=100,Stock=50},
                new Product{Id=4,Name="Kalem 4",Price=100,Stock=50}

            };
        }
        public int Hesapla()
        {
            return 100;
        }
    }
}
