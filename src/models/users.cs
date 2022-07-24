namespace Users {
    public class UserRecord {
        Dictionary<string, User> users = new Dictionary<string, User>();
        
        public void AddToUserRecord(string author) {
           if (this.users.ContainsKey(author)) {
                return;
            }
            else {
                this.users.Add(author, new User(author));
            }
        }
        
        public void CheckUserRecord(string author) {
            if (!this.users.ContainsKey(author)) {
                this.AddToUserRecord(author);
            }
        }
    }   

    public class User {
        public string name;
        public List<string> walledBoards = new List<string>();
        
        public User(string name) {
            this.name = name;
        }
    }
}