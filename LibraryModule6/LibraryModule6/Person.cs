using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModule6
{
    public class Person
    {
        public string Name{ get; set; }
        public int Age{ get; set; }
        public string Sex{ get; set; }
        public string City{ get; set; }
        public static string PersonInfo(Person person)
        {
            return $"Имя: {person.Name}, Возраст: {person.Age}, Пол: {person.Sex}, Живет в городе {person.City}";
        }
    }
    
}
