namespace _02_FactoryPattern_Simple
{
    public class MembershipFactory
    {
        public Member GenerateMember(string type)
        {
            switch (type)
            {
                case "temp":
                    return new TemporaryMember();
                case "annual":
                    return new AnnualMember();
                case "lifetime":
                    return new LifeTimeMember();
                default: return null;
            }
        }
    }
}