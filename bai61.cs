using System;
using System.Collections.Generic;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        // Tạo một Dictionary lồng nhau
        Dictionary<string, Dictionary<string, int>> nestedDict = new Dictionary<string, Dictionary<string, int>>();

        // Thêm phần tử vào Dictionary lồng nhau
        nestedDict["group1"] = new Dictionary<string, int>
        {
            { "item1", 10 },
            { "item2", 20 }
        };

        nestedDict["group2"] = new Dictionary<string, int>
        {
            { "item1", 30 },
            { "item2", 40 }
        };

        // Hiển thị nội dung của Dictionary lồng nhau
        foreach (var group in nestedDict)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var item in group.Value)
            {
                Console.WriteLine($"  {item.Key}: {item.Value}");
            }
        }

        // Chuyển Dictionary lồng nhau thành JSON string
        string jsonString = JsonSerializer.Serialize(nestedDict, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("\nJSON:\n" + jsonString);
    }
}
