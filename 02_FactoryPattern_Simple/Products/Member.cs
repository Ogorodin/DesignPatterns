using System;

namespace _02_FactoryPattern_Simple
{
    public abstract class Member
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public Member()
        {
            Random random = new Random();
            Id = random.Next(1, 10);
        }

        public abstract void NotifyMember();
    }
}