TimeSpan t1 = new TimeSpan(0, 1, 30);
TimeSpan t2 = new TimeSpan();
TimeSpan t3 = new TimeSpan(900000000L);
TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);


Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);
Console.WriteLine(t4);
Console.WriteLine(t5);

TimeSpan t6 = TimeSpan.MaxValue;
TimeSpan t7 = TimeSpan.MinValue;
TimeSpan t8 = TimeSpan.Zero;

Console.WriteLine(t1);
Console.WriteLine(t2);
Console.WriteLine(t3);

TimeSpan t9 = new TimeSpan(2, 3, 5, 7, 11);

Console.WriteLine(t9);
Console.WriteLine("Days: " + t9.Days);
Console.WriteLine("Hours: " + t9.Hours);
Console.WriteLine("Minutes: " + t9.Minutes);
Console.WriteLine("Milliseconds: " + t9.Milliseconds);
Console.WriteLine("Seconds: " + t9.Seconds);
Console.WriteLine("Ticks: " + t9.Ticks);
Console.WriteLine("TotalDays: " + t9.TotalDays);
Console.WriteLine("TotalHours: " + t9.TotalHours);
Console.WriteLine("TotalMinutes: " + t9.TotalMinutes);
Console.WriteLine("TotalSeconds: " + t9.TotalSeconds);
Console.WriteLine("TotalMilliseconds: " + t9.TotalMilliseconds);

TimeSpan t10 = new TimeSpan(1, 30, 10);
TimeSpan t11 = new TimeSpan(0, 10, 5);

TimeSpan sum = t10.Add(t11);
TimeSpan dif = t10.Subtract(t11);
TimeSpan mult = t11.Multiply(2.0);
TimeSpan div = t11.Divide(2.0);

Console.WriteLine(sum);
Console.WriteLine(dif);
Console.WriteLine(mult);
Console.WriteLine(div);