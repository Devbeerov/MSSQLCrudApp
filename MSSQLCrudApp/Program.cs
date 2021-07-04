using System;
using System.Reflection;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace MSSQLCrudApp
{
    class Program
    {
        private static Commands commands;

        private static void PrintHeader()
        {
            Console.WriteLine("Добро пожаловать.");
        }

        private static void PrintOperations()
        {
            // CRUD - Create, Read, Update, Delete
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Добавить нового работника.");
            Console.WriteLine("2. Показать список работников.");
            Console.WriteLine("3. Изменить информацию о работнике.");
            Console.WriteLine("4. Удалить работника из базы данных.");
            Console.WriteLine("5. Выход.");
        }

        private static ConsoleKey GetInput()
        {
            var key = Console.ReadKey();

            return key.Key;
        }

        private static void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    
                    break;

                case ConsoleKey.D2:

                    break;

                case ConsoleKey.D3:

                    break;

                case ConsoleKey.D4:

                    break;

                case ConsoleKey.D5:

                    break;

                default:
                    Console.WriteLine($"{System.Environment.NewLine}Неизвестная команда. Выберите команду еще раз.");
                    ProcessInput();
                    return;
            }
        }

        private static ISessionFactory ConfigureDB()
        {
            var config = new Configuration().Configure();
            //new SchemaUpdate(config).Execute(true, true);

            return config.BuildSessionFactory();
        }

        private static void Configure()
        {
            var factory = ConfigureDB();

            commands = new Commands(factory);
            Console.OutputEncoding = Encoding.UTF8;
        }

        private static void ProcessInput()
        {
            var key = GetInput();

            HandleInput(key);
        }

        static void Main(string[] args)
        {
            Configure();

            PrintHeader();
            PrintOperations();

            ProcessInput();
        }
    }
}
