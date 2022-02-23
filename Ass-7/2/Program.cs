using System;
namespace BankSystem
{
    class BankCustomer
    {
        public int accountno;
        public string custname;
        public double bankbalance;
        public BankCustomer(int accno,string Custname,double bankb)
        {
            this.accountno = accno;
            this.custname=Custname;
            this.bankbalance=bankb;
        }
    }
    public delegate void BalanceChecking(double n);
    class BankMain
    {
        public static void checkBalance(double balance)
        {
            if( balance < 0 )
                Console.Write("You are Overdrawn!!!!");
            else if(balance < 10)
                Console.Write("Your Account Balance is very Low!!!");
            else if(balance < 100)
                Console.Write("Watch your spending Carefully!!!");
            else
                Console.Write("You have over $100 in your Account!!!");
        }
        static void Main()
        {
            BalanceChecking checking = checkBalance;
            BankCustomer b1= new BankCustomer(123,"KENNY",-6);
            Console.Write("\nWELCOME TO NOP BANK");
            Console.Write($"\nHi,{b1.custname} | ");
            checking(b1.bankbalance);
            Console.WriteLine($" : [BALANCE = ${b1.bankbalance}]");
            BankCustomer b2= new BankCustomer(456,"RAJ",7);
            Console.Write("\nWELCOME TO NOP BANK");
            Console.Write($"\nHi,{b2.custname} | ");
            checking(b2.bankbalance);
            Console.WriteLine($" : [BALANCE = ${b2.bankbalance}]");
            BankCustomer b3= new BankCustomer(789,"AJAY",78);
            Console.Write("\nWELCOME TO NOP BANK");
            Console.Write($"\nHi,{b3.custname} | ");
            checking(b3.bankbalance);
            Console.WriteLine($" : [BALANCE = ${b3.bankbalance}]");
            BankCustomer b4= new BankCustomer(1011,"TENZIN",5000);
            Console.Write("\nWELCOME TO NOP BANK");
            Console.Write($"\nHi,{b4.custname} | ");
            checking(b4.bankbalance);
            Console.WriteLine($" : [BALANCE = ${b4.bankbalance}]");
        }
    }
}