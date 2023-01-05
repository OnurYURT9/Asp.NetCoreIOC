using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class OracleDAL : IDAL

    {
        public List<Product> GetProducts()
        {
            //Oracle
            return new List<Product>()
            {
                new Product{Id=1,Name="OKalem",Price=100,Stock=50},
                new Product{Id=2,Name="OKalem 1",Price=100,Stock=50},
                new Product{Id=3,Name="OKalem 2",Price=100,Stock=50},
                new Product{Id=4,Name="OKalem 4",Price=100,Stock=50}

            };
        }
    }
}
