using System.Globalization;

DateTime d1 = DateTime.Now;
DateTime d2 = new DateTime(2018, 11, 25);
DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
DateTime d5 = DateTime.Today;
DateTime d6 = DateTime.UtcNow;
DateTime d7 = DateTime.Parse("2000-08-15");
DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d9 = DateTime.Parse("15/08/2000");
DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");
DateTime d11 = DateTime.ParseExact("2000-05-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
DateTime d12 = DateTime.ParseExact("2000-05-15 13:05:58", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

Console.WriteLine(d1);
Console.WriteLine(d2);
Console.WriteLine(d3);
Console.WriteLine(d4);
Console.WriteLine(d5);
Console.WriteLine(d6);
Console.WriteLine(d7);
Console.WriteLine(d8);
Console.WriteLine(d9);
Console.WriteLine(d10);
Console.WriteLine(d11);
Console.WriteLine(d12);

DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

Console.WriteLine(d);
Console.WriteLine("1) Date: " + d.Date);
Console.WriteLine("2) Day: " + d.Day);
Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
Console.WriteLine("5) Hour: " + d.Hour);
Console.WriteLine("6) Kind: " + d.Kind);
Console.WriteLine("7) Millisecond: " + d.Millisecond);
Console.WriteLine("8) Minute: " + d.Minute);
Console.WriteLine("9) Month: " + d.Month);
Console.WriteLine("10) Second: " + d.Second);
Console.WriteLine("11) Ticks: " + d.Ticks);
Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
Console.WriteLine("13) Year: " + d.Year);

DateTime d13 = new DateTime(2001, 8, 15, 13, 45, 58);
string s1 = d13.ToLongDateString();
string s2 = d13.ToLongTimeString();
string s3 = d13.ToShortDateString();
string s4 = d13.ToShortTimeString();
string s5 = d1.ToString();
string s6 = d13.ToString("yyyy-MM-dd HH:mm:ss");
string s7 = d13.ToString("yyyy-MM-dd HH:mm:ss.fff");

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine(s4);
Console.WriteLine(s5);
Console.WriteLine(s6);
Console.WriteLine(s7);

DateTime d14 = new DateTime(2001, 8, 15, 13, 45, 58);

DateTime d15 = d.AddHours(2);

DateTime d16 = d.AddMinutes(3);

Console.WriteLine(d);
Console.WriteLine(d2);
Console.WriteLine(d3);

DateTime d17 = new DateTime(2000, 10, 15);

DateTime d18 = new DateTime(2000, 10, 18);

DateTime d19 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
DateTime d20 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
DateTime d21 = new DateTime(2000, 8, 15, 13, 5, 58);

Console.WriteLine("d1: " + d19);
Console.WriteLine("d1 Kind: " + d19.Kind);
Console.WriteLine("d1 to Local: " + d19.ToLocalTime());
Console.WriteLine("d1 to Utc: " + d19.ToUniversalTime());
Console.WriteLine();
Console.WriteLine("d2: " + d20);
Console.WriteLine("d2 Kind: " + d20.Kind);
Console.WriteLine("d2 to Local: " + d20.ToLocalTime());
Console.WriteLine("d2 to Utc: " + d20.ToUniversalTime());
Console.WriteLine();
Console.WriteLine("d3: " + d21);
Console.WriteLine("d3 Kind: " + d21.Kind);
Console.WriteLine("d3 to Local: " + d21.ToLocalTime());
Console.WriteLine("d3 to Utc: " + d21.ToUniversalTime());

DateTime d22 = DateTime.Parse("2000-08-15 13:05:58");
DateTime d23 = DateTime.Parse("2000-08-15T13:05:58Z");

Console.WriteLine(d22);
Console.WriteLine(d23);
Console.WriteLine(d23.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));