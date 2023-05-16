using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MultiUserBank_Jacaway
{
    internal class Bank
    {
        private decimal BankBalance = 10000m;
        private decimal John = 1250m;
        private decimal Paul = 2500m;
        private decimal George = 3000m;
        private decimal Ringo = 1000m;
        public decimal Withdraw(decimal y, decimal x)
        {
            if (x > 500)
            {
                y -= 500;
                return y;
            }
            if (y - x < 0)
            {
                y -= y;
                return y;
            }
            y -= x;
            return y;
        }
        public decimal Deposit(decimal y, decimal x)
        {
            y += x;
            return y;
        }
        public decimal Vault
        {
            get { return BankBalance; }
        }

        public decimal Lennon
        {
            get { return John; }
        }
        public decimal Mccartney
        {
            get { return Paul; }
        }
        public decimal Harrison
        {
            get { return George; }
        }
        public decimal Starr
        {
            get { return Ringo; }
        }
    }
}