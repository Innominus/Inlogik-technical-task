namespace CliParser {
    public static class ParserTools {
        
        // barebones and fairly simple CLI parser with fixed commands
        // not doing proper error/exception handling 
        public static Command ParseArgsToCommands(string[] args) {
            if (args.Contains("->") && args.Length > 3) {
                return new Command(CommandType.Posting, String.Join(" ", args));
            }
            else if (args.Length == 1 && args[0] != "") {
                return new Command(CommandType.Reading, String.Join(" ", args));
            }
            else if (args.Length == 3 && args.Contains("follows")) {
                return new Command(CommandType.Following, String.Join(" ", args));
            }
            else if (args.Length == 2 && args.Contains("wall")) {
                return new Command(CommandType.Wall, String.Join(" ", args));
            }
            else {
                return new Command(CommandType.Invalid, "Invalid");
            }
        }
    }

    public class Command {
        public CommandType commandType;
        public string commandValue;
        public string[] commandArgs;

        public Command(CommandType commandType, string commandValue) {
            this.commandType = commandType;
            this.commandValue = commandValue;
            this.commandArgs = commandValue.Split(" ");
        }

        public void PerformCommand() {
            switch(this.commandType) {
                case CommandType.Posting:
                    Console.WriteLine("Posting to board: " + this.commandArgs[2].Replace("@", ""));
                    break;
                case CommandType.Reading:
                    Console.WriteLine("Reading board: " + this.commandArgs[0]);
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
            
            Console.WriteLine("Continuing");
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