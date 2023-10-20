using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class CreditCardValidator
    {
        private const string CorrectPassword = "1234";
        private const int MaxAttempts = 3;

        public bool ValidateCreditCard()
        {
            Console.WriteLine("Введите пароль для кредитной карты:");

            for (int attempts = 0; attempts < MaxAttempts; attempts++)
            {
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == CorrectPassword)
                {
                    Console.WriteLine("Пароль верный. Доступ разрешен.");
                    return true;
                }
                else
                {
                    int remainingAttempts = MaxAttempts - attempts - 1;
                    Console.WriteLine($"Пароль неверный. Осталось попыток: {remainingAttempts}");

                    if (remainingAttempts == 0)
                    {
                        Console.WriteLine("Исчерпан лимит попыток. Доступ запрещен.");
                        return false;
                    }
                }
            }

            return false;
        }
    }
}
