using System;
using PracticaDobosh.DAL.Context;

namespace PracticaDobosh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Запуск инициализации базы данных ===");

            try
            {
                using (var db = new EquipmentDbContext())
                {
                    Console.WriteLine("Подключение к базе и проверка таблиц...");

                    // Создаем базу на основе твоих новых классов
                    if (db.Database.EnsureCreated())
                    {
                        Console.WriteLine("Успех: База данных и таблицы созданы!");
                    }
                    else
                    {
                        Console.WriteLine("База данных уже существует.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА ПРИ СОЗДАНИИ БАЗЫ:");
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine("Детали: " + ex.InnerException.Message);
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}