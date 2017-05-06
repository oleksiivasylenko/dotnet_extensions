namespace ExtensionTests.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Role Role { get; set; }

        public User()
        {
        }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public User(int id, string name, Role role)
        {
            Id = id;
            Name = name;
            Role = role;
        }
    }
}
