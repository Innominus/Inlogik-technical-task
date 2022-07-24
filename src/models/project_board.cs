namespace ProjectBoard {
    public class ProjectBoards {
        Dictionary<string, Board> messageBoards = new Dictionary<string, Board>();

    }

    class Board {
        private string boardName;
        private List<Message> boardMessages = new List<Message>();
        public Board(string boardName) {
            this.boardName = boardName;
        }
    }

    class Message {
        private string message;
        private string author;
        private string date;

        private Message(string message, string author, string date) {
            this.message = message;
            this.author = author;
            this.date = date;
        }
    }
}