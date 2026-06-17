using System;

class Product
{
    public int ProductId;
    public string ProductName;

    public Product(int productId, string productName)
    {
        ProductId = productId;
        ProductName = productName;
    }
}

class EcommerceSearch
{
    static int LinearSearch(Product[] catalog, int targetId)
    {
        for (int i = 0; i < catalog.Length; i++)
        {
            if (catalog[i].ProductId == targetId)
            {
                return i;
            }
        }

        return -1;
    }

    static int BinarySearch(Product[] catalog, int targetId)
    {
        int left = 0;
        int right = catalog.Length - 1;

        while (left <= right)
        {
            int middle = (left + right) / 2;

            if (catalog[middle].ProductId == targetId)
            {
                return middle;
            }

            if (catalog[middle].ProductId < targetId)
            {
                left = middle + 1;
            }
            else
            {
                right = middle - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        Product[] catalog =
        {
            new Product(101, "Laptop"),
            new Product(205, "Headphones"),
            new Product(310, "Smart Watch"),
            new Product(425, "Keyboard"),
            new Product(550, "Monitor")
        };

        int searchId = 425;

        int linearResult = LinearSearch(catalog, searchId);
        int binaryResult = BinarySearch(catalog, searchId);

        Console.WriteLine("Linear Search");

        if (linearResult != -1)
        {
            Console.WriteLine(catalog[linearResult].ProductName);
        }
        else
        {
            Console.WriteLine("Product not found");
        }

        Console.WriteLine();

        Console.WriteLine("Binary Search");

        if (binaryResult != -1)
        {
            Console.WriteLine(catalog[binaryResult].ProductName);
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }
}