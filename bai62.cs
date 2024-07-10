//cách1Sử dụng System.Text.Json

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        string filePath = "nestedDict.json";
        var dict = ReadJsonFileToDictionary(filePath);
        
        // Hiển thị nội dung của Dictionary
        foreach (var group in dict)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var item in group.Value)
            {
                Console.WriteLine($"  {item.Key}: {item.Value}");
            }
        }
    }

    public static Dictionary<string, Dictionary<string, int>> ReadJsonFileToDictionary(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        var dict = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, int>>>(jsonString);
        return dict;
    }
}
//cách2 Sử dụng Newtonsoft.Json
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Program
{
    public static void Main()
    {
        string filePath = "nestedDict.json";
        var dict = ReadJsonFileToDictionary(filePath);
        
        // Hiển thị nội dung của Dictionary
        foreach (var group in dict)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var item in group.Value)
            {
                Console.WriteLine($"  {item.Key}: {item.Value}");
            }
        }
    }

    public static Dictionary<string, Dictionary<string, int>> ReadJsonFileToDictionary(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        var dict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, int>>>(jsonString);
        return dict;
    }
}
