namespace ProjectBoard {
    public class ProjectBoards {
        Dictionary<string, Board> messageBoards = new Dictionary<string, Board>();
    
    public void AddMessage(string boardName, string message, string author) {
        
            if (this.messageBoards.ContainsKey(boardName)) {
                this.messageBoards[boardName].boardMessages.Add(new Message(message, author, DateTime.Now.ToString()));
            }
            else {
                this.messageBoards.Add(boardName, new Board(boardName));
                this.messageBoards[boardName].boardMessages.Add(new Message(message, author, DateTime.Now.ToString()));
            }
        }

    public void PrintBoard(string boardName) {
        if (this.messageBoards.ContainsKey(boardName)) {
            this.messageBoards[boardName].PrintMessages();
        }
        else {
            Console.WriteLine("Board does not exist");
        }
    }
    }
    
    internal class Board {
        internal string boardName;
        internal List<Message> boardMessages = new List<Message>();
        internal Board(string boardName) {
            this.boardName = boardName;
        }

        internal void PrintMessages() {
            string previousAuthor = "";
            foreach (Message message in this.boardMessages) {
                
                int minutesPassed = (int)DateTime.Now.Subtract(DateTime.Parse(message.date)).TotalMinutes;
                if (previousAuthor != message.author) {
                    Console.WriteLine(message.author);
                }
                Console.WriteLine($"{message.message} ({minutesPassed} minute ago)");
                previousAuthor = message.author;
            }
        }
    }

    internal class Message {
        internal string message;
        internal string author;
        internal string date;

        internal Message(string message, string author, string date) {
            this.message = message;
            this.author = author;
            this.date = date;
        }
    }
}