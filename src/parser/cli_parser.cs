using CommandModel;

namespace CliParser {
    public static class ParserTools {
        
        // barebones and fairly simple CLI parser with fixed commands
        // not doing proper error/exception handling 
        public static Command ParseArgsToCommand(List<string> args) {
            if (args.Contains("->") && args.Count > 3) {
                return new Command(CommandType.Posting, String.Join(" ", args));
            }
            else if (args.Count == 1 && args[0] != "") {
                return new Command(CommandType.Reading, String.Join(" ", args));
            }
            else if (args.Count == 3 && args.Contains("follows")) {
                return new Command(CommandType.Following, String.Join(" ", args));
            }
            else if (args.Count == 3 && args.Contains("wall")) {
                return new Command(CommandType.Wall, String.Join(" ", args));
            }
            else {
                return new Command(CommandType.Invalid, "Invalid");
            }
        }
    }

    
}