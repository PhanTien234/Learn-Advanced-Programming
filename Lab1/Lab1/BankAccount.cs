using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id { 
        get { return id; }
            set { id = value; }
        }
        public decimal Balance { get { return balance; } set { balance = value; } }
   
        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (this.balance < amount) Console.WriteLine("Insuficient balance");
            else
            balance -= amount;
        }
        public override string ToString()
        {
            return $"Account Id {Id}, balance {Balance:0.00}";
        }
      
    }
}
