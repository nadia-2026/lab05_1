using lab05_1;

try
{
    Student student1 = new Student("Иван Иванов", "ИС-21", 8.7);
    student1.PrintInfo();
    Console.WriteLine(); 

    Student student2 = new Student("Анна Петрова", "ИС-21", 6.5);
    student2.PrintInfo();
    Console.WriteLine();

    Console.WriteLine("Попытка создать студента с баллом 11:");
    Student student3 = new Student("Ошибка", "Тест", 11);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}