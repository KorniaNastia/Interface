using System;

namespace OnlineStoreApp
{
    // Інтерфейс для продуктів
    public interface IProduct
    {
        void DisplayInfo();
    }

    // Інтерфейс для покупок
    public interface IShoppable
    {
        void AddToCart();
    }

    // Базовий клас для електронних пристроїв
    public class ElectronicDevice : IProduct
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }

        public ElectronicDevice(string name, string manufacturer, decimal price)
        {
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Price: {Price:C}");
        }
    }

    // Клас для смартфонів
    public class Smartphone : ElectronicDevice, IShoppable
    {
        public string OperatingSystem { get; set; }
        public int Storage { get; set; } // Гігабайти

        public Smartphone(string name, string manufacturer, decimal price, string operatingSystem, int storage)
            : base(name, manufacturer, price)
        {
            OperatingSystem = operatingSystem;
            Storage = storage;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Operating System: {OperatingSystem}");
            Console.WriteLine($"Storage: {Storage} GB");
        }

        public void AddToCart()
        {
            Console.WriteLine($"{Name} has been added to the cart.");
        }
    }

    // Клас для ноутбуків
    public class Laptop : ElectronicDevice, IShoppable
    {
        public string Processor { get; set; }
        public int RAM { get; set; } // Гігабайти

        public Laptop(string name, string manufacturer, decimal price, string processor, int ram)
            : base(name, manufacturer, price)
        {
            Processor = processor;
            RAM = ram;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RAM} GB");
        }

        public void AddToCart()
        {
            Console.WriteLine($"{Name} has been added to the cart.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Online Store!");

            // Створення смартфона
            Console.WriteLine("\nEnter details for Smartphone:");
            Console.Write("Name: ");
            string smartphoneName = Console.ReadLine();
            Console.Write("Manufacturer: ");
            string smartphoneManufacturer = Console.ReadLine();
            Console.Write("Price: ");
            decimal smartphonePrice = decimal.Parse(Console.ReadLine());
            Console.Write("Operating System: ");
            string smartphoneOS = Console.ReadLine();
            Console.Write("Storage (GB): ");
            int smartphoneStorage = int.Parse(Console.ReadLine());

            Smartphone smartphone = new Smartphone(smartphoneName, smartphoneManufacturer, smartphonePrice, smartphoneOS, smartphoneStorage);

            // Створення ноутбука
            Console.WriteLine("\nEnter details for Laptop:");
            Console.Write("Name: ");
            string laptopName = Console.ReadLine();
            Console.Write("Manufacturer: ");
            string laptopManufacturer = Console.ReadLine();
            Console.Write("Price: ");
            decimal laptopPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Processor: ");
            string laptopProcessor = Console.ReadLine();
            Console.Write("RAM (GB): ");
            int laptopRAM = int.Parse(Console.ReadLine());

            Laptop laptop = new Laptop(laptopName, laptopManufacturer, laptopPrice, laptopProcessor, laptopRAM);

            // Тестування
            Console.WriteLine("\nSmartphone Details:");
            smartphone.DisplayInfo();
            smartphone.AddToCart();

            Console.WriteLine("\nLaptop Details:");
            laptop.DisplayInfo();
            laptop.AddToCart();
        }
    }
}
