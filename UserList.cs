using System.Collections.Generic;

namespace todo_app
{
    public class UserList
    {
        public List<User> all = new List<User>();

        public UserList()
        {
            all.Add(new User(1, "Yunus Emre Çalışkan"));
            all.Add(new User(2, "Aslıhan Atıcı"));
            all.Add(new User(3, "Elif Bektaş"));
            all.Add(new User(4, "Ahmet Çinici"));
        }
    }
}