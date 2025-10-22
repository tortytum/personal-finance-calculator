/using System.ComponentModel.Design;
using System.Runtime.CompilerServices;




class Program
{
    public static int sum = 0;
    public static string menuItem;
    public static List<string> operations = new();

    static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.WriteLine($"Ваша сумма: {sum} ");
        Console.WriteLine("Напишите сумму");
        while (true)
        {
            bool result = int.TryParse(Console.ReadLine(), out int number);
            if (result == true)
            {
                sum = number;
                break;

            }
        }
        //Console.WriteLine($"Ваша сумма: {sum} ");
        Console.WriteLine("Действия:");
        Console.WriteLine("1 - баланс");
        Console.WriteLine("2 - список всех операций");
        Console.WriteLine("3 - добавить новую операцию");

        while (true)
        {
            Console.WriteLine("Действие:");
            menuItem = Console.ReadLine();
            switch (menuItem)
            {
                case "1":
                    Balance();
                    break;
                case "2":
                    AllOperations();
                    break;
                case "3":
                    AddOperation();
                    break;
                default:
                    Console.WriteLine("Нет такого пункта в меню");
                    break;
            }
        }

    }

    private static void AddOperation()
    {
        Console.WriteLine("+/- | сумма | категория | дата");
        string operation = Console.ReadLine();
        operations.Add(operation);
        string[] oper = operation.Split(" ");
        if (oper[0] == "+")
        {
            sum += Convert.ToInt32(oper[1]);
        }
        else if (oper[0] == "-")
        {
            if (sum >= Convert.ToInt32(oper[1]))
            {
                sum -= Convert.ToInt32(oper[1]);
            }
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }

    private static void Balance()
    {
        Console.WriteLine($"Ваша сумма: {sum} ");
    }

    private static void AllOperations()
    {
        if (operations.Count == 0)
        {
            Console.WriteLine("Операций не производилось");
        }
        else
        {
            foreach (string op in operations)
            {
                Console.WriteLine(op);
            }
        }


    }
}




