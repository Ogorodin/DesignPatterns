using _021_FactoryPattern_AbstractFactoryMethod.Products;

namespace _021_FactoryPattern_AbstractFactoryMethod.Factory
{
    class NoviSadMembershipFactory : MembershipFactory
    {
        public override Member CreateMember(string type)
        {
            switch (type)
            {
                case "temp":
                    return new NoviSadTemporaryMember();
                case "annual":
                    return new NoviSadAnnualMember();
                case "lifetime":
                    return new NoviSadLifetimeMember();
                default: return null;
            }
        }
    }
}
