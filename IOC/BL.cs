using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    internal class BL
    {
        private DAL _dal { get; set; }
        public BL()
        {
            _dal = DALFactory.GetDal();
        }
        public List<Product> GetProducts ()
        {
            return _dal.GetProducts();
        }
    }
}
