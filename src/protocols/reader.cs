using ProjectBoard;

namespace Reader {
    public class BoardReader {
        public static void ReadBoard(ProjectBoards projectBoards, string boardName) {
            projectBoards.PrintBoard(boardName);
        }
    }
}