using Users;
using ProjectBoard;
using Writer;
using Reader;

namespace CommandModel {
    public class Command {
        public CommandType commandType;
        public string commandValue;
        public List<string> commandArgs;

        public Command(CommandType commandType, string commandValue) {
            this.commandType = commandType;
            this.commandValue = commandValue;
            this.commandArgs = commandValue.Split(" ").ToList();
        }

        public void PerformCommand(UserRecord userList, ProjectBoards projectBoards) {
            switch(this.commandType) {
                case CommandType.Posting:
                    Console.WriteLine("Posting to board: " + this.commandArgs[2].Replace("@", ""));
                    BoardWriter.PostToBoard(userList, projectBoards, this.commandArgs);
                    break;
                case CommandType.Reading:
                    Console.WriteLine("Reading board: " + this.commandArgs[0]);
                    BoardReader.ReadBoard(projectBoards, this.commandArgs[0]);
                    break;
                case CommandType.Following:
                    Console.WriteLine("Following board: " + this.commandArgs[2]);
                    break;
                case CommandType.Wall:
                    Console.WriteLine("Wall board");
                    break;
                case CommandType.Invalid:
                    Console.WriteLine("Invalid command");
                    break;
            }
        }

    }

    public enum CommandType {
        Posting,
        Reading,
        Following,
        Wall,
        Invalid
    }
}