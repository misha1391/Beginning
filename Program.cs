// To run program and create project write in powershell
// winget install Microsoft.DotNet.SDK.10

// To create project write "dotnet new console" in an empty folder

// Этот язык програмирования является и компелируемым и инерпретируемым
#region test

// namespace begining
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Hello world!");
//         }
//     }
// }

#endregion
#region test 1

// Console.WriteLine("Hello, World!");

#endregion
#region test 2

// Console.Write("Enter your name: ");
// var name = Console.ReadLine();
// Console.WriteLine($"Hello {name}");

// var - Автоопределение типа данных, в данном случае лучше написать string
// Console.Write(...) - Выводит данные в консоль
// Console.WriteLine(...) - Делает тоже, что и выше, но добавляет "/n" в конец
// Console.ReadLine() - Считывает вывод
// Console.Read() - Считывает и вроде преобразовывает в число("" - 13, "ьшырф" - 1100)

#endregion
#region test 3

// for(int i = 0; i < 5; i++)
// {
//     Console.WriteLine(i);
// }

#endregion
#region test 4

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(num.GetType());
// Console.WriteLine(num);

// C# Не умеет преобразовывать в другие типы неявно
// У каждого числогого значения есть методы Parse и TryParse
// Parse преобразовывают строку в указанный тип данных
// А TryParse проверяет, можно ли преобразовать, возвращает bool

#endregion
#region test 5(creating calc)

int plus(int num1, int num2) { return num1 + num2; }
int minus(int num1, int num2) { return num1 - num2; }
int multiple(int num1, int num2) { return num1 * num2; }
int division(int num1, int num2) { return num1 / num2; }
int pow(int num1, int num2) { return (int)Math.Pow(num1, num2); }

var possibleOperations = new Dictionary<string, Func<int, int, int>>() {{"+", plus}, {"-", minus}, {"*", multiple}, {"/", division}, {"^", pow}};
// Есть Func и Action
// Action<in, in, ...> требует функцию, которая ничего не возвращает, может иметь несколько аргументов
// Func<in, in, ..., out> требует функцию, которая уже возвращает значение, может иметь несколько аргументов

// Для создания массива нужно написать тип для массива и присвоить значение {0, 1, ...}
// int array = {0, 1, 2, 3};

Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Введите оператор: ");
string oper = Console.ReadLine();

Console.Write("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(possibleOperations[oper](num1, num2));

#region oldVersion

// test
// if (oper == "+")
// {
//     Console.WriteLine(num1 + num2);
// }
// else if (oper == "-")
// {
//     Console.WriteLine(num1 - num2);
// }
// else if (oper == "*")
// {
//     Console.WriteLine(num1 * num2);
// }
// else if (oper == "/")
// {
//     Console.WriteLine((float)num1 / num2);
// }

#endregion
#endregion
#region test 6

int? num = null;
if (num.HasValue)
{
    Console.WriteLine($"num соддержит {num}");
}
else
{
    Console.WriteLine("num соддержит ничего");
}

#endregion