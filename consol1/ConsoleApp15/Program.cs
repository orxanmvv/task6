using ConsoleApp15.Models;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                Console.WriteLine("1. Employee əlavə et");
                Console.WriteLine("2. Bütün işçilərə bax");
                Console.WriteLine("0. Proqramı bitir");
                string input = Console.ReadLine();
                Department department1 = new Department();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("adinizi daxil edin:");
                        string name = Console.ReadLine();
                        Console.WriteLine("soyadinizi daxil edin");
                        string surname = Console.ReadLine();
                        Console.WriteLine("yasinizi daxil edin");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("ID ni daxil edin");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("salaryni daxil edin");
                        int salary = Convert.ToInt32(Console.ReadLine());
                        //department1.AddEmployee = (new Employee(name, surname, age,salary));
                        Employee employee1= new Employee(name,surname,age,salary);
                        department1.AddEmployee(employee1);
                        break;
                    case "2":
                        department1.ShowEmployeeInfo();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("duzgun secim edin!!!!");
                        break;
                }

            } while (exit != true);


           

        }
    }
}
