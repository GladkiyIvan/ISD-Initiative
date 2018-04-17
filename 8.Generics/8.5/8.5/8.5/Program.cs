using System;

namespace _8._5
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.SetWindowSize(50, 40);

            CarCollection<ICar> vehicles = new CarCollection<ICar>()
            {
                new Car("Ниссан", 2006),
                new Minivan("Мерседес", 2014)
            };

            ShowUI(vehicles);

			Console.ReadLine();
		}

        static void ShowUI(CarCollection<ICar> vehicles)
        {
            Console.Clear();
            
            Console.WriteLine("---------------     Автопрокат     ---------------");
            
            if(vehicles.Count == 0)
                Console.WriteLine("\nАвтопарк пуст");
            else
                Console.WriteLine(vehicles);

            Console.WriteLine("\nМеню:");
            Console.WriteLine(" 1. Добавить машину");
            Console.WriteLine(" 2. Удалить машину");
            Console.WriteLine(" 3. Закрыть парковку");
            Console.Write("Ввод: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int select) || input.Length != 1)
                ShowUI(vehicles);
            if (select == 1)
                ShowAddUI(vehicles);
            else if (select == 2)
                ShowRemoveUI(vehicles);
            else if (select == 3)
                ShowRemoveAllUI(vehicles);
            else
                ShowUI(vehicles);
            Console.WriteLine("-------------------------");
        }
        static void ShowAddUI(CarCollection<ICar> vehicles)
        {
            Console.Clear();
            Console.WriteLine("---------------   Добавление авто  ---------------\n");
            Console.Write("Тип (1-легковое авто, 2-минивен): ");
            if (!int.TryParse(Console.ReadLine(), out int type))
                ShowError(vehicles);
            Console.Write("Название:    ");
            string name = Console.ReadLine();
            Console.Write("Год выпуска: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
                ShowError(vehicles);

            ICar newVehicle = null;
            if (type == 1)
                newVehicle = new Car(name, year);
            else if (type == 2)
                newVehicle = new Minivan(name, year);
            else
                ShowError(vehicles);
            
            if(newVehicle != null)
            {
                vehicles.Add(newVehicle);
                Console.WriteLine("Автомобиль добавлен!");
                ShowUI(vehicles);
            }
        }
        static void ShowRemoveUI(CarCollection<ICar> vehicles)
        {
            Console.Clear();
            Console.WriteLine("--------------    Удаление авто    ---------------\n");
            Console.Write("Введите номер авто: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
                ShowError(vehicles);
            try
            {
                ICar current = vehicles[number - 1];
                vehicles.RemoveAt(number - 1);
                Console.WriteLine($"\nАвто '{current.Name} ({current.Year} г.)' удалено");
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Недопустимый номер - такой машины нет");
                Console.WriteLine("-------------------------------------");
            }

            PressToContinue(vehicles);
        }
        static void ShowRemoveAllUI(CarCollection<ICar> vehicles)
        {
            Console.Clear();
            Console.WriteLine("---------------   Удаление парка   ---------------\n");
            Console.Write("Удалить весь парк? (y/n): ");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                vehicles.RemoveAll();
                Console.WriteLine("\nВсе автомобили удалены");
                PressToContinue(vehicles);
            }
            else if(answer == "n")
            {
                Console.WriteLine("\nУдаление отменено");
                PressToContinue(vehicles);
            }
            else
            {
                ShowRemoveAllUI(vehicles);
                PressToContinue(vehicles);
            }
        }
        static void ShowError(CarCollection<ICar> vehicles)
        {
            Console.Clear();
            Console.WriteLine("Ошибка ввода!");
            Console.WriteLine("-------------\n");
            PressToContinue(vehicles);
        }
        static void PressToContinue(CarCollection<ICar> vehicles)
        {
            Console.WriteLine("\nНажмите, чтобы продолжить...");
            Console.ReadKey();
            ShowUI(vehicles);
        }
    }
}