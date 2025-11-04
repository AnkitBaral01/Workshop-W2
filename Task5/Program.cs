Console.WriteLine("TASK 5: DateTime");

DateTime birthDate = new DateTime(2004, 4, 11);
DateTime currentDate = DateTime.Now;

TimeSpan ageTimeSpan = currentDate - birthDate;
int ageInYears = (int)(ageTimeSpan.TotalDays / 365.25);

DateTime birthDatePlus10 = birthDate.AddDays(10);

Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
Console.WriteLine($"Current date: {currentDate:yyyy-MM-dd}");
Console.WriteLine($"Age: {ageInYears} years");
Console.WriteLine($"Birthdate + 10 days: {birthDatePlus10:yyyy-MM-dd}");