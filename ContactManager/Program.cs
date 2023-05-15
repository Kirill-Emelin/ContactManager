using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ContactManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хотите ли вы создать новый контакт ? (да / нет)");
            string contact = Console.ReadLine();

            if (contact == "да")
            {
                Console.WriteLine("Напишите имя контакта:");

                string Name = Console.ReadLine();

                Console.WriteLine("Напишите фамилию контакта:");

                string LastName = Console.ReadLine();

                Console.WriteLine("Напишите номер телефона контакта:");

                int Number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Вы создали контакт:" + "Имя:" + Name + "  " +  "Фамилия:" +  LastName + "  " + "Номер телефона:" + Number);

                Console.WriteLine("Хотите ли вы изменить имя контакта? (да/нет)");

                contact = Console.ReadLine();


                if (contact == "да")
                {
                    Console.WriteLine("Введите новое имя контакта:");

                    string NewName = Console.ReadLine();

                    Name = NewName;
                }

                Console.WriteLine("Хотите ли вы изменить фамилию контакта? (да/нет)");

                contact = Console.ReadLine();


                if (contact == "да")
                {
                    Console.WriteLine("Введите новою фамилию контакта:");

                    string NewLastName = Console.ReadLine();

                    LastName = NewLastName;
                }

                Console.WriteLine("Хотите ли вы изменить мобильный номер контакта? (да/нет)");

                contact = Console.ReadLine();


                if (contact == "да")
                {
                    Console.WriteLine("Введите новый мобильный номер контакта:");

                    Number = Convert.ToInt32(Console.ReadLine());

                   
                    Console.WriteLine("Контакт обновлен: " + "Имя:" + Name + "  " + "Фамилия:" + LastName + "  " + "Номер телефона:" + Number);
                }

                if (contact == "нет")
                {
                    Console.WriteLine("Контакт обновлен: " + "Имя:" + Name + "  " + "Фамилия:" + LastName + "  " + "Номер телефона:" + Number);
                }
               
            }
        }
    }
}