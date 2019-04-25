namespace Finances
{
    namespace Employees
    {
        public struct Wage
        {
            public decimal Basic { get; set; }
            public decimal Bonus { get; set; }
            public decimal Other { get; set; }

            public Wage(decimal basic, decimal bonus = 0, decimal other = 0)
            {
                Basic = basic;
                Bonus = bonus;
                Other = other;
            }

            public decimal WageSummary()
            {
                return Basic + Bonus + Other;
            }
        }
    }
}
