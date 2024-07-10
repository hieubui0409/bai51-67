using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

public class Program
{
    public static void Main()
    {
        // Tên file CSV cần đọc
        string filePath = "data.csv";

        // Gọi hàm để đọc file CSV vào mảng 2 chiều
        double[,] dataArray = ReadCsvFileTo2DArray(filePath);

        // Kiểm tra và hiển thị mảng 2 chiều đã đọc
        if (dataArray != null)
        {
            Console.WriteLine("Dữ liệu từ file CSV:");
            Display2DArray(dataArray);
        }
        else
        {
            Console.WriteLine($"Không thể đọc dữ liệu từ file CSV: {filePath}");
        }
    }

    public static double[,] ReadCsvFileTo2DArray(string filePath)
    {
        try
        {
            List<List<double>> data = new List<List<double>>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                // Cấu hình để không xử lý header
                csv.Configuration.HasHeaderRecord = false;

                // Đọc tất cả các dòng từ file CSV
                var records = csv.GetRecords<dynamic>();

                // Lặp qua các dòng và thêm vào mảng 2 chiều
                foreach (var record in records)
                {
                    List<double> row = new List<double>();
                    foreach (var value in record)
                    {
                        double number;
                        if (double.TryParse(value.Value.ToString(), out number))
                        {
                            row.Add(number);
                        }
                    }
                    data.Add(row);
                }
            }

            // Chuyển đổi List<List<double>> thành mảng 2 chiều double[,]
            int rowCount = data.Count;
            int colCount = data.Count > 0 ? data[0].Count : 0;
            double[,] dataArray = new double[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                {
                    dataArray[i, j] = data[i][j];
                }
            }

            return dataArray;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc file CSV: {ex.Message}");
            return null;
        }
    }

    public static void Display2DArray(double[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
