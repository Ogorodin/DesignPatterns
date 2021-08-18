using System;

namespace _021_FactoryPattern_AbstractFactoryMethod.Products
{
    public abstract class Member
    {
        public abstract void NotifyMember();
    }
    public class NoviSadTemporaryMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine("Notify NOVI SAD TEMPORARY member");
        }
    }
    public class NoviSadAnnualMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine("Notify NOVI SAD ANNUAL member");

        }
    }
    public class NoviSadLifetimeMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine("Notify NOVI SAD LIFETIMEs member");

        }
    }

    public class BelgradeTemporaryMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine("Notify BELGRADE TEMPORARY member");
        }
    }

    public class BelgradeAnnualMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine("Notify BELGRADE ANNUAL member");
        }
    }

    public class BelgradeLifetimeMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine("Notify BELGRADE LIFETIME member");
        }
    }
}
