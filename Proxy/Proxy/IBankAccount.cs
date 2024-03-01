namespace Proxy.Example1
{
    public interface IBankAccount
    {
        void Deposit(int ammount);
        bool Withdraw(int amount);
        int GetBalance();
    }
}
