using System;
using _021_FactoryPattern_AbstractFactoryMethod.Products;

namespace _021_FactoryPattern_AbstractFactoryMethod.Factory
{
    public class MembershipManager
    {
        private MembershipFactory _factory;

        public MembershipManager(MembershipFactory factory)
        {
            _factory = factory;
        }

        public Member GenerateMember(string type)
        {
            return _factory.CreateMember(type);
        }

    }
}
