namespace lab05_1
{
    internal class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }

        private double _gpa;
        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Средний балл должен быть в диапазоне от 0 до 10.");
                }
                _gpa = value;
            }
        }

        public Student(string name, string group, double gpa)
        {
            Name = name;
            Group = group;
            GPA = gpa; 
        }

        public bool IsExcellent()
        {
            return GPA >= 8;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Студент: {Name}");
            Console.WriteLine($"Группа: {Group}");
            Console.WriteLine($"Средний балл: {GPA}");

            string excellentStr = IsExcellent() ? "Да" : "Нет";
            Console.WriteLine($"Отличник: {excellentStr}");
        }
    }
}