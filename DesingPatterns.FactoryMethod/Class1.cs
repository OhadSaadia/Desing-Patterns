using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod
{
    class Class1 : IClass1
    {
        private Class1()
        {

        }

        public static Class1 Create()
        {
            return new Class1();
        }
    }
}
