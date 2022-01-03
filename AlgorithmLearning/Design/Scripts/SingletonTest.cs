
using System;

namespace Design
{
    class SingletonTest
    {
        public void Main()
        {
            var I1 = Singleton.I;
            var I2 = Singleton2.I;
            var I3 = Singleton3.I;
            var I4 = new SingletonTest1();
            Console.Write(I4 == SingletonTest1.I);
        }
    }

    class SingletonTest1 : Singleton4<SingletonTest1>
    {
        public SingletonTest1()
        {
            
        }
        public void Test1()
        {
            var I1 = Singleton.I;
            var I2 = Singleton2.I;
            var I3 = Singleton3.I;
        }
    }

}
