using System;

class Product
{
    // Закрытые поля
    private string productName;
    private string storeName;
    private decimal price;

    // Конструктор без параметров
    public Product()
    {
        productName = "Неизвестный товар";
        storeName = "Неизвестный магазин";
        price = 0;
    }

    // Конструктор с параметрами
    public Product(string productName, string storeName, decimal price)
    {
        this.productName = productName;
        this.storeName = storeName;
        this.price = price;
    }

    // Свойства для доступа к полям
    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public string StoreName
    {
        get { return storeName; }
        set { storeName = value; }
    }

    public decimal Price
    {
        get { return price; }
        set { price = value >= 0 ? value : throw new ArgumentException("Цена не может быть отрицательной!"); }
    }

    // Метод отображения информации о продукте
    public void DisplayInfo()
    {
        Console.WriteLine($"Товар: {productName}\nМагазин: {storeName}\nЦена: {price:F2} руб.");
    }

    // Перегруженная операция сравнения ">"
    public static bool operator >(Product p1, Product p2)
    {
        return p1.price > p2.price;
    }

    // Перегруженная операция сравнения "<"
    public static bool operator <(Product p1, Product p2)
    {
        return p1.price < p2.price;
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта с конструктором без параметров
        Product defaultProduct = new Product();
        Console.WriteLine("Товар по умолчанию:");
        defaultProduct.DisplayInfo();

        // Создание объекта с конструктором с параметрами
        Console.WriteLine("\nВведите информацию о втором товаре:");
        Console.Write("Название товара: ");
        string productName = Console.ReadLine();

        Console.Write("Название магазина: ");
        string storeName = Console.ReadLine();

        Console.Write("Стоимость товара (руб.): ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        Product product = new Product(productName, storeName, price);
        Console.WriteLine("\nИнформация о введенном товаре:");
        product.DisplayInfo();

        // Сравнение объектов с перегруженными операциями
        Console.WriteLine("\nСравнение товаров:");
        if (defaultProduct > product)
        {
            Console.WriteLine("Товар по умолчанию дороже введенного товара.");
        }
        else if (defaultProduct < product)
        {
            Console.WriteLine("Введенный товар дороже товара по умолчанию.");
        }
        else
        {
            Console.WriteLine("Оба товара имеют одинаковую стоимость.");
        }
    }
}
