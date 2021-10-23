using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccountSim
{
    public class BankAccount
    {
        public string Name;
        private double balance;
        public double Balance
        {
            get { return balance; }
        }

        private bool locked;

       // private double bankAccount;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public BankAccount(string name, double balance) : this(balance : balance)
        {
            this.Name = name;
        }
        public BankAccount(string name, double balance, bool locked)
        {
            this.Name = name;
            this.balance = balance;
            this.locked = locked;
        }
         private double amount;

        public void Deposit(double amount)
        {
            
            //Deposit(amount : double): indsætter det angivende beløb
            //må ikke være i stand til at indsætte til en låst bankkonto
            if (!locked == true)
            {
                this.amount = amount;
                balance = balance + amount;
            }
        }
        public void Withdraw(double amount)
        {
            //Withdraw(amount: double): trækker det angivende beløb(en: amount)
            //må ikke trække flere penge, end der er på bankkontoen
            //må ikke trække penge fra en låst bankkonto(en: locked)
            
            if (!locked == true && balance >= 0)
            {
                this.amount = amount;
                balance = balance - amount;
            }

        }
        public void ChangeLockState()
        {
            locked = !locked;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Balance: {balance}"; 
        }






    }
}
