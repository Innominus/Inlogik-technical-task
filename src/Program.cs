using CliParser;
using CommandModel;
using Users;
using ProjectBoard;

Console.WriteLine("Welcome to the Projects Message Board. Please enter a command below");

// create state instances for application
UserRecord userRecord = new UserRecord();
ProjectBoards projectBoards = new ProjectBoards();

while(true) {
    // read commands and then turn them into a command. Proceed to perform command
    List<string>? commandArguments = Console.ReadLine().Split(" ").ToList();
    Command command = ParserTools.ParseArgsToCommand(commandArguments);
    command.PerformCommand(userRecord, projectBoards);
}