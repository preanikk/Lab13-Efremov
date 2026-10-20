
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


void PrintStudentCard(string name, int age, string group)
{
    Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
}
PrintStudentCard("Егор", 18, "ИСП67");
PrintStudentCard("Валерия", 17, "ЮСП52");