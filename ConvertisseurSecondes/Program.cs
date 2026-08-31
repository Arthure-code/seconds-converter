// Converts a number of seconds into years, days, hours, minutes and seconds.

// The Julian year averages the leap day over a four-year cycle. A flat 365-day
// year would drift by about six hours for every year converted.
const double DaysPerYear = 365.25;
const double HoursPerDay = 24.0;
const double MinutesPerHour = 60.0;
const double SecondsPerMinute = 60.0;

double secondsPerYear = DaysPerYear * HoursPerDay * MinutesPerHour * SecondsPerMinute;
double secondsPerDay = HoursPerDay * MinutesPerHour * SecondsPerMinute;
double secondsPerHour = MinutesPerHour * SecondsPerMinute;

Console.Write("\n\n\n----------------------------  seconds-converter  ---------------------------- \n\n\n\n\n\n ");
Console.Write("Enter the number of seconds: ");

// ReadLine returns null once the input stream is closed, hence the nullable type.
string? input = Console.ReadLine();

// TryParse reports failure through its return value rather than throwing, so a
// malformed entry stays an ordinary branch instead of an exception to catch.
if (double.TryParse(input, out double totalSeconds) && totalSeconds >= 0)
{
    // Each unit takes what it can; the remainder is carried down to the next one.
    int years = (int)(totalSeconds / secondsPerYear);
    totalSeconds %= secondsPerYear;

    int days = (int)(totalSeconds / secondsPerDay);
    totalSeconds %= secondsPerDay;

    int hours = (int)(totalSeconds / secondsPerHour);
    totalSeconds %= secondsPerHour;

    int minutes = (int)(totalSeconds / SecondsPerMinute);
    totalSeconds %= SecondsPerMinute;

    int seconds = (int)totalSeconds;

    Console.WriteLine($"\n\n\n\t{years} years, {days} days, {hours} hours, {minutes} minutes, {seconds} seconds");
}
else
{
    Console.WriteLine("\n\n\n\t\t\t\t\t Invalid input. Please enter a valid number of seconds.");
}
