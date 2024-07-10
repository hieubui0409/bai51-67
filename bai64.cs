using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration.Attributes;

public class Program
{
    public static void Main()
    {
        // Tạo một mảng 2 chiều các số thực 4 byte mẫu
        float[,] matrix = new float[,]
        {
            { 1.1f, 2.2f, 3.3f },
            { 4.4f, 5.5f, 6.6f },
            { 7.7f, 8.8f, 9.9f }
        };

        // Gọi hàm để ghi mảng vào file CSV
        string filePath = "matrix.csv";
        Write2DArrayToCsv(filePath, matrix);
        Console.WriteLine($"Đã ghi mảng 2 chiều vào file CSV: {filePath}");
    }

    public static void Write2DArrayToCsv(string filePath, float[,] matrix)
    {
        // Mở file để ghi
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            // Vô hiệu hóa việc ghi header
            csv.Configuration.HasHeaderRecord = false;

            // Ghi từng phần tử của mảng vào file CSV
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    csv.WriteField(matrix[i, j]);
                }
                csv.NextRecord(); // Xuống dòng sau khi ghi một hàng
            }
        }
    }
}
