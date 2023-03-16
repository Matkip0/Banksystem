using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    public class BankAccount
    {
        double balance = 100;
        public BankAccount()
        {

        }

        public void GetBalance()
        {
            Console.WriteLine($"Du har {balance}kr. på din konto");
        }

        public void Deposit()
        {


            Console.WriteLine("Indtast hvor mange penge du vil sætte ind");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                balance += amount;
                Console.WriteLine($"Du har lagt {amount}kr. ind på din konto");
                Console.WriteLine($"Du har nu {balance}kr. på din konto");
            }
            else
            {
                Console.WriteLine("Der skete en fejl");
            }

        }
        public void Withdraw()
        {
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Du har trukket {amount}kr. ud af din konto");
                    Console.WriteLine($"Du har nu {balance}kr. på din konto");
                }
                else
                {
                    Console.WriteLine($"Kunne ikke gennemføre handlingene fordi du ikke har nok penge");
                    GetBalance();
                }
            }
            else
            {
                Console.WriteLine("Der skete en fejl");
            }
        }
    }
}
