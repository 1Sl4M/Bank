using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryModule6;
using Bankomat;

namespace HomeWorkModule6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person{
                Name = PersonConstants.Name,
                Age = PersonConstants.Age,
                Sex = PersonConstants.Sex,
                City = PersonConstants.City,
            };

            string infoOfPerson = Person.PersonInfo(person);

            Console.WriteLine(infoOfPerson);

            var client = new Bankomat.Client("Иванов Иван");

            var bank = new Bankomat.Bank();

            var account = bank.OpenAccount(client);

            account.Deposit(200);

            account.Withdraw(50);


            CreditCardValidator validator = new CreditCardValidator();
            bool accessGranted = validator.ValidateCreditCard();

            if (accessGranted)
            {
                while(true) {

                    Console.WriteLine("Выберите одно из действий:\n1.вывод баланса на экран\n2.пополнение счётa\n3.снять деньги со счёта\n4.выход");
                    int choice = int.Parse(Console.ReadLine());
                    
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Ваш баланс составляет {account.Balance}");
                            break;
                        case 2:
                            Console.WriteLine("Введите сумму:");
                            int sum = int.Parse(Console.ReadLine());

                            account.Deposit(sum);
                            break;
                        case 3:
                            Console.WriteLine("Введите сумму:");
                            int minus = int.Parse(Console.ReadLine());

                            if (minus > account.Balance)
                            {
                                Console.WriteLine("Недостаточно средств на счете.");
                            }
                            else
                            {
                                account.Withdraw(minus);
                                Console.WriteLine($"Вы сняли {minus} со счёта.");
                            }
                            break;
                        case 4:
                            return;

                        default:
                            Console.WriteLine("Введено неверное число");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Доступ запрещен");
            }

            Console.ReadLine();
        }
    }
}
