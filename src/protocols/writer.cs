using ProjectBoard;
using Users;

namespace Writer {
    public static class BoardWriter {
        public static void PostToBoard(UserRecord userList, ProjectBoards projectBoards, List<string> commandArgs) {
            string author = RetrieveAuthor(commandArgs);
            string boardName = RetrieveBoardName(commandArgs);
            string message = BoardWriter.RetrieveMessage(commandArgs);
            userList.CheckUserRecord(author);
            projectBoards.AddMessage(boardName, message, author);
        }

        static string RetrieveAuthor(List<string> commandArgs) {
            return commandArgs[0];
        }
        static string RetrieveBoardName(List<string> commandArgs) {
            return commandArgs[2].Replace("@", "");
        }

        static string RetrieveMessage(List<string> commandArgs) {
            return String.Join(" ", commandArgs.GetRange(3, commandArgs.Count - 3));
        }
        
    }
    
    
}