// Converts a number of seconds into years, days, hours, minutes and seconds.

// The Julian year averages the leap day over a four-year cycle. A flat 365-day
// year would drift by about six hours for every year converted.
const double DaysPerYear = 365.25;
const double HoursPerDay = 24.0;
const double MinutesPerHour = 60.0;
const double SecondsPerMinute = 60.0;

// Each unit is built from the previous one, so no product is computed twice.
double secondsPerHour = MinutesPerHour * SecondsPerMinute;
double secondsPerDay = HoursPerDay * secondsPerHour;
double secondsPerYear = DaysPerYear * secondsPerDay;

Console.Write("\n\n\n----------------------------  seconds-converter  ---------------------------- \n\n\n\n\n\n ");
Console.Write("Enter the number of seconds: ");

// ReadLine returns null once the input stream is closed, hence the nullable type.
string? input = Console.ReadLine();

// TryParse reports failure through its return value rather than throwing, so a
// malformed entry stays an ordinary branch instead of an exception to catch.
if (!double.TryParse(input, out double totalSeconds) || totalSeconds < 0)
{
    Console.WriteLine("\n\n\n\t\t\t\t\t Invalid input. Please enter a valid number of seconds.");
    return;
}

// The units run from largest to smallest. Each one takes what it can and hands
// the remainder to the next, which is a single step repeated five times.
(string Name, double Size)[] units =
{
    ("years", secondsPerYear),
    ("days", secondsPerDay),
    ("hours", secondsPerHour),
    ("minutes", SecondsPerMinute),
    ("seconds", 1.0),
};

List<string> parts = [];

foreach ((string name, double size) in units)
{
    parts.Add($"{(int)(totalSeconds / size)} {name}");
    totalSeconds %= size;
}

Console.WriteLine($"\n\n\n\t{string.Join(", ", parts)}");
