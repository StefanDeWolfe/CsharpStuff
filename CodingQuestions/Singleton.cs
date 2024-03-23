using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();
        static Singleton() { } // static constructor executes only once per Application Domain.
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
        public int Value { set; get; }

    }
}
