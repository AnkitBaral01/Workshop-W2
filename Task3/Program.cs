// 1. Declare variables of different data types
byte byteValue = 255;
short shortValue = 32000;
int intValue = 100;
long longValue = 1000000;
float floatValue = 3.14f;
double doubleValue = 3.14159;
decimal decimalValue = 3.14m;
char charValue = 'A';
bool boolValue = true;

// 2. TYPE CONVERSIONS (REQUIRED)
string intToString = 42.ToString(); // Convert int 42 to string
double stringToDouble = Convert.ToDouble("3.14"); // Convert string "3.14" to double

// 3. Print with TYPE INFORMATION (REQUIRED)
Console.WriteLine($"byte: {byteValue} (Type: {byteValue.GetType()})");
Console.WriteLine($"short: {shortValue} (Type: {shortValue.GetType()})");
Console.WriteLine($"int: {intValue} (Type: {intValue.GetType()})");
Console.WriteLine($"long: {longValue} (Type: {longValue.GetType()})");
Console.WriteLine($"float: {floatValue} (Type: {floatValue.GetType()})");
Console.WriteLine($"double: {doubleValue} (Type: {doubleValue.GetType()})");
Console.WriteLine($"decimal: {decimalValue} (Type: {decimalValue.GetType()})");
Console.WriteLine($"char: {charValue} (Type: {charValue.GetType()})");
Console.WriteLine($"bool: {boolValue} (Type: {boolValue.GetType()})");

// 4. Print the converted variables
Console.WriteLine($"int to string: {intToString} (Type: {intToString.GetType()})");
Console.WriteLine($"string to double: {stringToDouble} (Type: {stringToDouble.GetType()})");