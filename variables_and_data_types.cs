﻿namespace kodluyoruzRepo;
class variables_and_data_types
{
    static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;

        Console.WriteLine(dt);     /// 23.04.2023 13:45:45

        string date = DateTime.Now.ToString("dd.MM.yyyy");   // sadece gun ay yil olsun.

        Console.WriteLine(date);     /// 23.04.2023

        string hour = DateTime.Now.ToString("HH:mm");   // sadece saat olsun.

        Console.WriteLine(hour);    /// 13:48

        

        Console.ReadKey();
    }
}
