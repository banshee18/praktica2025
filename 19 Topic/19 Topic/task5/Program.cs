using System;

/// <summary>
/// Класс Product представляет товар с информацией о названии, магазине и цене
/// </summary>
/// <remarks>
/// Класс включает функциональность для создания товаров, сравнения по цене
/// и отображения информации о товаре
/// </remarks>
class Product
{
    /// <summary>
    /// Название товара
    /// </summary>
    private string productName;

    /// <summary>
    /// Название магазина, где продается товар
    /// </summary>
    private string storeName;

    /// <summary>
    /// Цена товара (в рублях)
    /// </summary>
    private decimal price;

    /// <summary>
    /// Конструктор по умолчанию, инициализирующий товар с значениями по умолчанию
    /// </summary>
    public Product()
    {
        productName = "Неизвестный товар";
        storeName = "Неизвестный магазин";
        price = 0;
    }

    /// <summary>
    /// Параметризованный конструктор для создания товара с указанными параметрами
    /// </summary>
    /// <param name="productName">Название товара</param>
    /// <param name="storeName">Название магазина</param>
    /// <param name="price">Цена товара (должна быть неотрицательной)</param>
    /// <exception cref="ArgumentException">Выбрасывается, если цена отрицательная</exception>
    public Product(string productName, string storeName, decimal price)
    {
        this.productName = productName;
        this.storeName = storeName;
        this.Price = price; // Используем свойство для валидации
    }

    /// <summary>
    /// Свойство для доступа к названию товара
    /// </summary>
    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    /// <summary>
    /// Свойство для доступа к названию магазина
    /// </summary>
    public string StoreName
    {
        get { return storeName; }
        set { storeName = value; }
    }

    /// <summary>
    /// Свойство для доступа к цене товара
    /// </summary>
    /// <exception cref="ArgumentException">Выбрасывается при попытке установить отрицательное значение</exception>
    public decimal Price
    {
        get { return price; }
        set { price = value >= 0 ? value : throw new ArgumentException("Цена не может быть отрицательной!"); }
    }

    /// <summary>
    /// Выводит информацию о товаре в консоль
    /// </summary>
    /// <remarks>
    /// Формат вывода:
    /// Товар: [название]
    /// Магазин: [название магазина]
    /// Цена: [цена с точностью до 2 знаков] руб.
    /// </remarks>
    public void DisplayInfo()
    {
        Console.WriteLine($"Товар: {productName}\nМагазин: {storeName}\nЦена: {price:F2} руб.");
    }

    /// <summary>
    /// Перегруженный оператор "больше" для сравнения товаров по цене
    /// </summary>
    /// <param name="p1">Первый товар для сравнения</param>
    /// <param name="p2">Второй товар для сравнения</param>
    /// <returns>True, если цена первого товара больше цены второго</returns>
    public static bool operator >(Product p1, Product p2)
    {
        return p1.price > p2.price;
    }

    /// <summary>
    /// Перегруженный оператор "меньше" для сравнения товаров по цене
    /// </summary>
    /// <param name="p1">Первый товар для сравнения</param>
    /// <param name="p2">Второй товар для сравнения</param>
    /// <returns>True, если цена первого товара меньше цены второго</returns>
    public static bool operator <(Product p1, Product p2)
    {
        return p1.price < p2.price;
    }
}

/// <summary>
/// Главный класс программы для демонстрации работы с товарами
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу
    /// </summary>
    /// <remarks>
    /// Создает товар по умолчанию, запрашивает у пользователя данные о втором товаре,
    /// выводит информацию о товарах и сравнивает их по цене
    /// </remarks>
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