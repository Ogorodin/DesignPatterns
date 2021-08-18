namespace _02_FactoryPattern_Simple
{
    public class MembershipManager
    {
        private MembershipFactory _factory;

        public MembershipManager(MembershipFactory factory)
        {
            _factory = factory;
        }

        public Member GetMember(string type)
        {
            return _factory.GenerateMember(type);
        }
    }
}