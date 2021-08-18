using System;

namespace _02_FactoryPattern_Simple
{
    public class TemporaryMember : Member
    {       
        public override void NotifyMember()
        {
            Console.WriteLine($"Notify TEMPORARY member ---> ID: { Id }");
        }
    }
}