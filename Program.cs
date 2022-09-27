using ConsoleNumberGuessingGame1;

while (true)
{
    Console.OutputEncoding = System.Text.Encoding.Unicode;

    Console.WriteLine(@"
                    | \ | |               | |              
                    |  \| |_   _ _ __ ___ | |__   ___ _ __ 
                    | . ` | | | | '_ ` _ \| '_ \ / _ \ '__|
                    | |\  | |_| | | | | | | |_) |  __/ |   
                    |_| \_|\__,_|_| |_| |_|_.__/ \___|_|   
                                       
                                       
      _____                     _                _____                      
     / ____|                   (_)              / ____|                     
    | |  __ _   _  ___  ___ ___ _ _ __   __ _  | |  __  __ _ _ __ ___   ___ 
    | | |_ | | | |/ _ \/ __/ __| | '_ \ / _` | | | |_ |/ _` | '_ ` _ \ / _ \
    | |__| | |_| |  __/\__ \__ \ | | | | (_| | | |__| | (_| | | | | | |  __/
     \_____|\__,_|\___||___/___/_|_| |_|\__, |  \_____|\__,_|_| |_| |_|\___|
                                         __/ |                              
                                        |___/                               ");

    var save = SaveController.DecodeSave(SaveController.ReadResults());

    if (save[0] == -1)
    {
        Console.WriteLine($"\n\t\tTotal Games: {0}" +
                          $"\t\tTotal Score: {0}" +
                          $"\t\tAverage Score: {0}");

    }
    else
    {
        Console.WriteLine($"\n\t\tTotal Games: {save.Count}" +
                          $"\t\tTotal Score: {save.Sum()}" +
                          $"\t\tAverage Score: {save.Average()}");

    }

    Console.WriteLine("\n\t\t\tPress (S) to start the game\tPress (E) to exit");
    var s = Console.ReadKey(true).Key;
    switch (s)
    {
        case ConsoleKey.S: TheGame.Start(); break;
        case ConsoleKey.E: Environment.Exit(0); break;
    }
    Console.Clear();
}
