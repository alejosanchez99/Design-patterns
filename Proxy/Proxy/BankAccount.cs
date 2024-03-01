namespace Proxy.Example1
{
    public class BankAccount : IBankAccount
    {
        private int balance;

        public BankAccount(int balance)
        {
            this.balance = balance;
        }

        public void Deposit(int ammount)
        {
            this.balance += ammount;
        }

        public int GetBalance()
        {
            return this.balance;
        }

        public bool Withdraw(int amount)
        {
            bool withDrawSuccessful = false;

            if (this.balance >= amount)
            {
                this.balance -= amount;
                withDrawSuccessful = true;
            }

            return withDrawSuccessful;
        }
    }
}
