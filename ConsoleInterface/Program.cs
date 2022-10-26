

    E:
    Console.Clear();
    Menu.ShowMenu();
    ConsoleKeyInfo option = Console.ReadKey();
    Console.WriteLine("\n");

    try{
        Menu.Execute(option);
        Console.ReadKey();
    }
    catch(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Problem: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write($"Problem: {ex.Message} !");
        Console.ReadKey();
    }
    goto E;





//trzeba zrobić validacje i przejrzeć kod