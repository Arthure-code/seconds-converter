# seconds-converter

Converts a number of seconds into years, days, hours, minutes and seconds.

## Getting started

```bash
git clone https://github.com/Arthure-code/seconds-converter.git
cd seconds-converter
dotnet run --project ConvertisseurSecondes
```

```
Enter the number of seconds: 100000000

        3 years, 61 days, 15 hours, 46 minutes, 40 seconds
```

Requires the [.NET SDK 9.0](https://dotnet.microsoft.com/download) or later.

## How it works

The duration is broken down through successive integer divisions, from the
largest unit to the smallest, carrying the remainder at each step.

A year is counted as 365.25 days — the Julian year — to account for leap years,
which is 31,557,600 seconds. A flat 365-day year would drift by roughly six
hours per converted year.

Input is validated with `double.TryParse`: non-numeric and negative values are
rejected with an explicit message rather than throwing.

## License

MIT
