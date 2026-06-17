using System;

class SearchComparison
{
    static int LinearSearch(int[] products, int searchKey)
    {
        for (int i = 0; i < products.Length; i++)
        {
            if (products[i] == searchKey)
            {
                return i;
            }
        }

        return -1;
    }

    static int BinarySearch(int[] products, int searchKey)
    {
        int start = 0;
        int end = products.Length - 1;

        while (start <= end)
        {
            int middle = (start + end) / 2;

            if (products[middle] == searchKey)
            {
                return middle;
            }

            if (products[middle] < searchKey)
            {
                start = middle + 1;
            }
            else
            {
                end = middle - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] products = { 101, 205, 310, 425, 550, 680, 790 };
        int searchKey = 425;

        int linearResult = LinearSearch(products, searchKey);
        int binaryResult = BinarySearch(products, searchKey);

        Console.WriteLine("Linear Search Result: " + linearResult);
        Console.WriteLine("Binary Search Result: " + binaryResult);
    }
}