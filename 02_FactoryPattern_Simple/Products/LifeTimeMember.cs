using System;

namespace _02_FactoryPattern_Simple
{
    public class LifeTimeMember : Member
    {
        public override void NotifyMember()
        {
            Console.WriteLine($"Notify LIFETIME member ---> ID: { Id }");
        }
    }
}