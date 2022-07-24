using CliParser;

Console.WriteLine("Welcome to the Projects Message Board. Please enter a command below");



while(true) {
    string[]? commandArguments = Console.ReadLine().Split(" ");
    Command command = ParserTools.ParseArgsToCommands(commandArguments);
    command.PerformCommand();
}