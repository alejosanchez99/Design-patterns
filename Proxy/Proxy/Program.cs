
using Proxy.Example1;

BankAccount bankAccount = new BankAccount(1500);
BankAccountProxy bankAccountProxy = new BankAccountProxy(bankAccount);

bool result = bankAccountProxy.Withdraw(500);

if (result)
{
    Console.WriteLine($"Withdrawal successful. Balance is now {bankAccountProxy.GetBalance()}");
}
else
{
    Console.WriteLine($"Withdrawal not possible.");
}

result = bankAccountProxy.Withdraw(12000);

if (result)
{
    Console.WriteLine($"Withdrawal successful. Balance is now {bankAccountProxy.GetBalance()}");
}
else
{
    Console.WriteLine($"Withdrawal not possible.");
}