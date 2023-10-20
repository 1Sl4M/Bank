using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bank
    {
        public Account OpenAccount(Client client)
        {
            int accountNumber = GenerateAccountNumber();
            int password = GeneratePassword();

            Account account = new Account
            {
                AccountNumber = accountNumber,
                Password = password,
            };

            Console.WriteLine($"Уважаемый {client.Name}, ваш счет открыт.");
            Console.WriteLine($"Номер счета: {accountNumber}");
            Console.WriteLine($"Пароль: {password}");

            return account;
        }
        private int GenerateAccountNumber()
        {
            return 1000;
        }

        private int GeneratePassword()
        {
            return 1234;
        }
    }
    public class Client
    {
        public string Name{ get; set; }
        public Client(string name)
        {
            Name = name;
        }
    }
    public class Account
    {
        public int AccountNumber { get; set; }
        public int Password { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Внесено {amount} тенге. Новый баланс: {Balance} тенге.");
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Снято {amount} тенге. Новый баланс: {Balance} тенге.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
        }
    }
}
