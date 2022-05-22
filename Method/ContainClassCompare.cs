using Linq_example.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Linq_example.Method
{
    public class ContainClassCompare : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if(x.FirstName == y.FirstName && x.Age == y.Age)
                return true;

            return false;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            throw new NotImplementedException();
        }
    }
}
