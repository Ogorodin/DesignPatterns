using _021_FactoryPattern_AbstractFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_FactoryPattern_AbstractFactoryMethod.Factory
{
    public abstract class MembershipFactory
    {
        public Member GetMember(string type)
        {
            return CreateMember(type);
        }
        public abstract Member CreateMember(string type);
    }
}
