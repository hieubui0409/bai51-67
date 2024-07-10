using System;
using System.Text.Json;

public class Circle
{
    public double dien_tich { get; set; }
    public double chu_vi { get; set; }
    public double duong_kinh { get; set; }
}

public class Program
{
    // Hàm tính diện tích, chu vi, và đường kính, trả về JSON string
    public static string CalculateCircleProperties(double r)
    {
        Circle circle = new Circle
        {
            dien_tich = Math.PI * Math.Pow(r, 2),
            chu_vi = 2 * Math.PI * r,
            duong_kinh = 2 * r
        };
        
        return JsonSerializer.Serialize(circle);
    }

    public static void Main(string[] args)
    {
        double r;
        while (true)
        {
            Console.Write("Nhập bán kính r: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out r) && r > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        string result = CalculateCircleProperties(r);
        Console.WriteLine("Kết quả: " + result);
    }
}
