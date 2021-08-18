using System;

namespace _02_FactoryPattern_Simple
{
    public class AnnualMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine($"Notify ANNUAL member ---> ID: { Id }");
        }
    }
}