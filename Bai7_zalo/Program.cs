using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bai7_zalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("LỰA CHỌN");
            Console.WriteLine("a. Tính tổng 2 số nguyên không dấu");
            Console.WriteLine("b. Tính diện tích và chu vi hình chữ nhật(2byte)");
            Console.WriteLine("c. Kiểm tra chẵn lẻ(4byte)");
            Console.WriteLine("d. Tính tổng 2 số nguyên có dấu(1byte)");
            Console.WriteLine("e. Tính tổng dãy số từ 1 đến n(4byte)");
            Console.WriteLine("g. Tính diện tích và chu vi hình chữ nhật(8byte)");
            Console.WriteLine("h. Tìm số lớn nhất trong 3 số");
            Console.WriteLine("k. Tính giai thừa số nguyên không âm n");
            Console.WriteLine("l. Kiểm tra số nguyên tố của số nguyên n");
            Console.WriteLine("m. Kiểm tra số hoàn hảo");
            Console.Write("Nhập lựa chọn của bạn: ");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'a':
                    //Tính tổng 2 số nguyên không dấu
                    sumOfUnsignedInteger();
                    break;
                case 'b':
                    //Tính diện tích và chu vi hình chữ nhật(2byte)
                    calculateAreaAndPerimeter();
                    break;
                case 'c':
                    //Kiểm tra chẵn lẻ(4byte)
                    EvenOrOdd();
                    break;
                case 'd':
                    //Tính tổng 2 số nguyên có dấu(1byte)
                    sumOfInterger();
                    break;
                case 'e':
                    //Tính tổng dãy số từ 1 đến n(4byte)
                    sumOf1toN();
                    break;
                case 'g':
                    //Tính diện tích và chu vi hình chữ nhật(8byte)
                    calculateAreaAndPerimeter1();
                    break;
                case 'h':
                    //Tìm số lớn nhất trong 3 số
                    findMax();
                    break;
                case 'k':
                    //Tính giai thừa số nguyên không âm n
                    factorial();
                    break;
                case 'l':
                    //Kiểm tra số nguyên tố của số nguyên n
                    isPrime();
                    break;
                case 'm':
                    //Kiểm tra số hoàn hảo
                    isPerfectNumber();
                    break;
            //Hàm tính tổng 2 số nguyên không dấu
            static void sumOfUnsignedInteger()
                    {
                        uint x, y;
                        while(true) {
                            try
                            {
                                Console.Write("Nhập số nguyên không dấu thứ nhất (4byte): ");
                                x = uint.Parse(Console.ReadLine());
                                Console.Write("Nhập số nguyên không dấu thứ hai (4byte): ");
                                y = uint.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ. Vui long nhập lại");
                            }
                        }
                        uint sum = x + y;
                        Console.WriteLine("Tổng của 2 số nguyên không dấu trên là: " + sum);
                    }
            //Hàm tính diện tích và chu vi hình chữ nhật (2byte)
            static void calculateAreaAndPerimeter()
                    {
                        ushort x, y;
                        while(true) {
                            try
                            {
                                Console.Write("Nhập chiều dài hình chữ nhật (2byte): ");
                                x = ushort.Parse(Console.ReadLine());
                                Console.Write("Nhập chiều rộng hình chữ nhật (2byte): ");
                                y = ushort.Parse(Console.ReadLine());
                                Console.WriteLine("Diện tích của hình chữ nhật là: " + x * y);
                                break;
                            }catch (Exception e) 
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ. Vui long nhập lại");
                            }
                        }
                        Console.WriteLine("Chu vi của hình chữ nhật là: " + (x + y) * 2);
                    }
            //Hàm kiểm tra chẵn lẻ(4byte)
            static void EvenOrOdd()
                    {
                        uint x, y;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Nhập một số nguyên không dấu (4byte): ");
                                x = uint.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ. Vui long nhập lại");
                            }
                        }
                        if (x % 2 == 0)
                        {
                            Console.WriteLine("Số bạn nhập là số chẵn");
                        }
                        else
                        {
                            Console.WriteLine("Số bạn nhập là số lẻ");
                        }
                    }
            //Tính tổng 2 số nguyên có dấu(1byte)
            static void sumOfInterger()
                    {
                        byte x, y;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Nhập số nguyên có dấu thứ nhất (1byte): ");
                                x = byte.Parse(Console.ReadLine());
                                Console.Write("Nhập số nguyên có dấu thứ hai (1byte): ");
                                y = byte.Parse(Console.ReadLine());
                                break;
                            }catch(Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ. Vui long nhập lại");
                            }
                        }
                        
                        Console.WriteLine("Tổng của 2 số nguyên có dấu trên là: " + x + y);
                    }
            //Tính tổng dãy số từ 1 đến n(4byte)
            static void sumOf1toN()
                    {
                        uint n;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Nhập vào một số n (4byte): ");
                                n = uint.Parse(Console.ReadLine());
                                break;
                            }catch(Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ. Vui long nhập lại");
                            }
                        }
                        int sum = 0;
                        for(int i = 1; i <= n; i++)
                        {
                            sum += i;
                        }
                        Console.WriteLine($"Tổng dãy số từ 1 đến {n} là: " + sum);
                    }
            //Tính diện tích và chu vi hình chữ nhật(8byte)
            static void calculateAreaAndPerimeter1()
                    {
                        ulong x, y;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Nhập chiều dài hình chữ nhật (8byte): ");
                                x = ulong.Parse(Console.ReadLine());
                                Console.Write("Nhập chiều rộng hình chữ nhật (8byte): ");
                                y = ulong.Parse(Console.ReadLine());
                                break;
                            }catch (Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ. Vui long nhập lại");
                            }
                        }
                        Console.WriteLine("Diện tích của hình chữ nhật là: " + x * y);
                        Console.WriteLine("Chu vi của hình chữ nhật là: " + (x + y) * 2);
                    }
            //Tìm số lớn nhất trong 3 số
            static void findMax()
                    {
                        float a, b, c;
                        while (true)
                        {
                            try
                            {
                                Console.Write("Nhập số thứ nhất: ");
                                a = float.Parse(Console.ReadLine());
                                Console.Write("Nhập số thứ hai: ");
                                b = float.Parse(Console.ReadLine());
                                Console.Write("Nhập số thứ ba: ");
                                c = float.Parse(Console.ReadLine());
                                break;
                            }catch(Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ. Vui long nhập lại");
                            }
                        }
                        if(a>b && a>c)
                        {
                            Console.WriteLine("Số lớn nhất trong ba số là: " + a);
                        }else if(b>a && b>c)
                        {
                            Console.WriteLine("Số lớn nhất trong ba số là: " + b);
                        }
                        else
                        {
                            Console.WriteLine("Số lớn nhất trong ba số là: " + c);
                        }
                    }
            //Tính giai thừa số nguyên không âm n
            static void factorial()
                    {
                        uint n;
                        while(true) {
                            try
                            {
                                Console.Write("Nhập vào một số nguyên không âm: ");
                                n = uint.Parse(Console.ReadLine());
                                break;
                            }catch(Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ.Vui long nhập lại");
                            }
                        }
                        int x = 1;
                        for(int i = 1; i<=n; i++)
                        {
                            x *= i;
                        }
                        Console.WriteLine($"Giai thừa của {n} là: " + x);
                    }
            //Kiểm tra số nguyên tố của số nguyên n
            static void isPrime()
                    {
                        int n;
                        while(true)
                        {
                            try
                            {
                                Console.Write("Nhập một số nguyên: ");
                                n = int.Parse(Console.ReadLine());
                                break;
                            }catch (Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ.Vui long nhập lại");
                            }
                        }
                        if(n < 2)
                        {
                            Console.WriteLine("Đây không phải là số nguyên tố:");
                        }
                        else
                        {
                            for(int i = 2; i < Math.Sqrt(n); i++)
                            {
                                if(n % i == 0)
                                {
                                    Console.WriteLine("Đây không phải là số nguyên tố:");
                                }else
                                {
                                    Console.WriteLine("Đây là số nguyên tố");
                                }
                            }
                        }
                    }
            //Kiểm tra số hoàn hảo
            static void isPerfectNumber()
                    {
                        float num;
                        while(true)
                        {
                            try
                            {
                                Console.Write("Nhập một số: ");
                                num = float.Parse(Console.ReadLine());
                                break;
                            }catch(Exception e)
                            {
                                Console.WriteLine("Số bạn nhập khong hợp lệ.Vui long nhập lại");
                            }
                        }
                        if (num <= 1)
                        {
                            Console.WriteLine("Đây không phải số hoàn hảo");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 1; i <= num / 2; i++)
                            {
                                if (num % i == 0)
                                {
                                    sum += i;
                                }
                            }
                            if (sum == num)
                            {
                                Console.WriteLine($"{num} là số hoàn hảo.");
                            }
                            else
                            {
                                Console.WriteLine($"{num} không phải là số hoàn hảo.");
                            }
                        }                       
                    }
            }
        }
    }
}
