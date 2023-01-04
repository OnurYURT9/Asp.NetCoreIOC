using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class DALFactory
    {
        public static DAL GetDal()
        {
            return new DAL();
        }
    }
}
