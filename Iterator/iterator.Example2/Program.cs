
using Iterator.Example2;

List<User> users = new List<User>
{
    new User { Name = "Alice" },
    new User { Name = "Bob" },
    new User { Name = "Charlie" }
};


UserCollection userCollection = new UserCollection(users);
Client client = new Client();

client.ShowUsers(userCollection);