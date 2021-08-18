using System;

namespace _01_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  Uncomment and compiler will yell becouse of  private constructor
             *  
             *   SingletonClass obj = new SingletonClass();  
             *   SingletonThreadSafe obj1 = new SingletonThreadSafe();
             */

            SingletonClass obj = SingletonClass.GetInstance();
            SingletonClass obj1 = SingletonClass.GetInstance();

            bool isSameInstance = obj == obj1;
            Console.WriteLine($"Is same instance: { isSameInstance }");

            SingletonThreadSafe obj2 = SingletonThreadSafe.GetInstance();
            SingletonThreadSafe obj3 = SingletonThreadSafe.GetInstance();

            isSameInstance = obj2 == obj3;
            Console.WriteLine($"Is same instance: { isSameInstance }");
        }
    }

    public class SingletonClass // not thread safe
    {
        private static SingletonClass _instance;
        private SingletonClass() { }

        public static SingletonClass GetInstance()
        {
            if (_instance == null)
                _instance = new SingletonClass();
            return _instance;
        }
    }

    public class SingletonThreadSafe
    {
        private static SingletonThreadSafe _instance = new SingletonThreadSafe();

        private SingletonThreadSafe() { }

        public static SingletonThreadSafe GetInstance()
        {
            return _instance;
        }
    }
}
