using System;

namespace ConsoleApp1
{
    namespace StringToLower
    {
        class Program
        {
            static void Main(string[] args)
            {

                string x = "";
                int y;
                Console.WriteLine("Istenilen bir ay daxil edin:");
                x = Console.ReadLine().ToLower();
                switch (x)
                {
                    case "avgust":
                    case "yanvar":
                    case "mart":
                    case "may":
                    case "iyul":
                    case "oktiyabr":
                    case "dekabr":
                        Console.WriteLine("31 gunden ibaretdir");
                        break;
                    case "aprel":
                    case "iyun":
                    case "sentiyabr":
                    case "noyabr":
                        Console.WriteLine("30 gunden ibaretdir");
                        break;
                    case "fevral":
                        Console.WriteLine("Ayi axdardiginiz ili daxil edin");
                        y = int.Parse(Console.ReadLine());
                        if (y % 4 == 0)
                        {
                            Console.WriteLine("29 gunden ibaretdir");
                        }
                        else
                        {
                            Console.WriteLine("28 gunden ibaretdir");
                        }

                        break;
                    default:
                        Console.WriteLine("Duzgun deyer daxil edilmemisdir");
                        break;
                }


            }
        }
    }
}