using lab05_1;

try
{
    Box box = new Box(10, 5, 4);

    box.PrintBox();

    Console.WriteLine($"\nПоместится ли объем 100? {box.IsFit(100)}"); 
    Console.WriteLine($"Поместится ли объем 250? {box.IsFit(250)}"); 
    Console.WriteLine("\n--- Меняем высоту на 2 ---");
    box.H = 2;
    box.PrintBox();
    Console.WriteLine("\n--- Попытка установить длину -5 ---");
    box.L = -5;
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}