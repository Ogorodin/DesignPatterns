using _021_FactoryPattern_AbstractFactoryMethod.Factory;
using _021_FactoryPattern_AbstractFactoryMethod.Products;

namespace _021_FactoryPattern_AbstractFactoryMethod
{
    /*
     *      This is the real factory pattern. The abstract factory method.
     *      This way if we need to add new Products,all we have to do is to
     *      add them. The factory and manager classes will not have to change
     *      and will continue to do their work as intended.
     *      
     *      This sports the O/C principle. Our code is open for extension
     *      but closed for modification...
     */
    class Program
    {
        static void Main(string[] args)
        {
            MembershipFactory factory = new BelgradeMembershipFactory();

            Member member = factory.CreateMember("lifetime");

            member.NotifyMember();
        }
    }
}
