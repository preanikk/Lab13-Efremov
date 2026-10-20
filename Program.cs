
// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader()
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа N 13");
//     Console.WriteLine("0_0");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
//     Console.WriteLine("Дата формирования отчета 20.10.26");
// }


// void PrintStudentCard(string name, int age, string group)
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
// }
// PrintStudentCard("Егор", 18, "ИСП67");
// PrintStudentCard("Валерия", 17, "ЮСП52");


using System.IO.Pipelines;

double CalculateScholarship(double baseAmount, double bonusPercent)
{
    return baseAmount + baseAmount * bonusPercent / 100;
}

// double result = CalculateScholarship(2000, 15);
// Console.WriteLine(result);

// bool isEligibleForBonus(double averageGrade)
// {
//     if (averageGrade >= 4.5)
//         return true;
//     else
//         return false;
// }
// double averageGrade = 4.2;
// double result;
// if (isEligibleForBonus(averageGrade))
//     result = CalculateScholarship(2000, 15);
// else
//     result = CalculateScholarship(2000, 0);
// Console.WriteLine(result);



// double calculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }
// int CountFives(int[] grades)
// {
//     int fives = 0;
//     foreach (int grade in grades)
//     {
//         if (grade == 5)
//         {
//             fives += 1;
//         }
//     }
//     return fives;
// }
// int[] grades = { 4, 5, 3, 5, 4 };
// double average = calculateAverageGrade(grades);
// int count = CountFives(grades);
// Console.WriteLine(average);
// Console.WriteLine(count);


// class Program {
//     static void Main() {
//     Console.WriteLine(Add(2, 3)); // вызовет первый вариант: int Add(int, int) → 5
// Console.WriteLine(Add(2.5, 3.5)); // вызовет второй вариант: double Add(double, double) → 6.0
// Console.WriteLine(Add(2, 3, 4)); // вызовет третий вариант: int Add(int, int, int) → 9
//     }
// static int Add(int a, int b) {
//     return a + b;
//     }
// static double Add(double a, double b) {
//     return a + b;
//     }
// static int Add(int a, int b, int c) {
//     return a + b + c;
//     }
// }


// //Задача Б

// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Имя: {name}, Возраст {age}");
// }
// PrintPerson("Олег", 2);
// PrintPerson("ОНТОН", 12);

// // Задача В

// bool IsEven(int number)
// {
//     if (number % 2 == 0)
//         return true;
//     else
//         return false;
// }
// Console.WriteLine(IsEven(2));


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


// Вариант 3

bool isPositive(int number)
{
    if (number >= 0)
        return true;
    else
        return false;
}
Console.WriteLine(isPositive(67));


// Вариант 10

bool IsPalindrome(string word)
{
    int first = 0;
    int last = word.Length - 1;
    while (first < last)
    {
        if (word[first] != word[last])
            return false;
        first++;
        last--;
    }
    return true;
}
Console.WriteLine(IsPalindrome("арара"));