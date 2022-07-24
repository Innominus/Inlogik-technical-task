namespace Users {
    public class Users {
        Dictionary<string, User> users = new Dictionary<string, User>();
    }

    public class User {
        public string name;
        public string[] messageBoards;
    }
}