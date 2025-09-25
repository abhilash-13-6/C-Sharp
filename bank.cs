using System.Security.Cryptography.X509Certificates;

namespace Bank
{
    public class BankAccount
    { 
        private int balance;
        public BankAccount(int initialBalance)
        {
            balance = initialBalance;
        }
        public void deposit(int amt)
        {
            balance = balance + amt;
        }
        public void withdraw(int amt)
        {
            balance = balance - amt;
        }
        public int GetBalance()
        {
            return balance;
        }
    }
    }

