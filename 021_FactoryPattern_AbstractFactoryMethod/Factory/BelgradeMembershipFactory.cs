using _021_FactoryPattern_AbstractFactoryMethod.Products;

namespace _021_FactoryPattern_AbstractFactoryMethod.Factory
{
    public class BelgradeMembershipFactory : MembershipFactory
    {
        public override Member CreateMember(string type)
        {
            switch (type)
            {
                case "temp":
                    return new BelgradeTemporaryMember();
                case "annual":
                    return new BelgradeAnnualMember();
                case "lifetime":
                    return new BelgradeLifetimeMember();
                default: return null;
            }
        }
    }
}
