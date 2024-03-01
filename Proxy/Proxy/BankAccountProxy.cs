namespace Proxy.Example1
{
    using System;

    public class BankAccountProxy : IBankAccount
    {
        private BankAccount bankAccount;

        public BankAccountProxy(BankAccount bankAccount)
        {
            this.bankAccount = bankAccount;
        }

        public void Deposit(int ammount)
        {
            this.bankAccount.Deposit(ammount);
        }

        public int GetBalance()
        {
            return this.bankAccount.GetBalance();
        }

        public bool Withdraw(int amount)
        {
            bool withDrawSuccessful = false;
            if (amount > 1000)
            {
                Console.WriteLine("You need manager aproval for with drawals over 10000");
            }
            else
            {
                withDrawSuccessful = this.bankAccount.Withdraw(amount);
            }

            return withDrawSuccessful;
        }
    }
}
