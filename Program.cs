System.Console.WriteLine(DateTime.Now);// Günün tarihini getirir
System.Console.WriteLine(DateTime.Now.Date); // sadece tarihi ytazar saati 00:00 olarak alır
System.Console.WriteLine(DateTime.Now.Day);
System.Console.WriteLine(DateTime.Now.Month);
System.Console.WriteLine(DateTime.Now.Year);
System.Console.WriteLine(DateTime.Now.Hour);
System.Console.WriteLine(DateTime.Now.Minute);
System.Console.WriteLine(DateTime.Now.Second);


System.Console.WriteLine(DateTime.Now.DayOfWeek);
System.Console.WriteLine(DateTime.Now.DayOfYear);

System.Console.WriteLine(DateTime.Now.ToLongDateString());
System.Console.WriteLine(DateTime.Now.ToShortDateString());
System.Console.WriteLine(DateTime.Now.ToLongTimeString());
System.Console.WriteLine(DateTime.Now.ToShortTimeString());


System.Console.WriteLine(DateTime.Now.AddDays(2)); // güncel tarihin üstüne 2 gün ekler
System.Console.WriteLine(DateTime.Now.AddHours(3)); // şu an ki saatin üstüne 3 ekler
System.Console.WriteLine(DateTime.Now.AddYears(10)); // Şu an ki yılın üstüne 10 ekler

// DateTime Format

System.Console.WriteLine(DateTime.Now.ToString("dd")); // 24
System.Console.WriteLine(DateTime.Now.ToString("ddd")); // Sat
System.Console.WriteLine(DateTime.Now.ToString("dddd")); // Saturday

System.Console.WriteLine(DateTime.Now.ToString("MM")); // 04
System.Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
System.Console.WriteLine(DateTime.Now.ToString("MMMM")); // April

System.Console.WriteLine(DateTime.Now.ToString("yy")); // 22
System.Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022
 

 // Math Kütüphanesi

  System.Console.WriteLine(Math.Abs(-21)); // mutlak değer
  System.Console.WriteLine(Math.Ceiling(22.3)); //Üste yuvarlar ->23
  System.Console.WriteLine(Math.Floor(22.7));// Alta yuvarlar ->22
  System.Console.WriteLine(Math.Round(22.3));// Yakına yuvarlar ->22
  System.Console.WriteLine(Math.Round(22.7));// Yakına yuvarlar ->23

  System.Console.WriteLine(Math.Pow(4,3));// üst alır -> 4 üssü 3
  System.Console.WriteLine(Math.Sqrt(9)); // Karakök alır -> 3
  System.Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logaritmik karşılığını verir
  System.Console.WriteLine(Math.Exp(3));// e üzeri 3 ü verir
  System.Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı


  System.Console.WriteLine(Math.Max(2,6)); // maksimumu  yazar -> 6
  System.Console.WriteLine(Math.Min(2,6)); // minimumu getirir -> 2
  