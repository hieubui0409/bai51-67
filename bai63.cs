//cachs1 
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        // Tạo một Dictionary mẫu
        Dictionary<string, Dictionary<string, int>> nestedDict = new Dictionary<string, Dictionary<string, int>>
        {
            ["group1"] = new Dictionary<string, int>
            {
                ["item1"] = 10,
                ["item2"] = 20
            },
            ["group2"] = new Dictionary<string, int>
            {
                ["item1"] = 30,
                ["item2"] = 40
            }
        };

        // Ghi Dictionary ra file JSON
        string filePath = "nestedDict1.json";
        WriteDictionaryToJsonFile(filePath, nestedDict);
        Console.WriteLine("Dictionary đã được ghi ra file JSON sử dụng System.Text.Json.");
    }

    public static void WriteDictionaryToJsonFile(string filePath, Dictionary<string, Dictionary<string, int>> dict)
    {
        string jsonString = JsonSerializer.Serialize(dict, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonString);
    }
}

//cách2
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {
        // Tạo một Dictionary mẫu
        Dictionary<string, Dictionary<string, int>> nestedDict = new Dictionary<string, Dictionary<string, int>>
        {
            ["group1"] = new Dictionary<string, int>
            {
                ["item1"] = 10,
                ["item2"] = 20
            },
            ["group2"] = new Dictionary<string, int>
            {
                ["item1"] = 30,
                ["item2"] = 40
            }
        };

        // Ghi Dictionary ra file JSON
        string filePath = "nestedDict2.json";
        WriteDictionaryToJsonFile(filePath, nestedDict);
        Console.WriteLine("Dictionary đã được ghi ra file JSON sử dụng Newtonsoft.Json.");
    }

    public static void WriteDictionaryToJsonFile(string filePath, Dictionary<string, Dictionary<string, int>> dict)
    {
        string jsonString = JsonConvert.SerializeObject(dict, Formatting.Indented);
        File.WriteAllText(filePath, jsonString);
    }
}
