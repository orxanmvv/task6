using ConsoleApp17.Models;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            int choice;

            do
            {
                Console.WriteLine("1. İşçi əlavə et");
                Console.WriteLine("2. Bütün işçilərə bax");
                Console.WriteLine("0. Proqramı bitir");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Ad: ");
                        string name = Console.ReadLine();
                        Console.Write("Soyad: ");
                        string surname = Console.ReadLine();
                        Console.Write("Yaş: ");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Console.Write("Maaş: ");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        department.AddEmployee(new Employee(name, surname, age, salary));
                        break;
                    case 2:
                        department.ShowEmployeeInfo();
                        break;
                    case 0:
                        Console.WriteLine("Proqram sonlandırılır...");
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim!");
                        break;
                }
            } while (choice != 0);
        }
    }

}

