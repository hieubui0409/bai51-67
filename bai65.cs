using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

public class Program
{
    public static void Main()
    {
        // Tạo một Dictionary mẫu với Value là số thực 8 byte (double)
        Dictionary<string, double> dataDict = new Dictionary<string, double>
        {
            { "Item1", 3.14 },
            { "Item2", 6.28 },
            { "Item3", 9.42 }
        };

        // Gọi hàm để ghi Dictionary vào file CSV
        string filePath = "data.csv";
        WriteDictionaryToCsv(filePath, dataDict);
        Console.WriteLine($"Đã ghi Dictionary vào file CSV: {filePath}");
    }

    public static void WriteDictionaryToCsv(string filePath, Dictionary<string, double> dict)
    {
        // Sử dụng CsvHelper để ghi vào file CSV
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            // Cấu hình để ghi header
            csv.Configuration.HasHeaderRecord = true;

            // Ghi các dòng dữ liệu từ Dictionary vào file CSV
            foreach (var item in dict)
            {
                csv.WriteField(item.Key); // Ghi key làm cột đầu tiên
                csv.WriteField(item.Value); // Ghi value làm cột thứ hai
                csv.NextRecord(); // Xuống dòng cho mỗi record
            }
        }
    }
}
