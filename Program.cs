
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


// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// double result = CalculateScholarship(2000, 15);
// Console.WriteLine(result);

// bool isEligibleForBonus(double averageGrade)
// {
//     if (averageGrade >= 4.5)
//         return true;
//     else
//         return false;
// }



double calculateAverageGrade(int[] grades)
{
    int sum = 0;
    foreach (int grade in grades)
    {
        sum += grade;
    }
    return (double)sum / grades.Length;
}
int CountFives(int[] grades)
{
    int fives = 0;
    foreach (int grade in grades)
    {
        if (grade == 5)
        {
            fives += 1;
        }
    }
    return fives;
}
int[] grades = { 4, 5, 3, 5, 4 };
double average = calculateAverageGrade(grades);
int count = CountFives(grades);
Console.WriteLine(average);
Console.WriteLine(count);
