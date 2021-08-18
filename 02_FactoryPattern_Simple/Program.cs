namespace _02_FactoryPattern_Simple
{
    /*
     *      This program simulates a membership application for sport court payments.
     *      It is using a simple factory method. 
     *      This is not a factory pattern. It is more of a programming IDIOM.
     */
    class Program
    {
        static void Main(string[] args)
        {
            MembershipFactory factory = new MembershipFactory();
            MembershipManager manager = new MembershipManager(factory);

            Member member = manager.GetMember("teadmp");

            member.NotifyMember();
        }
    }
}