using System;
using System.Collections.Generic;
using System.Text;

namespace IOC
{
    class DALFactory
    {
        public static IDAL GetDal()
        {
            return new DAL();
        }
    }
}

//somut dediğimiz new anahtar sözcüğüyle nesne örneği alınabilen yapıdır.
//soyut tam tersi
// örneğin interface new anahtar sözcüğüyle oluşturamazsınız.