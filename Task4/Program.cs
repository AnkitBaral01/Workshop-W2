// Task 4: Arrays
Console.WriteLine("TASK 4: Arrays");

int[] numbers = { 7, 0, 9, 1, 5 };

Console.WriteLine($"First number: {numbers[0]}");
Console.WriteLine($"Second number: {numbers[1]}");
Console.WriteLine($"Third number: {numbers[2]}");
Console.WriteLine($"Fourth number: {numbers[3]}");
Console.WriteLine($"Fifth number: {numbers[4]}");

Array.Sort(numbers);
Console.WriteLine($"After sort - First: {numbers[0]}");

Array.Reverse(numbers);
Console.WriteLine($"After reverse - First: {numbers[0]}");

int index = Array.IndexOf(numbers, 0);
Console.WriteLine($"Index of 0: {index}");