using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    //class Utilities
    class Utilities<T> where T : IComparable, new()   // CONSTRAINTS
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //public T Max<T>(T a, T b) where T : IComparable
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            //ERROR Cannot create an instance of the variable type 'T' because it does not have the new() constraint GenericList 
            //WE NEED TO ADD A NEW CONSTRAINT: new() --> for default constructor
            var obj = new T(); 
            

        }
    }
}
