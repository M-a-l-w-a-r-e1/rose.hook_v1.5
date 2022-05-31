using System;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░   ░░░░░");
Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒   ▒▒▒▒▒");
Console.WriteLine("▒  ▒    ▒▒▒▒   ▒▒▒▒▒▒     ▒▒▒▒▒   ▒▒▒▒▒▒▒▒▒   ▒▒▒▒▒▒▒▒▒   ▒▒▒▒▒▒▒▒   ▒▒▒▒▒   ▒▒   ");
Console.WriteLine("▓▓   ▓▓▓▓▓   ▓▓   ▓▓   ▓▓▓▓▓▓  ▓▓▓   ▓▓▓▓▓▓     ▓▓▓▓▓   ▓▓   ▓▓▓   ▓▓   ▓▓   ▓   ▓");
Console.WriteLine("▓▓   ▓▓▓▓   ▓▓▓▓   ▓▓▓    ▓▓         ▓▓▓▓▓▓   ▓▓  ▓▓   ▓▓▓▓   ▓   ▓▓▓▓   ▓     ▓▓▓");
Console.WriteLine("▓▓   ▓▓▓▓▓   ▓▓   ▓▓▓▓▓▓   ▓  ▓▓▓▓▓▓▓▓▓▓▓▓▓  ▓▓▓   ▓▓   ▓▓   ▓▓▓   ▓▓   ▓▓   ▓   ▓");
Console.WriteLine("█    ███████   █████      ████     ████  ██  ███   ████   ████████   █████   ██   ");
Console.WriteLine("██████████████████████████████████████████████████████████████████████████████████");
Console.ForegroundColor = ConsoleColor.White;

    Console.Title = "rOsE.hOoK";
    Console.CursorVisible = false;
    Console.SetCursorPosition(1, 1);

    for (int i = 0; i < 50; i++)
    {
        for (int y = 0; y < i; y++)
        {
            string pb = "\u2551";
            Console.WriteLine(pb);
        }
        Console.Write(i + " /50");
        Console.SetCursorPosition(1 ,1);
        System.Threading.Thread.Sleep(50);
    }
Console.ReadLine();


