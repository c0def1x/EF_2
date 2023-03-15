using EF_Category_Product.Models;

var context = new CategoryContext();

void Menu()
{
    Console.WriteLine("1.Для выхода нажмите Escape");
    Console.WriteLine("2.Вывод товаров");
    Console.WriteLine("2.Вывод товаров");
}

void PrintProducts()
{
    foreach (Product product in context.Products)
    {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($"Название: {product.Title}");
        Console.WriteLine($"Изображение: {product.ImagePath}");
        Console.WriteLine($"Описание: { product.Description}");
        Console.WriteLine($"Количество: {product.Count}");
        Console.WriteLine($"Цена: {product.Price}");
        Console.WriteLine($"Скидка: {product.Discount}");
        Console.WriteLine($"Категория: {product.Category}");
        if (product.Discount > 0)
        {
            Console.WriteLine($"Цена со скидкой: {product.PriceWithDiscount()}");
        }
        Console.WriteLine("----------------------------------------------------\n");
    }
}

void Application()
{
    do
    {
        PrintProducts();
    } 
    while (Console.ReadKey().Key != ConsoleKey.Escape);
}

Application();