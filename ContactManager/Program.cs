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
                // Запросите пользователя ввести имя контакта
                Console.WriteLine("Напишите имя контакта:");

                string Name = Console.ReadLine();

                // Запросите пользователя ввести фамилию контакта
                Console.WriteLine("Напишите фамилию контакта:");

                string LastName = Console.ReadLine();

                // Запросите пользователя ввести номер телефона контакта
                Console.WriteLine("Напишите номер телефона контакта:");

                int Number = Convert.ToInt32(Console.ReadLine());

                // Отобразите информацию о созданном контакте
                Console.WriteLine("Вы создали контакт:" + "Имя:" + Name + "  " +  "Фамилия:" +  LastName + "  " + "Номер телефона:" + Number);

                // Запросите пользователя изменить имя контакта
                Console.WriteLine("Хотите ли вы изменить имя контакта? (да/нет)");

                contact = Console.ReadLine();


                if (contact == "да")
                {
                    // Запросите пользователя ввести новое имя для контакта
                    Console.WriteLine("Введите новое имя контакта:");

                    string NewName = Console.ReadLine();

                    Name = NewName;
                }

                Console.WriteLine("Хотите ли вы изменить фамилию контакта? (да/нет)");

                contact = Console.ReadLine();


                if (contact == "да")
                {
                    // Запросите пользователя ввести новую фамилию для контакта
                    Console.WriteLine("Введите новою фамилию контакта:");

                    string NewLastName = Console.ReadLine();

                    LastName = NewLastName;
                }

                Console.WriteLine("Хотите ли вы изменить мобильный номер контакта? (да/нет)");

                contact = Console.ReadLine();


                if (contact == "да")
                {
                    // Запросите пользователя ввести новый номер телефона для контакта
                    Console.WriteLine("Введите новый мобильный номер контакта:");

                    Number = Convert.ToInt32(Console.ReadLine());

                    // Отобразите обновленную информацию о контакте
                    Console.WriteLine("Контакт обновлен: " + "Имя:" + Name + "  " + "Фамилия:" + LastName + "  " + "Номер телефона:" + Number);
                }

                if (contact == "нет")
                {
                    // Отобразите информацию о контакте без каких-либо изменений
                    Console.WriteLine("Контакт обновлен: " + "Имя:" + Name + "  " + "Фамилия:" + LastName + "  " + "Номер телефона:" + Number);
                }
               
            }
        }
    }
}