using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns_Singleton
{
    public class Singleton<T> where T : new()
    {
        private static readonly object locker = new object();

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }
                }

                return instance;
            }
        }

        private static T instance;
    }
}
